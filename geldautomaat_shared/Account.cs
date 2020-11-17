using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace geldautomaat_shared
{
    public class Account
    {
        public int Id;
        public int AccountNumber;
        public string Password;
        public string FirstName;
        public string LastName;
        public double Balance;
        public int WithdrawCount;
        public List<Transaction> Transactions = new List<Transaction> { };
        private DbConnection DbConnection = DbConnection.Instance();
        private Functions Functions = new Functions();
        public bool IsBlocked;


        public Account(int AccountNumber)
        {
            if (this.DbConnection.IsConnect())
            {
                MySqlCommand Command = new MySqlCommand("", this.DbConnection.Connection);
                Command.CommandText = "SELECT * FROM `account` where `account_number` = @account_number";
                Command.Parameters.AddWithValue("@account_number", AccountNumber);
                MySqlDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    this.Id = Reader.GetInt32(0);
                    this.AccountNumber = AccountNumber;
                    this.Password = Reader.GetString(2);
                    this.FirstName = Reader.GetString(3);
                    this.LastName = Reader.GetString(4);
                    this.IsBlocked = Reader.GetBoolean(5);
                }
                DbConnection.Close();
            }
            this.getBalance();
            if (this.DbConnection.IsConnect())
            {
                MySqlCommand Command = new MySqlCommand("", this.DbConnection.Connection);
                Command.CommandText = "SELECT * from `account_transaction` WHERE `user_id` = @id ORDER by date desc limit 3";
                Command.Parameters.AddWithValue("@id", this.Id);
                MySqlDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    DateTime DateTime = Reader.GetDateTime(3);
                    double Amount = Reader.GetDouble(2);
                    Transaction Transaction = new Transaction(Amount, DateTime, this.Id);
                    this.Transactions.Add(Transaction);
                }
                DbConnection.Close();
            }
            this.getWithdrawCount();
            Console.WriteLine(string.Format("withdraw count is {0}", this.WithdrawCount));
        }

        public void getWithdrawCount()
        {
            if (this.DbConnection.IsConnect())
            {
                MySqlCommand Command = new MySqlCommand("", this.DbConnection.Connection);
                Command.CommandText = "SELECT count(`id`) from `account_transaction` WHERE `user_id` = @id AND `date` LIKE @date AND `amount` LIKE '-%'";
                Command.Parameters.AddWithValue("@id", this.Id);
                Command.Parameters.AddWithValue("@date", string.Format("{0} %", DateTime.Now.ToString("yyyy/M/d")));
                MySqlDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    this.WithdrawCount = Reader.GetInt32(0);
                }
                DbConnection.Close();
            }
        }

        public MySqlDataAdapter getAllTransaction()
        {
            MySqlDataAdapter Adapter = new MySqlDataAdapter("", this.DbConnection.Connection);
            if (this.DbConnection.IsConnect())
            {
                Adapter = new MySqlDataAdapter("SELECT `amount`, `date` from `account_transaction` WHERE `user_id` = @user_id  ORDER BY `date` DESC LIMIT 3", this.DbConnection.Connection);
                Adapter.SelectCommand.Parameters.AddWithValue("@user_id", this.Id);
            }
            return Adapter;
        }

        public void getBalance()
        {
            if (this.DbConnection.IsConnect())
            {
                MySqlCommand Command = new MySqlCommand("", this.DbConnection.Connection);
                Command.CommandText = "SELECT SUM(`amount`) from `account_transaction` WHERE `user_id` = @id";
                Command.Parameters.AddWithValue("@id", this.Id);
                MySqlDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    try
                    {
                        this.Balance = Reader.GetDouble(0);
                    }
                    catch (Exception e)
                    {
                        this.Balance = 0;
                    }
                }
                DbConnection.Close();
            }
        }

        public void Deposit(double Amount)
        {
            Transaction Transaction = new Transaction(Amount, DateTime.Now, this.Id);
            Transaction.Save();
            this.getWithdrawCount();
        }


        public bool Withdraw(double Amount)
        {
            bool ReturnValue = false;
            this.getWithdrawCount();
            Console.WriteLine(this.WithdrawCount);
            if (this.WithdrawCount >= 3)
            {
                return false;
            }
            else
            {
                Transaction Transaction = new Transaction(Amount, DateTime.Now, this.Id);
                Transaction.Save();
                this.getWithdrawCount();
                ReturnValue = true;
            }
            return ReturnValue;
        }

        /*
         * logs the user in to the application
         */
        public int Login(string Password)
        {
            if (this.FirstName == null)
            {
                return 0;
            }
            if (this.IsBlocked == true)
            {
                return 1;
            }
            if (this.Password != this.Functions.MakeHash(Password))
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
    }
}
