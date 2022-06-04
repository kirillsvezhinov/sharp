
namespace шарп_проект
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.roleList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user_login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.user_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.municipalityList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(12, 74);
            this.user_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(158, 23);
            this.user_name.TabIndex = 1;
            // 
            // roleList
            // 
            this.roleList.FormattingEnabled = true;
            this.roleList.ItemHeight = 15;
            this.roleList.Items.AddRange(new object[] {
            "Куратор ВетСлужбы",
            "Куратор ОМСУ",
            "Куратор по отлову",
            "Куратор приюта",
            "Подписант ВетСлужбы",
            "Подписант ОМСУ",
            "Подписант по отлову",
            "Подписант приюта",
            "Оператор ВетСлужбы",
            "Оператор ОМСУ"});
            this.roleList.Location = new System.Drawing.Point(192, 74);
            this.roleList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roleList.Name = "roleList";
            this.roleList.Size = new System.Drawing.Size(175, 79);
            this.roleList.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя";
            // 
            // user_login
            // 
            this.user_login.Location = new System.Drawing.Point(12, 157);
            this.user_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_login.Name = "user_login";
            this.user_login.Size = new System.Drawing.Size(158, 23);
            this.user_login.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Логин";
            // 
            // user_password
            // 
            this.user_password.Location = new System.Drawing.Point(12, 245);
            this.user_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_password.Name = "user_password";
            this.user_password.Size = new System.Drawing.Size(158, 23);
            this.user_password.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Должность";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(107, 283);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 22);
            this.button1.TabIndex = 11;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // municipalityList
            // 
            this.municipalityList.FormattingEnabled = true;
            this.municipalityList.ItemHeight = 15;
            this.municipalityList.Items.AddRange(new object[] {
            "Абатский район",
            "Армизонский район",
            "Аромашевский район",
            "Бердюжский район",
            "Вагайский район",
            "Викуловский район",
            "Голышмановский - городской округ",
            "Заводоуковский - городской округ",
            "Исетский район",
            "Ишим - городской округ",
            "Ишимский район",
            "Казанский район",
            "Нижнетавдинский район",
            "Омутинский район",
            "Сладковский район",
            "Сорокинский район",
            "Тобольск - городской округ",
            "Тобольский район",
            "Тюменский район",
            "Тюмень - городской округ",
            "Уватский район\"",
            "Упоровский район",
            "Юргинский район",
            "Ялуторовск - городской округ",
            "Ялуторовский район",
            "Ярковский район"});
            this.municipalityList.Location = new System.Drawing.Point(189, 189);
            this.municipalityList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.municipalityList.Name = "municipalityList";
            this.municipalityList.Size = new System.Drawing.Size(175, 79);
            this.municipalityList.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Муниципальное образование";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 316);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.municipalityList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.user_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roleList);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.ListBox roleList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox municipalityList;
        private System.Windows.Forms.Label label6;
    }
}