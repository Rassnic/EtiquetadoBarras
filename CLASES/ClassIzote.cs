using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZOTE.CLASES
{
    class ClassIzote
    {
        private ClassConexionIZOTEBD conIZOTE = new ClassConexionIZOTEBD();
        private SqlCommand command = new SqlCommand();
        internal object connection;

        public string getYearNumberWeek(ref string error)
        {
            try
            {
                conIZOTE.connection.Open();
                command.Connection = conIZOTE.connection;
                command.CommandText = "SELECT (CASE WHEN LEN(CAST(DATEPART(ISO_WEEK, GETDATE()) AS varchar(2))) = 1 THEN '0' + CAST(DATEPART(ISO_WEEK, GETDATE()) AS varchar(2)) ELSE CAST(DATEPART(ISO_WEEK, GETDATE()) AS varchar(2)) END) +" +
                                        "SUBSTRING(CAST(DATEPART(YEAR, GETDATE()) AS varchar(4)), 3, 2) as yearWeek";
                //command.CommandText = "select '0419' as yearWeek";
                return command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                return "";
            }
            finally
            {
                conIZOTE.connection.Close();
            }
        }

        public string numero_etiquetas(ref string error, string numero_recolector, string numero_semana)
        {
            try
            {
                conIZOTE.connection.Open();
                command.Connection = conIZOTE.connection;
                command.CommandText = $"select ISNULL((Max(Numero)), 0) AS numero_Etiqueta From tbl_etiqueta WHERE recolector = {numero_recolector} AND wk = {numero_semana}";
                //command.CommandText = $"select 45 AS numero_Etiquetas";
                return command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                return "";
            }
            finally
            {
                conIZOTE.connection.Close();
            }
        }

        public bool insertIzote(ref string error, string wk, string numero, string recolector, DateTime fecha, string procede, string proveedor, string tipo, string tipobrote,
            string altura, string altura2, string bulbo, string madurez, string yavele, string deshidratada, string vale, DateTime e100, string e100sal, DateTime e200, string e200sal,
            DateTime e31, string e31sal, DateTime e32, string e32sal, string saneo, string e400, string contenedor, string wkenja, string gaveta, string probagric, string rango, 
            string ingraiz, DateTime fechaingreso, string exportado, int id_variedad, string id_procedencia, string id_proveedor, string id_recolector)
        {
            try { 
            conIZOTE.connection.Open();
            command.Connection = conIZOTE.connection;
            command.Transaction = conIZOTE.connection.BeginTransaction();
            command.Parameters.Clear();
            command.CommandText = "INSERT INTO tbl_etiqueta " +
                                               "(wk, " +
                                                "numero, " +
                                                "recolector, " +
                                                "fecha, " +
                                                "procede, " +
                                                "proveedor, " +
                                                "tipo, " +
                                                "tipobrote, " +
                                                "altura, " +
                                                "altura2, " +
                                                "bulbo, " +
                                                "madurez, " +
                                                "yavale, " +
                                                "deshidratada, " +
                                                "vale, " +
                                                "e100, " +
                                                "e100sal, " +
                                                "e200, " +
                                                "e200sal, " +
                                                "e31, " +
                                                "e31sal, " +
                                                "e32, " +
                                                "e32sal, " +
                                                "saneo, " +
                                                "e400, " +
                                                "contenedor, " +
                                                "wkenja, " +
                                                "gaveta, " +
                                                "probagric, " +
                                                "rango, " +
                                                "ingraiz, " +
                                                "fechaingre, " +
                                                "exportado, " +
                                                "id_variedad, " +
                                                "id_procedencia, " +
                                                "id_proveedor, " +
                                                "id_recolector, " +
                                                "fecha_real)" +
                                        "VALUES(" +
                                                "@wk, " +
                                                "@numero, " +
                                                "@recolector, " +
                                                "@fecha, " +
                                                "@procede, " +
                                                "@proveedor, " +
                                                "@tipo, " +
                                                "@tipobrote, " +
                                                "@altura, " +
                                                "@altura2, " +
                                                "@bulbo, " +
                                                "@madurez, " +
                                                "@yavale, " +
                                                "@deshidratada, " +
                                                "@vale, " +
                                                "@e100, " +
                                                "@e100sal, " +
                                                "@e200, " +
                                                "@e200sal, " +
                                                "@e31, " +
                                                "@e31sal, " +
                                                "@e32, " +
                                                "@e32sal, " +
                                                "@saneo, " +
                                                "@e400, " +
                                                "@contenedor, " +
                                                "@wkenja, " +
                                                "@gaveta, " +
                                                "@probagric, " +
                                                "@rango, " +
                                                "@ingraiz, " +
                                                "@fechaingre, " +
                                                "@exportado, " +
                                                "@id_variedad, " +
                                                "@id_procedencia, " +
                                                "@id_proveedor, " +
                                                "@id_recolector, "+
                                                "GETDATE())";
            command.Parameters.AddWithValue("@wk", wk);
            command.Parameters.AddWithValue("@numero", numero);
            command.Parameters.AddWithValue("@recolector", recolector);
            command.Parameters.AddWithValue("@fecha", fecha);
            command.Parameters.AddWithValue("@procede", procede);
            command.Parameters.AddWithValue("@proveedor", proveedor);
            command.Parameters.AddWithValue("@tipo", tipo);
            command.Parameters.AddWithValue("@tipobrote", tipobrote);
            command.Parameters.AddWithValue("@altura", altura);
            command.Parameters.AddWithValue("@altura2", altura2);
            command.Parameters.AddWithValue("@bulbo", bulbo);
            command.Parameters.AddWithValue("@madurez", madurez);
            command.Parameters.AddWithValue("@yavale", yavele);
            command.Parameters.AddWithValue("@deshidratada", deshidratada);
            command.Parameters.AddWithValue("@vale", vale);
            command.Parameters.AddWithValue("@e100", e100);
            command.Parameters.AddWithValue("@e100sal", e100sal);
            command.Parameters.AddWithValue("@e200", e200);
            command.Parameters.AddWithValue("@e200sal", e200sal);
            command.Parameters.AddWithValue("@e31", e31);
            command.Parameters.AddWithValue("@e31sal", e31sal);
            command.Parameters.AddWithValue("@e32", e32);
            command.Parameters.AddWithValue("@e32sal", e32sal);
            command.Parameters.AddWithValue("@saneo", saneo);
            command.Parameters.AddWithValue("@e400", e400);
            command.Parameters.AddWithValue("@contenedor", contenedor);
            command.Parameters.AddWithValue("@wkenja", wkenja);
            command.Parameters.AddWithValue("@gaveta", gaveta);
            command.Parameters.AddWithValue("@probagric", probagric);
            command.Parameters.AddWithValue("@rango", rango);
            command.Parameters.AddWithValue("@ingraiz", ingraiz);
            command.Parameters.AddWithValue("@fechaingre", fechaingreso);
            command.Parameters.AddWithValue("@exportado", exportado);
            command.Parameters.AddWithValue("@id_variedad", id_variedad);
            command.Parameters.AddWithValue("@id_procedencia", id_procedencia);
            command.Parameters.AddWithValue("@id_proveedor", id_proveedor);
            command.Parameters.AddWithValue("@id_recolector", id_recolector);
            if (command.ExecuteNonQuery() != 0) {
                command.Transaction.Commit();
                return true;
            }
            else
            {
                command.Transaction.Rollback();
                return false;
            }
            }
            catch(Exception ex)
            {
                error = ex.ToString();
                command.Transaction.Rollback();
                return false;
            }
            finally
            {
                conIZOTE.connection.Close();
            }

        }

        public DataTable getAllProviderToDBF(ref string error)
        {
            try
            {
                DataTable returnTable = new DataTable("data");
                string query = "SELECT " +
                                                      "eti.wk AS Wk," +
                                                      "eti.numero AS Numero," +
                                                      "eti.recolector AS Recolector, " +
                                                      "Convert(date,fecha)  AS Fecha, " +
                                                      "eti.procede AS Procede, " +
                                                      "eti.proveedor AS Proveedor, " +
                                                      "(CASE WHEN LEN(eti.tipo)=1 THEN '0' + eti.tipo ELSE eti.tipo END) AS Tipo, " +
                                                      "eti.tipobrote AS Tipobrote, " +
                                                      "(SELECT (CASE WHEN LEN(medida)=2 THEN '0' + medida ELSE medida END) FROM tbl_altura WHERE id_altura = eti.altura) AS Altura, " +
                                                      "(SELECT (CASE WHEN LEN(medida)=2 THEN '0' + medida ELSE medida END) FROM tbl_altura WHERE id_altura = eti.altura) AS Altura2, " +
                                                      "(SELECT (CASE WHEN LEN(medida)=1 THEN '0' + medida ELSE medida END) FROM tbl_bulbo WHERE id_bulbo = eti.bulbo) AS Bulbo, " +
                                                      "Convert(date,fecha)  AS Fechaingre " +
                                                      " FROM " +
                                                      "tbl_etiqueta AS eti " +
                                                      "WHERE exportado = 0 " +
                                                      "ORDER BY eti.recolector, eti.numero";
                conIZOTE.connection.Open();
                command.Connection = conIZOTE.connection;
                command.Parameters.Clear();
                command.CommandText = query;
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
