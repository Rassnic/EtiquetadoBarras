using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZOTE.CLASES
{
    class ClassAltura
    {
        private ClassConexionIZOTEBD conIZOTE = new ClassConexionIZOTEBD();
        private SqlCommand command = new SqlCommand();

        public DataTable getAltura(ref string error)
        {
            try
            {
                conIZOTE.connection.Open();
                DataTable returnTable = new DataTable("data");
                command.Connection = conIZOTE.connection;
                command.CommandText = "SELECT id_altura as id, descripcion FROM tbl_altura";
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
