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
    public partial class FormLogin : Form
    {
        BikeRentalService.BikeRentalServiceClient client = new BikeRentalService.BikeRentalServiceClient();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Restart();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string login = client.Login(textBoxLogin.Text, textBoxPassword.Text);
            string userType = client.GetUserTypeByLogin(login);

            if (login == "" || userType == "")
            {
                MessageBox.Show("Niepoprawny login lub hasło.");
            }
            else if(userType == "user")
            {
                MessageBox.Show("Zalogowano.");
                this.Hide();
                FormMenu fMenu = new FormMenu();
                fMenu.UserID = client.GetUserID(login);
                fMenu.Show();
            }
            else
            {
                MessageBox.Show("Zalogowano do panelu administratora.");
                this.Hide();
                FormMenuAdmin fMenuAdmin = new FormMenuAdmin();
                fMenuAdmin.Show();
            }
        }
    }
}
