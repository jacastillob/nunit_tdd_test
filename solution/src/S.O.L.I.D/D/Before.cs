using System;
namespace solid.d.before
{
    public class MySQLConnection
    {
        public string connect()
        {
            // handle the database connection
            return "Database connection";
        }
    }
    public class PasswordReminder
    {
        private MySQLConnection dbConnection;

        public PasswordReminder(MySQLConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }
    }
}
