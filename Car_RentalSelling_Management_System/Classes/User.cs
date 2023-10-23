using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_RentalSelling_Management_System
{
    public class User
    {
        public string fname { get; set; }
        public string sname { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public string accountType { get; set; }

        public User()
        {

        }

        public User(string phone, string password, string fname, string sname, string accountType)
        {
            this.password = password;
            this.fname = fname;
            this.sname = sname;
            this.phone = phone;
            this.accountType = accountType;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public void forgetPassword()
        {
            // do something
        }
    }
}
