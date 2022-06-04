using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace шарп_проект
{
    public partial class Auth : Form
    {
        private AuthController authController;
        public Auth()
        {
            this.authController = new AuthController();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var authUser = authController.singIn(textBox1.Text, textBox2.Text);

            if (authUser != null)
            {
                var tableForm = new Table();
                tableForm.user = authUser;
                Hide();
                tableForm.Show();
                tableForm.FormClosed += closeProgram;
            }
            else
                MessageBox.Show("Введен неверный логин или пароль");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registrationForm = new Registration();
            registrationForm.ShowDialog();
        }

        private void closeProgram(object sender, FormClosedEventArgs e) => this.Close();
      
    }
}
