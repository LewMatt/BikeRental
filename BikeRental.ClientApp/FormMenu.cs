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
        public FormMenu()
        {
            InitializeComponent();
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
            userControlCatalog1.BringToFront();
        }

        private void buttonBorrowedBikes_Click(object sender, EventArgs e)
        {
            userControlBorrowed1.BringToFront();
        }
    }
}
