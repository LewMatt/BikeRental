using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRental.ClientApp
{
    public partial class UserControlCatalog : UserControl
    {
        public int userID;

        public UserControlCatalog()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void buttonRent_Click(object sender, EventArgs e)
        {
            BikeRentalService.BikeRentalServiceClient client = new BikeRentalService.BikeRentalServiceClient();

            int bikeID = int.Parse(listViewCatalog.SelectedItems[0].Text);

            string rent = client.AddRent(userID, bikeID);

            if(rent == "Wypozyczono rower.")
            {
                MessageBox.Show("Wypozyczono rower.");
            }
            else
            {
                MessageBox.Show("Rower został już wypożyczony.");
            }
        }
    }
}
