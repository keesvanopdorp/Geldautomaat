using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace geldautomaat_shared
{
    public class Transaction
    {
        public double Amount;
        public DateTime Date;
        public int UserId;
        private DbConnection DbConnection = DbConnection.Instance();
        public Transaction(double Amount, DateTime Date, int UserId)
        {
            this.Amount = Amount;
            this.Date = Date;
            this.UserId = UserId;
        }

        public void Save()
        {
            if (this.DbConnection.IsConnect())
            {
                MySqlCommand Command = new MySqlCommand("", this.DbConnection.Connection);
                Command.CommandText = "INSERT INTO `account_transaction`(`user_id`, `amount`, `date`) VALUES(@user_id, @amount, @date)";
                Command.Parameters.AddWithValue("@user_id", this.UserId);
                Command.Parameters.AddWithValue("@amount", Amount);
                Command.Parameters.AddWithValue("@date", this.Date);
                Command.ExecuteNonQuery();
            }
        }
    }
}
