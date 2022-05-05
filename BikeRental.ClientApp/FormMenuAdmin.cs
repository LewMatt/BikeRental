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
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Restart();
        }
    }
}
