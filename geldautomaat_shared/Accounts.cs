using System;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace geldautomaat_shared
{
    public class Accounts
    {
        private DbConnection DBConnection = DbConnection.Instance();
        private Functions Functions = new Functions();
        public Accounts() { }

        /*
        *  Updates the user with the given id
        */
        public int Update(int Id, int AccountNumber, string FirstName, string LastName, bool IsBlocked)
        {
            int RowsEffected = 0;
            if (DBConnection.IsConnect())
            {
                MySqlCommand Command = new MySqlCommand("", this.DBConnection.Connection);
                Command.CommandText = "UPDATE `account` SET `account_number` = @account_number, `first_name` = @first_name, `last_name` = @last_name, `is_blocked` = @is_blocked WHERE `id` = @id";
                Command.Parameters.AddWithValue("@account_number", AccountNumber);
                Command.Parameters.AddWithValue("@first_name", FirstName);
                Command.Parameters.AddWithValue("@last_name", LastName);
                Command.Parameters.AddWithValue("@is_blocked", IsBlocked);
                Command.Parameters.AddWithValue("@id", Id);
                RowsEffected = Command.ExecuteNonQuery();

            }
            return RowsEffected;
        }

        /*
         *  Creates a new user with the given data
        */
        public int Create(int AccountNumber, int Password, string FirstName, string LastName, bool IsBlocked)
        {
            int RowsEffected = 0;
            if (DBConnection.IsConnect())
            {
                MySqlCommand Command = new MySqlCommand("", this.DBConnection.Connection);
                string HashedPassword = this.Functions.MakeHash(Password.ToString());
                Command.CommandText = "INSERT INTO `account` (`password`, `account_number`, `first_name`, `last_name`, `is_blocked`) VALUES(@password,@account_number,@first_name,@last_name,@is_blocked)";
                Command.Parameters.AddWithValue("@password", HashedPassword);
                Command.Parameters.AddWithValue("@account_number", AccountNumber);
                Command.Parameters.AddWithValue("@first_name", FirstName);
                Command.Parameters.AddWithValue("@last_name", LastName);
                Command.Parameters.AddWithValue("@is_blocked", IsBlocked);
                RowsEffected = Command.ExecuteNonQuery();
            }
            return RowsEffected;
        }

        public MySqlDataAdapter getAll()
        {
            return this.DBConnection.IsConnect() ? new MySqlDataAdapter("select * from `account`", this.DBConnection.Connection) : null;

        }

        public int Delete(int Id)
        {
            int RowsEffected = 0;
            if (this.DBConnection.IsConnect())
            {
                MySqlCommand Command = new MySqlCommand("DELETE FROM `account` where `id` = @id", this.DBConnection.Connection);
                Command.Parameters.AddWithValue("@id", Id);
                RowsEffected = Command.ExecuteNonQuery();
            }
            return RowsEffected;
        }
    }
}
