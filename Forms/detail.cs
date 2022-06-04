using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace шарп_проект
{
    public partial class detail : Form
    {
        internal Organization organization;
        private CardController cardController;
        internal User user;
        public detail()
        {
            InitializeComponent();
            cardController = new CardController();
        }
    
        private void detail_Load(object sender, EventArgs e)
        {
            name_org.TextChanged += changeEvent;
            address_org.TextChanged += changeEvent;
            inn_org.TextChanged += changeEvent;
            kpp_org.TextChanged += changeEvent;
            sign_org.SelectedIndexChanged += changeEvent;
            type_org.SelectedIndexChanged += changeEvent;
            

            fillComboboxes();

            if (organization != null)
            {
                name_org.Text = organization.Organization_Name;
                inn_org.Text = organization.INN.ToString();
                kpp_org.Text = organization.KPP.ToString();
                address_org.Text = organization.Address;
                name_org.ReadOnly = true;
                inn_org.ReadOnly = true;
                kpp_org.ReadOnly = true;
                address_org.ReadOnly = true;
                type_org.Enabled = false;
                sign_org.Enabled = false;

                var organization_type_id = organization.Organization_Type_FK;
                bool checkType = checkOrgType(organization_type_id);

                if (checkType)
                {
                    fillType_ComboBox(true);
                    save_btn.Visible = false;
                    update_btn.Visible = true;
                }
                else
                {
                    save_btn.Visible = false;
                    fillType_ComboBox(false);
                    type_org.Text = organization.Organization_Type.Type_Name;
                }
                mun_org.Text = organization.Municipality.Municipality_Name;
                type_org.Text = organization.Organization_Type.Type_Name;
                sign_org.Text = organization.Organization_Sign.Sign_Name;
            }
            else
            {
                fillType_ComboBox(true);
                mun_org.Text = user.Municipality.Municipality_Name;
            }
        }

        private bool checkOrgType(int organization_type_id) 
        {
            if ((user.Role_FK == 9) && (organization_type_id == 1 || organization_type_id == 2 || organization_type_id == 7))
                    return true;
            else if ((user.Role_FK == 10) && (organization_type_id != 1 && organization_type_id != 2 && organization_type_id != 7))
                    return true;
            return false;
        }

        private void fillComboboxes() 
        {
            Dictionary<int, string> sourceForComboboxSign = new Dictionary<int, string>();
            Dictionary<int, string> sourceForComboboxMunicipality = new Dictionary<int, string>();

            var organization_signs = cardController.GetAllOrgSign();
            foreach (var sign in organization_signs)
                sourceForComboboxSign.Add(sign.Organization_Sign_Id, sign.Sign_Name);

            sign_org.DataSource = new BindingSource(sourceForComboboxSign, null);
            sign_org.DisplayMember = "Value";
            sign_org.ValueMember = "Key";


            var organization_municipality = cardController.GetMunicipality();
            foreach (var municipality in organization_municipality)
                sourceForComboboxMunicipality.Add(municipality.Municipality_Id, municipality.Municipality_Name);

            mun_org.DataSource = new BindingSource(sourceForComboboxMunicipality, null);
            mun_org.DisplayMember = "Value";
            mun_org.ValueMember = "Key";
        }

        private void fillType_ComboBox(bool checkOrgType) 
        {
            Dictionary<int, string> sourceForComboboxType = new Dictionary<int, string>();
            
            var organization_types = cardController.GetAllOrgType();

            if (checkOrgType && user.Role_FK == 9)
                organization_types = cardController.GetOrgTypeForVet();
            else if (checkOrgType && user.Role_FK == 10)
                organization_types = cardController.GetOrgTypeForOMSU();

            foreach (var type in organization_types)
                sourceForComboboxType.Add(type.Organization_Type_Id, type.Type_Name);

            type_org.DataSource = new BindingSource(sourceForComboboxType, null);
            type_org.DisplayMember = "Value";
            type_org.ValueMember = "Key";
        }

        private void cancel_btn_Click(object sender, EventArgs e) => this.Close();
       
        private void update_btn_Click(object sender, EventArgs e)
        {
            name_org.ReadOnly = false;
            inn_org.ReadOnly = false;
            kpp_org.ReadOnly = false;
            address_org.ReadOnly = false;
            type_org.Enabled = true;
            sign_org.Enabled = true;
            save_btn.Visible = true;
            update_btn.Visible = false;
            if (user.Role_FK == 9)
                mun_org.Enabled = true;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            var selected_sign = ((KeyValuePair<int, string>)sign_org.SelectedItem).Key;
            var selected_type = ((KeyValuePair<int, string>)type_org.SelectedItem).Key;
            var selected_municipality = ((KeyValuePair<int, string>)mun_org.SelectedItem).Key;
            if (organization != null)
            {
                organization.Organization_Name = name_org.Text;
                organization.Address = address_org.Text;
                organization.INN = inn_org.Text;
                organization.KPP = kpp_org.Text;
                organization.Organization_Sign_FK = selected_sign;
                organization.Organization_Type_FK = selected_type;
                if (user.Role_FK == 9)
                    organization.Municipality_FK = selected_municipality;
                cardController.UpdateOrganization(organization);
                MessageBox.Show("Информация обновлена");
            }
            else 
            {
                var municipality_id = user.Municipality_FK;
                if (user.Role_FK == 9)
                    municipality_id = selected_municipality;
                cardController.CreateOrganization(name_org.Text, inn_org.Text,kpp_org.Text, address_org.Text,
                    selected_type,selected_sign, municipality_id);
                MessageBox.Show("Организация успешно добавлена");
            }
            this.Close();
        }

        private void changeEvent(object sender, EventArgs e)
        {
            if (name_org.Text != "" && address_org.Text != "" && inn_org.Text != ""
                &&kpp_org.Text != "" && sign_org.SelectedIndex != -1 && mun_org.SelectedIndex != -1
                && type_org.SelectedIndex != -1)
                save_btn.Enabled = true;
            else
                save_btn.Enabled = false;
        }
    }
}