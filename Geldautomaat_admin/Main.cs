using System;
using System.Data;
using System.Windows.Forms;
using geldautomaat_shared;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Geldautomaat_admin
{
    public partial class Main : Form
    {
        Accounts Accounts = new Accounts();
        DataTable DataTable;
        int AccountId = 0;
        public Main()
        {
            InitializeComponent();
            this.getAccountData();
            DgvAccounts.AutoResizeColumns();
            DgvAccounts.ReadOnly = true;
            NumAccountNumber.Maximum = decimal.MaxValue;
            NumPassword.Maximum = 9999M;
            BtnDeleteUser.Enabled = false;
        }

        private void DgvAccounts_DoubleClick(object sender, EventArgs e)
        {
            if (DgvAccounts.CurrentRow.Index != -1)
            {
                this.AccountId = (int)DgvAccounts.CurrentRow.Cells[0].Value;
                int AccountNumber = (int)DgvAccounts.CurrentRow.Cells[1].Value;
                string FirstName = (string)DgvAccounts.CurrentRow.Cells[3].Value;
                string LastName = (string)DgvAccounts.CurrentRow.Cells[4].Value;
                bool Blocked = (bool)DgvAccounts.CurrentRow.Cells[5].Value;
                this.NumAccountNumber.Value = AccountNumber;
                this.TxtFirstName.Text = FirstName;
                this.TxtLastName.Text = LastName;
                this.ChbBlocked.Checked = Blocked;
                BtnDeleteUser.Enabled = true;
                BtnSubmit.Text = "Bijwerken";
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (this.AccountId == 0)
            {
                Accounts.Create((int)this.NumAccountNumber.Value, (int)NumPassword.Value, this.TxtFirstName.Text, this.TxtLastName.Text, (bool)this.ChbBlocked.Checked);
            }
            else
            {
                Accounts.Update(this.AccountId, (int)this.NumAccountNumber.Value, this.TxtFirstName.Text, this.TxtLastName.Text, (bool)this.ChbBlocked.Checked);
            }
            this.getAccountData();
        }

        private void getAccountData()
        {
            this.DataTable = new DataTable();
            MySqlDataAdapter Data = this.Accounts.getAll();
            Data.Fill(this.DataTable);
            DgvAccounts.DataSource = this.DataTable;
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Weet je zeker dat je deze gebruiker wilt verwijderen?", "Weet je het zeker?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Accounts.Delete(this.AccountId);
                this.getAccountData();
            }
        }

        private void BtnClearFlieds_Click(object sender, EventArgs e)
        {
            this.TxtFirstName.Clear();
            this.TxtLastName.Clear();
            this.NumAccountNumber.Value = 0;
            this.NumPassword.Value = 0;
            this.AccountId = 0;
            this.BtnSubmit.Text = "Maak aan";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DataView Dv;
            if (this.TxtSearchAccountNumber.Text.Trim() != string.Empty && this.TxtSearchAccountNumber.Text.Trim() != string.Empty)
            {
                Dv = new DataView(this.DataTable, String.Format("last_name = '{0}' AND account_number='{1}'", this.TxtSearchLastName.Text.Trim(), this.TxtSearchAccountNumber.Text.Trim()), "last_name Desc", DataViewRowState.CurrentRows);
            }
            if (this.TxtSearchAccountNumber.Text.Trim() == string.Empty && this.TxtSearchAccountNumber.Text.Trim() != string.Empty)
            {
                Dv = new DataView(this.DataTable, String.Format("account_number='{0}'", this.TxtSearchAccountNumber.Text.Trim()), "last_name Desc", DataViewRowState.CurrentRows);
            }
            else
            {
                Dv = new DataView(this.DataTable, String.Format("last_name = '{0}'", this.TxtSearchLastName.Text.Trim()), "last_name Desc", DataViewRowState.CurrentRows);
            }
            DgvAccounts.DataSource = Dv;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.getAccountData();
        }
    }
}
