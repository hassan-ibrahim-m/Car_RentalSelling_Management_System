using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_RentalSelling_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Navigate to the registration interface
            Register Register = new Register();
            Register.Show();
            Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Forms.ForgetPassword forgetPassword = new Forms.ForgetPassword();
            forgetPassword.Show();
            Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_username.Text == "" || txt_password.Text == "")
                MessageBox.Show("Please type your username and password!");
            else
            {
                Connection.OpenConection();
                User user = Connection.SelectUser(txt_username.Text, txt_password.Text);
                Connection.CloseConnection();
                if (user != null) // User Exists
                {                  
                    if(user.accountType == "Customer")
                    {
                        CustomerHome ch = new CustomerHome(user);
                        ch.Show();
                        Hide();
                    }
                    else
                    {
                        OwnerHome ch = new OwnerHome(user);
                        ch.Show();
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
