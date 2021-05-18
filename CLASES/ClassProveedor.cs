using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZOTE.CLASES
{
    class ClassProveedor
    {
        private ClassConexion conFACE = new ClassConexion();
        private SqlCommand command = new SqlCommand();

        public DataTable getProviderSpecific(ref string error, string codigo_proveedor)
        {
            try
            {
                DataTable returnTable = new DataTable("datos");
                conFACE.connection.Open();
                command.Connection = conFACE.connection;
                command.Parameters.Clear();
                command.CommandText = "SELECT " +
                                            "pro.id_proveedor, " +
                                            "pro.primer_nombre + ' ' + pro.segundo_nombre + ' ' + pro.primer_apellido + ' ' + pro.segundo_apellido AS nombre_proveedor, " +
                                            "(CASE WHEN isnull(pro.nit, '') = '' THEN pro.dpi WHEN pro.nit = '' THEN pro.dpi ELSE pro.nit END) AS nitDPI, " +
                                            "(CASE WHEN pro.direccion = '' THEN (select dep.departamento + ', ' + mun.municipio From  tbl_departamento AS dep INNER JOIN tbl_municipio AS mun ON dep.id_departamento = mun.id_departamento WHERE id_municipio = pro.id_municipio) " +
                                            "      WHEN ISNULL(pro.direccion, '') = '' THEN (select dep.departamento + ', ' + mun.municipio From  tbl_departamento AS dep INNER JOIN tbl_municipio AS mun ON dep.id_departamento = mun.id_departamento WHERE id_municipio = pro.id_municipio) " +
                                            "ELSE pro.direccion END), " +
                                            "pro.codigo_proveedor, " +
                                            "(CASE WHEN pro.tipo_proveedor = 0 THEN (SELECT comentario_persona_individual FROM tbl_parametros_generales) ELSE (SELECT comentario_persona_juridica FROM tbl_parametros_generales) END) AS comentario " +
                                        "FROM tbl_proveedor as pro " +
                                        "WHERE " +
                                            "CAST(codigo_proveedor AS int) like CAST('" + codigo_proveedor + "' AS int)";
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
                conFACE.connection.Close();
            }
        }
    }
}
