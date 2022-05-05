using BikeRental.ClientApp.BikeRentalService;
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
    public partial class UserControlBorrowed : UserControl
    {
        public int userID;

        public UserControlBorrowed()
        {
            InitializeComponent();
        }

        private void buttonOddaj_Click(object sender, EventArgs e)
        {
            BikeRentalService.BikeRentalServiceClient client = new BikeRentalService.BikeRentalServiceClient();

            int bikeID = int.Parse(listView1.SelectedItems[0].Text);

            client.ReturnBike(bikeID);

            List<ListViewItem> borrowedList = new List<ListViewItem>();

            List<Rents> rentsList = new List<Rents>();

            rentsList = client.GetRentsByUser(userID);

            foreach (Rents x in rentsList)
            {
                ListViewItem item = new ListViewItem();
                item.Text = x.BikeID.ToString();
                item.SubItems.Add(x.Price.ToString());
                item.SubItems.Add(x.ExpirationDate.ToString());
                borrowedList.Add(item);
            }

            listView1.Items.Clear();

            foreach (ListViewItem item in borrowedList)
            {
                listView1.Items.Add(item);
            }


            MessageBox.Show("Oddano rower.");
        }
    }
}
