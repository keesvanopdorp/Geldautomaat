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
    public partial class LastTransaction : Form
    {
        Account Account;
        public LastTransaction(int AccountNumber)
        {
            InitializeComponent();
            this.Account = new Account(AccountNumber);
            DataTable DataTable = new DataTable();
            MySql.Data.MySqlClient.MySqlDataAdapter Data = this.Account.getAllTransaction();
            Data.Fill(DataTable);
            DgvTransactions.DataSource = DataTable;
            DgvTransactions.ReadOnly = true;
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
