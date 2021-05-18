using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZOTE.CLASES
{
    class ClassEtiquetas
    {
        private ClassConexionIZOTEBD conIZOTE = new ClassConexionIZOTEBD();
        private SqlCommand command = new SqlCommand();

        public DataTable etiquetasIzote(ref string error, int numero_inicial, int numero_final, int yearWeek, int recolector)
        {
            try
            {
                DataTable returnTable = new DataTable("data");
                conIZOTE.connection.Open();
                command.Connection = conIZOTE.connection;
                command.CommandText = $"exec sp_etiquetas_izote {numero_inicial}, {numero_final}, {yearWeek}, {recolector}";
                returnTable.Load(command.ExecuteReader());
                return returnTable;
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                return null;
            }
            finally
            {
                conIZOTE.connection.Close();
            }
        }

    }
}
