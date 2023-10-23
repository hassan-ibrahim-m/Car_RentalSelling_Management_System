using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_RentalSelling_Management_System.Forms
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (txt_admin.Text == "" || txt_adminPassword.Text == "" || txt_userPhone.Text == "" || txt_password.Text == "" || txt_confirmPassword.Text == "")
                MessageBox.Show("Please fill all the fields");
            else
            {
                if(txt_password.Text != txt_confirmPassword.Text)
                {
                    MessageBox.Show("Password Mismatch");
                }
                else
                {
                    Connection.OpenConection();
                    User user = Connection.SelectUser(txt_admin.Text, txt_adminPassword.Text);
                    Connection.CloseConnection();
                    if (user != null) // User Exists
                    {
                        Connection.OpenConection();
                        string query = string.Format("update users set Password = '{0}' where ID = '{1}'",txt_password.Text, txt_userPhone.Text);
                        string response = Connection.Execute(query);
                        if(response=="1")
                        {
                            MessageBox.Show("Done");
                        }
                        else
                        {
                            MessageBox.Show("Error occured!, Please try again");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No user found!");
                    }
                }
            }
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
