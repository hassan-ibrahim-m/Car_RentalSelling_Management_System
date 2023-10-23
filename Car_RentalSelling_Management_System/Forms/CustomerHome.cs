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
    public partial class CustomerHome : Form
    {
        User user = null;
        public CustomerHome(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void CustomerHome_Load(object sender, EventArgs e)
        {
            lb_name.Text = (user.fname +" "+ user.sname).ToString();
            lb_phone.Text = user.phone;
            Connection.OpenConection();
            List<Operation> operations = Connection.SelectOperations(user.phone);
            Connection.CloseConnection();
            foreach (Operation op in operations)
            {
                ListViewItem lv = new ListViewItem(new string[] { op.CarModel, op.Type, op.Cost, op.OpName });
                lv_recent.Items.Add(lv);
            }
        }

        private void lv_recent_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lv_recent.Columns[e.ColumnIndex].Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form buy = new CustomerBuyOld(user);
            buy.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form rent = new Customer_Rent(user);
            rent.Show();
            Hide();
        }

        private void lb_name_Click(object sender, EventArgs e)
        {

        }
    }
}
