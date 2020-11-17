using geldautomaat_shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeldAutomaat
{
    public partial class DepositCash : Form
    {
        Account Account;
        public DepositCash(int AccountNumber)
        {
            InitializeComponent();
            this.Account = new Account(AccountNumber);
            Console.WriteLine(this.Account.Id);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MainMenu = new MainMenu(this.Account.AccountNumber);
            MainMenu.ShowDialog();
            this.Close();
        }

        private void BtnDepositCash_Click(object sender, EventArgs e)
        {
            if (this.NumDepositCash.Value != 0.00M)
            {
                this.Account.Deposit((double)this.NumDepositCash.Value);
                MessageBox.Show("Het geld is op rekening gestort");
            }
            else
            {
                MessageBox.Show("Moet minimaal 0,01 euro storten");
            }
        }
    }
}
