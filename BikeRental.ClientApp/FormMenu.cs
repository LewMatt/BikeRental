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
    public partial class FormMenu : Form
    {
        public int UserID;
        BikeRentalService.BikeRentalServiceClient client = new BikeRentalService.BikeRentalServiceClient();
        public FormMenu()
        {
            InitializeComponent();

            List<ListViewItem> catalog = new List<ListViewItem>();

            List<Bikes> bikesList = new List<Bikes>();

            bikesList = client.GetAllBikes();

            foreach(Bikes x in bikesList)
            {
                ListViewItem item = new ListViewItem();
                item.Text = x.BikeID.ToString();
                item.SubItems.Add(x.Brand);
                item.SubItems.Add(x.Model);
                item.SubItems.Add(x.Type);
                item.SubItems.Add(x.Color);
                item.SubItems.Add(x.Price.ToString());
                item.SubItems.Add(x.IsAvailable.ToString());
                catalog.Add(item);
            }

            userControlCatalog1.listViewCatalog.Items.Clear();

            foreach(ListViewItem item in catalog)
            {
                userControlCatalog1.listViewCatalog.Items.Add(item);
            }

            userControlCatalog1.userID = UserID;

            userControlCatalog1.BringToFront();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Restart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonBikeCatalog_Click(object sender, EventArgs e)
        {
            List<ListViewItem> catalog = new List<ListViewItem>();

            List<Bikes> bikesList = new List<Bikes>();

            bikesList = client.GetAllBikes();

            foreach (Bikes x in bikesList)
            {
                ListViewItem item = new ListViewItem();
                item.Text = x.BikeID.ToString();
                item.SubItems.Add(x.Brand);
                item.SubItems.Add(x.Model);
                item.SubItems.Add(x.Type);
                item.SubItems.Add(x.Color);
                item.SubItems.Add(x.Price.ToString());
                item.SubItems.Add(x.IsAvailable.ToString());
                catalog.Add(item);
            }

            userControlCatalog1.listViewCatalog.Items.Clear();

            foreach (ListViewItem item in catalog)
            {
                userControlCatalog1.listViewCatalog.Items.Add(item);
            }

            userControlCatalog1.userID = UserID;

            userControlCatalog1.BringToFront();
        }

        private void buttonBorrowedBikes_Click(object sender, EventArgs e)
        {
            List<ListViewItem> borrowedList = new List<ListViewItem>();

            List<Rents> rentsList = new List<Rents>();

            rentsList = client.GetRentsByUser(UserID);

            foreach(Rents x in rentsList)
            {
                ListViewItem item = new ListViewItem();
                item.Text = x.BikeID.ToString();
                item.SubItems.Add(x.Price.ToString());
                item.SubItems.Add(x.ExpirationDate.ToString());
                borrowedList.Add(item);
            }

            userControlBorrowed1.listView1.Items.Clear();

            foreach (ListViewItem item in borrowedList)
            {
                userControlBorrowed1.listView1.Items.Add(item);
            }



            userControlBorrowed1.BringToFront();
        }
    }
}
