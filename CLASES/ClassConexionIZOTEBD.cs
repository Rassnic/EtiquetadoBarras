using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZOTE.CLASES
{
    class ClassConexionIZOTEBD
    {
       
        public SqlConnection connection = new SqlConnection();

        private void connect()
        {
            connection = new SqlConnection(connectionString);
        }

        public ClassConexionIZOTEBD()
        {
            connect();
        }

        public SqlConnection getCon()
        {
            return connection;
        }
    }
}
