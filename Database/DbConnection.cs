using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OfficePulse
{
    public  class DbConnection
    {
        private readonly string connectionString;

        public DbConnection()
        {
            connectionString = "Server=localhost;Database=officepulse;User=root;Password=;";
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        

        

        



    }
}
