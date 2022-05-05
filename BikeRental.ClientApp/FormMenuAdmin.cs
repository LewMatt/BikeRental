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
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
            userControlCatalogAdmin1.BringToFront();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Restart();
        }

        private void buttonCatalogAdmin_Click(object sender, EventArgs e)
        {
            userControlCatalogAdmin1.BringToFront();
        }

        private void buttonBorrowedBikesAdmin_Click(object sender, EventArgs e)
        {
            userControlBorrowedAdmin1.BringToFront();
        }

        private void buttonFixes_Click(object sender, EventArgs e)
        {
            userControlFixesAdmin1.BringToFront();
        }
    }
}
