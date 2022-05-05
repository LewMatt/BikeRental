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
    public partial class FormRegister : Form
    {
        BikeRentalService.BikeRentalServiceClient client = new BikeRentalService.BikeRentalServiceClient();
        public FormRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = client.AddUser(textBoxLogin.Text, textBoxPassword.Text, textBoxName.Text, textBoxSurname.Text, textBoxPhone.Text, textBoxAddress.Text);

            if(user == "")
            {
                MessageBox.Show("Uzytkownik o takim loginie juz istnieje.");
            }
            else
            {
                MessageBox.Show("Zarejestrowano.");

                System.Windows.Forms.Application.Restart();
            }
            
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Restart();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
