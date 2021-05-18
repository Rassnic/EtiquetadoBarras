using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZOTE.CLASES
{
    class ClassTipo
    {
        private ClassConexionIZOTEBD conIZOTE = new ClassConexionIZOTEBD();
        private SqlCommand command = new SqlCommand();

        public DataTable getVariedad(ref string error)
        {
            try
            {
                conIZOTE.connection.Open();
                DataTable returnTable = new DataTable("data");
                command.Connection = conIZOTE.connection;
                command.CommandText = "SELECT id_variedad as id, descripcion FROM tbl_variedad";
                returnTable.Load(command.ExecuteReader());
                return returnTable;
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                return null;
            }
        }

        public string codigoVariedad(ref string error, string id_variedad)
        {
            try
            {
                //conIZOTE.connection.Open();
                command.Connection = conIZOTE.connection;
                command.CommandText = $"SELECT codigo FROM tbl_variedad WHERE id_variedad = {id_variedad}";
                return command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                return "";
            }
            finally
            {
                //conIZOTE.connection.Close();
            }
        }

    }
}
