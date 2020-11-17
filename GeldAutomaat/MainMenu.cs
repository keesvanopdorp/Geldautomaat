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
    public partial class MainMenu : Form
    {
        Account Account;
        public MainMenu(int AccountNumber)
        {
            InitializeComponent();
            this.Account = new Account(AccountNumber);
            this.LblShowBalance.Text = string.Format("huidige saldo: € {0}", Account.Balance);
            this.LblShowFullName.Text = string.Format("Welkom {0} {1}", Account.FirstName, Account.LastName);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Login = new Login();
            Login.ShowDialog();
            this.Close();
        }

        private void BtnWithdrawCash_Click(object sender, EventArgs e)
        {
            this.Hide();
            WidthdrawCash WidthdrawCash = new WidthdrawCash(this.Account.AccountNumber);
            WidthdrawCash.ShowDialog();
            this.Close();
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepositCash DepositCash = new DepositCash(this.Account.AccountNumber);
            DepositCash.ShowDialog();

        }

        private void BtnLatestTransactions_Click(object sender, EventArgs e)
        {
            this.Hide();
            LastTransaction LastTransaction = new LastTransaction(this.Account.AccountNumber);
            LastTransaction.ShowDialog();
            this.Close();
        }
    }
}
