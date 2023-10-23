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
    public partial class OwnerHome : Form
    {
        User user = null;
        public OwnerHome(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt_AddCar_Click(object sender, EventArgs e)
        {
            AddNewCar addcar = new AddNewCar(user);
            addcar.Show();
            Hide();
        }

        private void OwnerHome_Load(object sender, EventArgs e)
        {
            txt_OwnerName.Text = user.fname + user.sname;
            txt_OwnerPhone.Text = user.phone;
            Connection.OpenConection();
            List<Operation> operations = Connection.SelectOperations(user.phone);
            Connection.CloseConnection();
            foreach(Operation op in operations)
            {
                ListViewItem lv = new ListViewItem(new string[] { op.CarModel, op.Type, op.Cost, op.OpName });
                lv_recent.Items.Add(lv);
            }
            
        }
    }
}
