using System;
namespace solid.d.after
{
    public interface DBConnectionInterface
    {
        public string connect();
    }

    public class MySQLConnection: DBConnectionInterface
    {
        public string connect()
        {
            // handle the database connection
            return "Database connection";
        }
    }
    /// <summary>
    /// PasswordReminder depends now on abstraction -> DbConnectionInterface and not in Concretion -> MySQLConnection
    /// </summary>
    public class PasswordReminder
    {
        private DBConnectionInterface dbConnection;

        public PasswordReminder(DBConnectionInterface dbConnection)
        {
            this.dbConnection = dbConnection;
        }
    }
}
