using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZOTE.CLASES
{
    class ClassBrote
    {
        private ClassConexionIZOTEBD conIZOTE = new ClassConexionIZOTEBD();
        private SqlCommand command = new SqlCommand();

        public DataTable getBrote(ref string error)
        {
            try
            {
                conIZOTE.connection.Open();
                DataTable returnTable = new DataTable("data");
                command.Connection = conIZOTE.connection;
                command.CommandText = "SELECT id_brotacion as id, descripcion FROM tbl_tipo_brotacion";
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
