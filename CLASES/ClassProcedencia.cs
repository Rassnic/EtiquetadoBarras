using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZOTE.CLASES
{
    class ClassProcedencia
    {
        private ClassConexionIZOTEBD conIZOTE = new ClassConexionIZOTEBD();
        private SqlCommand command = new SqlCommand();

        //public DataTable getProcedencia(ref string error)
        //{
        //    try
        //    {
        //        conIZOTE.connection.Open();
        //        DataTable returnTable = new DataTable("dataP");
        //        command.Connection = conIZOTE.connection;
        //        command.CommandText = "SELECT Codigo AS id, municipio FROM tbl_procedencia order by municipio";
        //        returnTable.Load(command.ExecuteReader());
        //        return returnTable;
        //    }
        //    catch (Exception ex)
        //    {
        //        error = ex.ToString();
        //        return null;
        //    }
        //}

        public DataTable obtenerProcedencia(ref string error, string codigo_procedencia)
        {
            try
            {
                DataTable returnTable = new DataTable("datosProc");
                conIZOTE.connection.Open();
                command.Connection = conIZOTE.connection;
                command.Parameters.Clear();
                command.CommandText = "SELECT " +
                    "id_procedencia, " +
                    "Codigo, " +
                    "municipio " +
                    "FROM tbl_procedencia " +
                    "WHERE " + 
                    "CAST(Codigo AS int) like CAST( "+ codigo_procedencia +"AS int)";
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

