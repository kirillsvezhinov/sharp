
namespace шарп_проект
{
    partial class Table
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.create_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.all_radio = new System.Windows.Forms.RadioButton();
            this.ip_radio = new System.Windows.Forms.RadioButton();
            this.leg_radio = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.export_btn = new System.Windows.Forms.Button();
            this.pagination_btn = new System.Windows.Forms.Button();
            this.Organization_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organization_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_FK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sign_FK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Org_Type_FK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // create_btn
            // 
            this.create_btn.Location = new System.Drawing.Point(358, 22);
            this.create_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(82, 22);
            this.create_btn.TabIndex = 0;
            this.create_btn.Text = "Добавить";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Visible = false;
            this.create_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(718, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Андрей";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(718, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Оператор ОМСУ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Organization_Id,
            this.Organization_Name,
            this.INN,
            this.KPP,
            this.Address,
            this.Type_FK,
            this.Sign_FK,
            this.Org_Type_FK});
            this.dataGridView1.Location = new System.Drawing.Point(171, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(668, 441);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ColumnHeaderClick);
            // 
            // delete_btn
            // 
            this.delete_btn.Enabled = false;
            this.delete_btn.Location = new System.Drawing.Point(445, 22);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(82, 22);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Visible = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Фильтровать";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "По названию",
            "По ИНН",
            "По КПП",
            "По адресу регистрации"});
            this.comboBox2.Location = new System.Drawing.Point(5, 22);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(133, 23);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.SearchChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.all_radio);
            this.groupBox1.Controls.Add(this.ip_radio);
            this.groupBox1.Controls.Add(this.leg_radio);
            this.groupBox1.Location = new System.Drawing.Point(10, 169);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(155, 113);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "По признаку организации";
            // 
            // all_radio
            // 
            this.all_radio.AutoSize = true;
            this.all_radio.Checked = true;
            this.all_radio.Location = new System.Drawing.Point(10, 46);
            this.all_radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.all_radio.Name = "all_radio";
            this.all_radio.Size = new System.Drawing.Size(44, 19);
            this.all_radio.TabIndex = 13;
            this.all_radio.TabStop = true;
            this.all_radio.Text = "Все";
            this.all_radio.UseVisualStyleBackColor = true;
            this.all_radio.CheckedChanged += new System.EventHandler(this.CheckRadioButton);
            // 
            // ip_radio
            // 
            this.ip_radio.AutoSize = true;
            this.ip_radio.Location = new System.Drawing.Point(10, 68);
            this.ip_radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ip_radio.Name = "ip_radio";
            this.ip_radio.Size = new System.Drawing.Size(43, 19);
            this.ip_radio.TabIndex = 12;
            this.ip_radio.Text = "ИП";
            this.ip_radio.UseVisualStyleBackColor = true;
            this.ip_radio.CheckedChanged += new System.EventHandler(this.CheckRadioButton);
            // 
            // leg_radio
            // 
            this.leg_radio.AutoSize = true;
            this.leg_radio.Location = new System.Drawing.Point(10, 91);
            this.leg_radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leg_radio.Name = "leg_radio";
            this.leg_radio.Size = new System.Drawing.Size(75, 19);
            this.leg_radio.TabIndex = 11;
            this.leg_radio.Text = "Юр лицо";
            this.leg_radio.UseVisualStyleBackColor = true;
            this.leg_radio.CheckedChanged += new System.EventHandler(this.CheckRadioButton);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 59);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 23);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.SearchChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Все",
            "Исполнительный орган государственной власти ",
            "Орган местного самоуправления ",
            "Приют ",
            "Организация по отлову ",
            "Организация по отлову и приют ",
            "Организация по транспортировке ",
            "Ветеринарная клиника: государственная ",
            "Ветеринарная клиника: муниципальная ",
            "Ветеринарная клиника: частная ",
            "Благотворительный фонд ",
            "Организации по продаже товаров и предоставлению услуг для животных"});
            this.comboBox3.Location = new System.Drawing.Point(10, 329);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(133, 23);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.CheckSelectedIndex);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Тип организации";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reset_btn);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.search_btn);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Location = new System.Drawing.Point(10, 34);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(155, 121);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(70, 92);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(68, 23);
            this.reset_btn.TabIndex = 19;
            this.reset_btn.Text = "Сбросить";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Enabled = false;
            this.search_btn.Location = new System.Drawing.Point(5, 92);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(54, 24);
            this.search_btn.TabIndex = 18;
            this.search_btn.Text = "Поиск";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.export_btn);
            this.groupBox3.Location = new System.Drawing.Point(10, 388);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(155, 72);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Экспорт в Excel";
            // 
            // export_btn
            // 
            this.export_btn.Location = new System.Drawing.Point(9, 30);
            this.export_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(122, 22);
            this.export_btn.TabIndex = 0;
            this.export_btn.Text = "Экспортировать";
            this.export_btn.UseVisualStyleBackColor = true;
            this.export_btn.Click += new System.EventHandler(this.export_btn_Click);
            // 
            // pagination_btn
            // 
            this.pagination_btn.Location = new System.Drawing.Point(171, 22);
            this.pagination_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pagination_btn.Name = "pagination_btn";
            this.pagination_btn.Size = new System.Drawing.Size(166, 23);
            this.pagination_btn.TabIndex = 17;
            this.pagination_btn.Text = "Показать больше";
            this.pagination_btn.UseVisualStyleBackColor = true;
            this.pagination_btn.Click += new System.EventHandler(this.pagination_btn_Click);
            // 
            // Organization_Id
            // 
            this.Organization_Id.HeaderText = "ID";
            this.Organization_Id.Name = "Organization_Id";
            this.Organization_Id.ReadOnly = true;
            this.Organization_Id.Visible = false;
            // 
            // Organization_Name
            // 
            this.Organization_Name.HeaderText = "Наименование организации";
            this.Organization_Name.Name = "Organization_Name";
            this.Organization_Name.ReadOnly = true;
            // 
            // INN
            // 
            this.INN.HeaderText = "ИНН";
            this.INN.Name = "INN";
            this.INN.ReadOnly = true;
            // 
            // KPP
            // 
            this.KPP.HeaderText = "КПП";
            this.KPP.Name = "KPP";
            this.KPP.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес регистрации";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Type_FK
            // 
            this.Type_FK.HeaderText = "Тип организации";
            this.Type_FK.Name = "Type_FK";
            this.Type_FK.ReadOnly = true;
            // 
            // Sign_FK
            // 
            this.Sign_FK.HeaderText = "Признак организации";
            this.Sign_FK.Name = "Sign_FK";
            this.Sign_FK.ReadOnly = true;
            // 
            // Org_Type_FK
            // 
            this.Org_Type_FK.HeaderText = "Тип";
            this.Org_Type_FK.Name = "Org_Type_FK";
            this.Org_Type_FK.ReadOnly = true;
            this.Org_Type_FK.Visible = false;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 512);
            this.Controls.Add(this.pagination_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.create_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Table";
            this.Text = "Реестр организации";
            this.Load += new System.EventHandler(this.Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton all_radio;
        private System.Windows.Forms.RadioButton ip_radio;
        private System.Windows.Forms.RadioButton leg_radio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button export_btn;
        private System.Windows.Forms.Button pagination_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organization_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organization_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn INN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_FK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sign_FK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Org_Type_FK;
    }
}