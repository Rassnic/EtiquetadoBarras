using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace IZOTE.CLASES
{
    class ClassRecolector
    {
        private ClassConexionIZOTEBD conIZOTE = new ClassConexionIZOTEBD();
        private SqlCommand command = new SqlCommand();

        public DataTable getRecolector(ref string error)
        {
            try
            {
                conIZOTE.connection.Open();
                DataTable returnTable = new DataTable("data");
                command.Connection = conIZOTE.connection;
                command.CommandText = "SELECT id_recolector as id, descripcion FROM tbl_recolector";
                returnTable.Load(command.ExecuteReader());
                return returnTable;
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                return null;
            }
        }
    }
}
