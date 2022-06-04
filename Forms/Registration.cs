using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace шарп_проект
{
    public partial class Registration : Form
    {
        private AuthController authController;
        public Registration()
        {
            this.authController = new AuthController();
            InitializeComponent();
            user_name.TextChanged += changeEvent;
            user_login.TextChanged += changeEvent;
            user_password.TextChanged += changeEvent;
            roleList.SelectedIndexChanged += changeEvent;
            municipalityList.SelectedIndexChanged += changeEvent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var registredUser = authController.singUp(user_name.Text,user_login.Text,user_password.Text,
                roleList.SelectedIndex+1,municipalityList.SelectedIndex+1);

            if (registredUser != null)
            {
                var tableForm = new Table();
                tableForm.user = registredUser;
                this.Hide();
                tableForm.ShowDialog();
            }
            else
                MessageBox.Show("Пользователь с таким логином уже существует");

        }

        private void changeEvent(object sender, EventArgs e)
        {
            if (user_name.Text != "" && user_login.Text != "" && user_password.Text != ""
                && roleList.SelectedIndex != -1 && municipalityList.SelectedIndex != -1)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }
    }
}
