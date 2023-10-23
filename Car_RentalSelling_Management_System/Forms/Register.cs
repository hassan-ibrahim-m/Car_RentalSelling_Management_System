using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_RentalSelling_Management_System
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Navigate to the login interface
            Login Login = new Login();
            Login.Show();
            Hide();

        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            
            if (txt_Fname.Text == "" || txt_Lname.Text == "" || txt_phone.Text == "" || cb_accountType.SelectedIndex == -1 || txt_Password.Text == "" || txt_confirmPassword.Text == "")
                MessageBox.Show("Please complete your information!");
            else
            {
                if (txt_Password.Text != txt_confirmPassword.Text)
                    MessageBox.Show("Password mismatch!");
                else
                {
                    string query = "insert into users (ID, FName, SName, AccountType, password) " + "values('" + txt_phone.Text + "','" + txt_Fname.Text + "','" + txt_Lname.Text + "','" + cb_accountType.Text + "','" + txt_Password.Text + "')";
                    Connection.OpenConection();
                    string response = Connection.Execute(query);
                    Connection.CloseConnection();
                    
                    if(response == "0")
                        MessageBox.Show("This phone is already registered!");
                    else
                    {
                        Login login = new Login();
                        login.Show();
                        Hide();
                    }



                }
            }
            
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
