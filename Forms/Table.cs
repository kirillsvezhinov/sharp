using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace шарп_проект
{
    public partial class Table : Form
    {
        internal User user;
        private TableController tableController;
        private CardController cardController;
        private ExportImporter exportImporter;
        private int paginationCount;
        private Dictionary<string, string> filterList;
        private List<string> sortList;
        public Table()
        {
            InitializeComponent();
            tableController = new TableController();
            cardController = new CardController();
            exportImporter = new ExportImporter();
            paginationCount = 1;
            filterList = new Dictionary<string, string>();
            sortList = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var detail = new detail();
            detail.FormClosing += new FormClosingEventHandler(FormClosingEvent);
            detail.user = user;
            detail.ShowDialog();
        }

        private void FormClosingEvent(object sender, EventArgs e) 
        {
            var organizations = tableController.GetOrganizationsWithPagination(paginationCount, filterList, sortList);
            FillTable(organizations);
            dataGridView1.ClearSelection();
            delete_btn.Enabled = false;

        }
        private void Table_Load(object sender, EventArgs e)
        {
            if (user.Role_FK == 2 || user.Role_FK == 6 || user.Role_FK == 10)
                filterList.Add("Municipality_FK", user.Municipality_FK.ToString());
          

            var organizations = tableController.GetOrganizationsWithPagination(paginationCount, filterList, sortList);
            if (user.Role_FK == 9 || user.Role_FK == 10) 
            {
                delete_btn.Visible = true;
                create_btn.Visible = true;
            }
            label1.Text = user.User_Name;
            label2.Text = user.Role.Role_Name;
            FillTable(organizations);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ClearSelection();
            if (organizations.Count < paginationCount)
                pagination_btn.Enabled = false;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
                column.SortMode = DataGridViewColumnSortMode.Programmatic;  
        }

        private void FillTable(List<Organization> organizations) 
        {
            dataGridView1.Rows.Clear();
            foreach (var org in organizations)
                dataGridView1.Rows.Add(org.Organization_Id,org.Organization_Name,org.INN,org.KPP,
                    org.Address,org.Organization_Type.Type_Name,org.Organization_Sign.Sign_Name, org.Organization_Type_FK);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            detail cardForm = new detail();
            cardForm.FormClosing += new FormClosingEventHandler(FormClosingEvent);
            cardForm.user = user;
            cardForm.organization = cardController.GetOrganization(id);
            cardForm.ShowDialog();
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1) 
            {
                int type_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[7].Value);
                if (user.Role_FK == 9)
                {
                    if (type_id == 1 || type_id == 2 || type_id == 7)
                        delete_btn.Enabled = true;
                    else
                        delete_btn.Enabled = false;
                }
                else if (user.Role_FK == 10) 
                {
                    if (type_id != 1 && type_id != 2 && type_id != 7)
                        delete_btn.Enabled = true;
                    else
                        delete_btn.Enabled = false;
                }

                
            }
            else
                delete_btn.Enabled = false;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить запись?",
                "Удаление",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                tableController.DeleteOrganization(id);
                var organizations = tableController.GetOrganizationsWithPagination(paginationCount, filterList,sortList);
                FillTable(organizations);
            }
        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            bool resulExport = exportImporter.ExportToExcel(filterList, sortList);
            if (resulExport)
                MessageBox.Show("Успешно! Файл сохранен на рабочем столе");
            else
                MessageBox.Show("Экспорт закончился ошибкой");
        }

        private void pagination_btn_Click(object sender, EventArgs e)
        {
            paginationCount += 1;
            var organizations = tableController.GetOrganizationsWithPagination(paginationCount, filterList, sortList);
            FillTable(organizations);
            if (organizations.Count < paginationCount)
                pagination_btn.Enabled = false;
            dataGridView1.ClearSelection();
        }

        private void CheckRadioButton(object sender, EventArgs e) 
        {
            int sign_fk = 0;

            if (ip_radio.Checked)
                sign_fk = 1;
            else if (leg_radio.Checked)
                sign_fk = 2;

            if (filterList.ContainsKey("Sign_FK"))
                filterList["Sign_FK"] = sign_fk.ToString();
            else
                filterList.Add("Sign_FK", sign_fk.ToString());

            if (all_radio.Checked && filterList.ContainsKey("Sign_FK"))
                filterList.Remove("Sign_FK");

            var organizations = tableController.GetOrganizationsWithPagination(paginationCount, filterList, sortList);
            FillTable(organizations);
        }

        private void CheckSelectedIndex(object sender, EventArgs e) 
        {
            if (comboBox3.SelectedIndex == 0 && filterList.ContainsKey("Organization_Type_FK"))
                filterList.Remove("Organization_Type_FK");
            else 
            {
                if (filterList.ContainsKey("Organization_Type_FK"))
                    filterList["Organization_Type_FK"] = comboBox3.SelectedIndex.ToString();
                else
                    filterList.Add("Organization_Type_FK", comboBox3.SelectedIndex.ToString());
            }

            var organizations = tableController.GetOrganizationsWithPagination(paginationCount, filterList, sortList);
            FillTable(organizations);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            clearFilter();

            if (comboBox2.SelectedIndex == 0)
                filterList.Add("Organization_Name", textBox1.Text);
            else if (comboBox2.SelectedIndex == 1)
                filterList.Add("INN", textBox1.Text);
            else if (comboBox2.SelectedIndex == 2)
                filterList.Add("KPP", textBox1.Text);
            else if (comboBox2.SelectedIndex == 3)
                filterList.Add("Address", textBox1.Text);

            var organizations = tableController.GetOrganizationsWithPagination(paginationCount, filterList, sortList);
            FillTable(organizations);
            search_btn.Enabled = false;
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            search_btn.Enabled = false;
            textBox1.Text = "";
            clearFilter();

            var organizations = tableController.GetOrganizationsWithPagination(paginationCount, filterList, sortList);
            FillTable(organizations);
        }

        private void SearchChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && comboBox2.SelectedIndex == -1)
                search_btn.Enabled = false;
            else  if (textBox1.Text != "" && comboBox2.SelectedIndex != -1)
                search_btn.Enabled = true;
        }

        private void clearFilter() 
        {

            if (filterList.ContainsKey("Organization_Name"))
                filterList.Remove("Organization_Name");

            if (filterList.ContainsKey("INN"))
                filterList.Remove("INN");

            if (filterList.ContainsKey("KPP"))
                filterList.Remove("KPP");

            if (filterList.ContainsKey("Address"))
                filterList.Remove("Address");
        }

        private void dataGridView_ColumnHeaderClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var headerText = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            var nameColumn = dataGridView1.Columns[e.ColumnIndex].Name;
            if (sortList.Contains(nameColumn + "DESC"))
            {
                sortList.Remove(nameColumn + "DESC");
                headerText = headerText.Substring(0, headerText.Length - 2);
                dataGridView1.Columns[e.ColumnIndex].HeaderText = headerText;
            }
            else if (sortList.Contains(nameColumn + "ASC"))
            {
                headerText = headerText.Substring(0, headerText.Length - 2);
                var index = sortList.IndexOf(nameColumn + "ASC");
                sortList[index] = nameColumn + "DESC";
                dataGridView1.Columns[e.ColumnIndex].HeaderText = headerText + " ↓";
            }
            else
            {
                sortList.Add(nameColumn + "ASC");
                dataGridView1.Columns[e.ColumnIndex].HeaderText = headerText + " ↑";
            }
               
            var organizations = tableController.GetOrganizationsWithPagination(paginationCount,filterList,sortList);
            FillTable(organizations);
        }
    }
}
