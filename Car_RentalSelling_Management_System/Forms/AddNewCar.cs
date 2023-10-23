using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_RentalSelling_Management_System
{
    public partial class AddNewCar : Form
    {
        User user = null;
       public Dictionary<string, string[]> dic;
        public AddNewCar(User user)
        {
            this.user = user;
            dic = new Dictionary<string, string[]>();
            dic.Add("Acura", new string[] { "ILX", "NSX", "TL", "TLX", "RDX", "TSX", "MDX" });
            dic.Add("Alfa Romeo", new string[] { "Stelvio", "Giulia", "4C" });
            dic.Add("Alfa-romeo", new string[] { "Giulia", "Stelvio" });
            dic.Add("Aston Martin", new string[] { "V8 Vantage", "DB9", "V12 Vantage S" });
            dic.Add("Audi", new string[] { "Q7", "S6", "RS 3", "A4", "TTS", "RS 5", "E-Tron", "R8", "A8", "A3", "Q8", "RS 7", "TT", "SQ5", "A7", "S5", "S4", "A6", "A8 L", "allroad", "Q3", "Q5", "A5 Sportback", "A5", "TT RS" });
            dic.Add("BMW", new string[] { "X6 M", "M4", "5-Series", "X6", "X4", "M5", "4-Series", "4 Series Gran Coupe", "M-Series", "3-Series", "8-Series", "Z4", "1 Series", "4 Series", "7 Series", "M6 Gran Coupe", "2-Series", "i8", "6 Series Gran Coupe", "M6", "X3", "X5", "X5 M", "X5 eDrive", "I3", "X1", "3 Series", "5 Series", "6 Series", "I8", "7-Series", "X7", "2 Series", "i3", "3 Series Gran Turismo", "X2", "M3" });
            dic.Add("Bentley", new string[] { "Continental Supersports", "Continental GT Speed", "Flying Spur", "Continental GT", "Continental GTC", "Continental Flying Spur" });
            dic.Add("Buick", new string[] { "Enclave", "Verano", "Encore", "Regal Sportback", "LaCrosse", "Regal" });
            dic.Add("Cadillac", new string[] { "CTS", "CT6", "Escalade ESV", "XT5", "XT4", "XTS", "ATS", "Escalade", "SRX", "ATS Coupe", "CTS Coupe", "STS" });
            dic.Add("Chevrolet", new string[] { "HHR", "Equinox", "Colorado", "Suburban", "TrailBlazer", "Corvette Stingray", "Uplander", "Camaro", "Express Cargo", "Impala Limited", "Traverse", "Spark", "Blazer", "Bolt EV", "Malibu", "Aveo", "Volt", "Sonic", "Tahoe", "Silverado 2500HD", "Express", "Corvette", "Tahoe Hybrid", "Cruze", "Trax", "Malibu Limited", "Cruze Limited", "Impala", "Silverado 1500", "Silverado 1500 Hybrid" });
            dic.Add("Chrysler", new string[] { "300", "Sebring", "Pacifica", "Voyager", "200", "Town and Country" });
            dic.Add("Dodge", new string[] { "Grand Caravan", "Caliber", "Viper", "Caravan", "Dart", "Challenger", "Ram 1500", "Durango", "Avenger", "Charger", "Journey", "Ram 1500 Classic", "Ram 3500" });
            dic.Add("FIAT", new string[] { "500L", "500e", "124 Spider", "124 Convertible 2000", "500", "500X" });
            dic.Add("Ferrari", new string[] { "488GTB", "458 Spider", "488 Spider", "F430", "California", "488 Gtb", "348 Spider" });
            dic.Add("Ford", new string[] { "Transit Connect", "Fusion Hybrid", "C-Max", "Transit-350 Wagon EL", "EcoSport", "Shelby GT350", "Fusion Energi", "Shelby Cobra", "Edge", "Flex", "Freestyle", "Taurus", "Expedition", "Expedition MAX", "Explorer Sport Trac", "Transit-350 Wagon", "C-Max Hybrid", "Transit Van", "Escape", "Fiesta", "Focus", "mustang", "Ranger", "Shelby AC Cobra", "Explorer", "Mustang", "Fusion", "F-450 Super Duty", "Focus RS", "F-250 Super Duty", "Transit Wagon", "F-150" });
            dic.Add("GMC", new string[] { "Savana", "Sierra 3500HD", "Yukon XL", "Canyon", "Terrain", "Yukon", "Sierra 1500", "Acadia" });
            dic.Add("Genesis", new string[] { "G80" });
            dic.Add("HUMMER", new string[] { "H3", "H2" });
            dic.Add("Honda", new string[] { "Pilot", "Civic Hatch", "Crosstour", "Civic", "S2000", "Fit", "CR-V", "Accord Sedan", "Ridgeline", "Passport", "Element", "HR-V", "Insight", "Odyssey", "Civic Sedan", "Clarity", "Accord", "Accord Hybrid" });
            dic.Add("Hyundai", new string[] { "Accent", "Elantra Touring", "Elantra GT", "Sonata", "Santa Fe Sport", "Kona", "Azera", "Elantra", "Genesis G70", "Veloster", "Ioniq Plug-In Hybrid", "Tucson", "Genesis", "Palisade", "Santa Fe", "Ioniq Hybrid", "Equus" });
            dic.Add("INFINITI", new string[] { "QX60", "Q50", "QX80" });
            dic.Add("Infiniti", new string[] { "G37", "QX", "QX50", "Q60 Coupe", "G35", "JX", "G Sedan", "QX60", "QX80", "EX35", "Q50", "M35", "Q60" });
            dic.Add("Jaguar", new string[] { "XF", "F-Type", "F-TYPE", "XE", "XK-Series", "F-PACE", "XJ" });
            dic.Add("Jeep", new string[] { "Renegade", "Wrangler JK", "Compass", "Grand Cherokee SRT", "Commander", "Cherokee", "Grand Cherokee", "Wrangler", "Gladiator", "Liberty", "Patriot", "Wrangler Unlimited" });
            dic.Add("Kia", new string[] { "Forte", "Sedona", "Sportage", "Soul", "Cadenza", "Spectra", "Rio 5-Door", "Telluride", "Optima", "Rio", "Sorento", "Stinger", "Soul EV", "Optima Hybrid", "Niro" });
            dic.Add("Lamborghini", new string[] { "Gallardo", "Huracan", "Urus" });
            dic.Add("Land Rover", new string[] { "Range Rover Evoque", "Range Rover", "Discovery Sport", "Discovery", "Range Rover Sport", "Range Rover Velar", "LR2", "LR4" }); ;
            dic.Add("Lexus", new string[] { "LX", "ES 330", "IS 250", "IS", "GX 460", "NX 300", "RC", "IS 250 C", "IS 200t", "ES 300h", "HS 250h", "GS 450h", "RX 450h", "IS 350", "Ux", "NX", "CT 200h", "LX 570", "LC 500", "RX 400h", "GS 350", "GX", "RX 350L", "ES 350", "RX 350", "IS 350 C", "RX", "RC 200t", "IS 300", "GX 470", "NX 200t", "RC 350", "LS 460" });
            dic.Add("Lincoln", new string[] { "MKZ", "MKX", "MKC", "MKS", "Navigator L", "Continental", "Town Car", "Navigator" });
            dic.Add("Lotus", new string[] { "Evora", "Evora 400", "Exige" });
            dic.Add("MINI", new string[] { "Cooper Coupe", "Clubman", "Cooper Clubman", "Cooper Countryman", "Hardtop 2 Door", "Hardtop 2dr", "Cooper Roadster", "Convertible", "Cooper" });
            dic.Add("Mazda", new string[] { "MX-5 Miata", "CX-5", "Mazda6", "MX-5 Miata RF", "Mazda3", "5", "2", "3", "MAZDA5", "MAZDA2", "CX-7", "CX-9", "6" });
            dic.Add("McLaren", new string[] { "570S" });
            dic.Add("Mercedes-Benz", new string[] { "GL-Class", "Sprinter", "E-Class", "SLC-Class", "GLA-Class", "GLS-Class", "M-Class", "S-Class", "Metris", "CLS-Class", "GLC-Class", "SLK-Class", "AMG GT", "CL-Class", "GLE-Class Coupe", "GLE-Class", "G-Class", "CLA-Class", "SL-Class", "C-Class", "GLK-Class", "380sl" });
            dic.Add("Mercedes-benz", new string[] { "GLS-Class", "GLC-Class", "AMG GT", "CLA-Class", "C-Class", "CLS-Class", "E-Class", "GLE-Class", "G-Class", "Sprinter" });
            dic.Add("Mercury", new string[] { "Mariner" });
            dic.Add("Mitsubishi", new string[] { "Mirage", "Lancer", "Eclipse Cross", "Eclipse Spyder", "Mirage G4", "Outlander", "Outlander Sport" });
            dic.Add("Nissan", new string[] { "370Z", "NV200", "Altima", "Xterra", "Versa", "Titan XD", "Maxima", "Titan", "Leaf", "Pathfinder", "Quest", "Sentra", "Murano", "Frontier", "GT-R", "Cube", "Versa Note", "Rogue", "Rogue Sport", "Juke", "Armada" });
            dic.Add("Polaris", new string[] { "Slingshot" });
            dic.Add("Pontiac", new string[] { "G6", "Vibe", "Solstice" });
            dic.Add("Porsche", new string[] { "Boxster", "356 Speedster", "718 Boxster", "911", "Cayenne", "Cayman", "Macan", "Panamera", "356", "718 Cayman", "718" });
            dic.Add("Ram", new string[] { "1500", "2500", "Dakota", "3500", "Promaster Cargo Van", "CV Tradesman" });
            dic.Add("Rolls Royce", new string[] { "Silver Shadow", "Ghost" });
            dic.Add("Saab", new string[] { "44807" });
            dic.Add("Saturn", new string[] { "Sky", "ION" });
            dic.Add("Scion", new string[] { "xB", "FR-S", "tC", "xD", "iM" });
            dic.Add("Subaru", new string[] { "Crosstrek", "Ascent", "Forester", "Outback", "Legacy", "XV Crosstrek", "WRX", "Impreza" });
            dic.Add("Suzuki", new string[] { "XL7", "Kizashi" });
            dic.Add("Tesla", new string[] { "Model X", "Model 3", "Model Y", "Model S" });
            dic.Add("Toyota", new string[] { "Prius v", "Yaris iA", "FJ Cruiser", "Camry Hybrid", "Corolla Hatchback", "camry", "Corolla Hybrid", "Avalon Hybrid", "Supra", "Prius c", "Matrix", "Yaris", "Prius", "Tacoma", "Sienna", "Corolla", "Prius Prime", "Camry", "Land Cruiser", "Tundra", "Sequoia", "C-HR", "Highlander Hybrid", "RAV4 Hybrid", "4Runner", "Highlander", "Venza", "Corolla iM", "86", "RAV4", "Avalon", "Camry Solara" });
            dic.Add("Volkswagen", new string[] { "Tiguan", "Touareg", "GTI", "Golf", "Atlas", "Van", "New Beetle", "Golf GTI", "Routan", "Touareg 2", "Arteon", "Rabbit", "CC", "E-Golf", "Jetta", "Atlas Cross Sport", "Beetle", "Eos", "e-Golf", "Jetta Hybrid", "Passat" });
            dic.Add("Volvo", new string[] { "V60", "XC90", "S90", "XC60", "XC40", "S80", "S60", "S40" });
            dic.Add("smart", new string[] { "fortwo" });

            InitializeComponent();

        }


        private void AddNewCar_Load(object sender, EventArgs e)
        {
           

        }

        public void bt_submit_Click(object sender, EventArgs e)
        {
           
            if (db_BodyType.SelectedIndex == -1
               || db_CarModel.SelectedIndex == -1
               || db_FuleType.SelectedIndex == -1
               || db_year.SelectedIndex == -1
               || db_CarID.Text == ""
               || db_City.Text == ""
               || db_KM.Text == ""
               || db_Manufacturer.SelectedIndex == -1
               || db_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please complete your car data!!");
            }
            else
            {
                bool done = false;
                switch (db_status.SelectedIndex)
                {
                    case 0:
                        if (db_PricePerDay.Text != "")
                            done = true;
                        else
                            MessageBox.Show("Please fill the Price per day field");
                        break;
                    case 1:
                        if (db_Price.Text != "")
                            done = true;
                        else
                            MessageBox.Show("Please fill the Price field");
                        break;
                    case 2:
                        if (db_PricePerDay.Text != "" && db_Price.Text != "")
                            done = true;
                        else
                            MessageBox.Show("Please fill the Price and the price per day fields");
                        break;
                }
                if (done)
                {

                    Connection.OpenConection();
                    string query = String.Format("insert into[CarAgancy].[dbo].[car](ID, FuleType, Price, PricePerDay, City, KM, Year, Type, Manufacturer, CarModel, Status, UserID)values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')", db_CarID.Text, db_FuleType.Text, db_Price.Text, db_PricePerDay.Text, db_City.Text, db_KM.Text, db_year.Text, db_BodyType.Text, db_Manufacturer.Text, db_CarModel.Text, db_status.Text, user.phone);
                    string response = Connection.Execute(query);
                    Connection.CloseConnection();
                    if(response == "1")
                    {
                        MessageBox.Show("Your car added successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error occured!, Please try again");
                    }
                    
                }
            }
        }
         
        private void db_Manufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            db_CarModel.Items.Clear();
            foreach (string element in dic[db_Manufacturer.SelectedItem.ToString()])
                db_CarModel.Items.Add(element);
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            OwnerHome oh = new OwnerHome(user);
            oh.Show();
            Hide();
        }
        private void db_CarModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        private void db_FuleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
