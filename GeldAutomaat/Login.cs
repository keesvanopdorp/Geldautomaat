using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using geldautomaat_shared;

namespace GeldAutomaat
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Account Account = new Account(int.Parse(TxtAccountNumber.Text.Trim()));
            int LoginResult = Account.Login(this.TxtPassword.Text.Trim());
            Console.WriteLine(LoginResult);
            switch (LoginResult)
            {
                case 0:
                    LblErrorMessage.Text = "Account bestaat niet, Neem alstublieft contact met ons op om een rekening te openen.";
                    break;
                case 1:
                    LblErrorMessage.Text = "U account is momenteel geblokeerd. Neem alstublieft contact met ons op.";
                    break;
                case 2:
                    LblErrorMessage.Text = "U pincode is verkeerd, probeer het opnieuw.";
                    break;
                case 3:
                    MainMenu MainMenu = new MainMenu(Account.AccountNumber);
                    this.Hide();
                    MainMenu.ShowDialog();
                    this.Close();
                    break;
            }
        }
    }
}
