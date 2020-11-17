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
    public partial class WidthdrawCash : Form
    {
        Account Account;
        public WidthdrawCash(int AccountNumber)
        {
            InitializeComponent();
            this.Account = new Account(AccountNumber);
            this.UpdateDisplayBalance();

        }

        private void BtnWithdraw50_Click(object sender, EventArgs e)
        {
            double Amount = -50.00d;
            double newBalance = this.Account.Balance - Amount;
            if (newBalance < 0)
            {
                LblErrorMessage.Text = "Sorry je kan niet in het rood staan.";
            }
            else
            {
                bool WithdrawResult = this.Account.Withdraw(Amount);
                if (WithdrawResult == false)
                {
                    LblErrorMessage.Text = "U heeft het limiet van u tranacaties bereik u kunt morgen pas weer geld opnemen";
                }
                else
                {
                    LblErrorMessage.Text = string.Format("Er is successvol € {0} van u rekening gehaald", Amount);
                    this.Account.getBalance();
                }
            }

        }

        private void UpdateDisplayBalance()
        {
            this.Account.getBalance();
            this.LblShowBalance.Text = string.Format("huidige saldo: € {0}", this.Account.Balance);
        }

        private void BtnWithdraw20_Click(object sender, EventArgs e)
        {
            double Amount = -20.00d;
            double newBalance = this.Account.Balance - Amount;
            if (newBalance < 0)
            {
                LblErrorMessage.Text = "Sorry je kan niet in het rood staan.";
            }
            else
            {
                bool WithdrawResult = this.Account.Withdraw(Amount);
                if (WithdrawResult == false)
                {
                    LblErrorMessage.Text = "U heeft het limiet van u tranacaties bereik u kunt morgen pas weer geld opnemen";
                }
                else
                {
                    LblErrorMessage.Text = string.Format("Er is successvol € {0} van u rekening gehaald", Amount);
                    this.Account.getBalance();
                }
            }
        }

        private void BtnWithdraw10_Click(object sender, EventArgs e)
        {
            double Amount = -10.00d;
            double newBalance = this.Account.Balance - Amount;
            if (newBalance < 0)
            {
                LblErrorMessage.Text = "Sorry je kan niet in het rood staan.";
            }
            else
            {
                bool WithdrawResult = this.Account.Withdraw(Amount);
                if (WithdrawResult == false)
                {
                    LblErrorMessage.Text = "U heeft het limiet van u tranacaties bereik u kunt morgen pas weer geld opnemen";
                }
                else
                {
                    LblErrorMessage.Text = string.Format("Er is successvol € {0} van u rekening gehaald", Amount);
                    this.Account.getBalance();
                }
            }
        }

        private void BtnWithdraw100_Click(object sender, EventArgs e)
        {
            double Amount = -100.00d;
            double newBalance = this.Account.Balance - Amount;
            if (newBalance < 0)
            {
                LblErrorMessage.Text = "Sorry je kan niet in het rood staan.";
            }
            else
            {
                bool WithdrawResult = this.Account.Withdraw(Amount);
                if (WithdrawResult == false)
                {
                    LblErrorMessage.Text = "U heeft het limiet van u tranacaties bereik u kunt morgen pas weer geld opnemen";
                }
                else
                {
                    LblErrorMessage.Text = string.Format("Er is successvol € {0} van u rekening gehaald", Amount);
                    this.Account.getBalance();
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MainMenu = new MainMenu(this.Account.AccountNumber);
            MainMenu.ShowDialog();
            this.Close();
        }
    }
}
