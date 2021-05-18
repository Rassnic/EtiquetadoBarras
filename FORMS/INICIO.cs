using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Data.SqlClient;

namespace IZOTE.FORMS
{
    public partial class INICIO : IZOTE.FORMS.Plantilla    {
        CLASES.ClassIzote izote = new CLASES.ClassIzote();
        CLASES.ClassConexionIZOTEBD conIZOTE = new CLASES.ClassConexionIZOTEBD();
        private SqlCommand command = new SqlCommand();

        static String error;

        public INICIO()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                frmIngresoEtiqueta ver = new frmIngresoEtiqueta();
                ver.MdiParent = WMMDI.ActiveForm;
                ver.Show();
                ver.Location = new Point(0, 0);
                this.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btndescargardbf_Click(object sender, EventArgs e)
        {
            System.Data.DataSet dsetiquet = new System.Data.DataSet();
            dsetiquet.Tables.Add(izote.getAllProviderToDBF(ref error));
            DataSetIntoDBF("TMPPONY", dsetiquet);

            try
            {
                conIZOTE.connection.Open();
                command.Connection = conIZOTE.connection;
                command.CommandText = "update tbl_etiqueta set exportado = 1";
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                error = ex.ToString();
            }
            finally
            {
                conIZOTE.connection.Close();
            }
        }

        private static void DataSetIntoDBF(string fileName, System.Data.DataSet dataSet)
        {
            ArrayList list = new ArrayList();
            string pathFile = @"c:\\Temp\";
            OleDbConnection con = new OleDbConnection(GetConnection(pathFile));
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                if (File.Exists(pathFile + fileName + ".dbf"))
            {
                    File.Delete(pathFile + fileName + ".dbf");
            }

                list.Add("Wk");
                list.Add("Numero");
                list.Add("Recolector");
                list.Add("Fecha");
                list.Add("Procede");
                list.Add("Proveedor");
                list.Add("Tipo");
                list.Add("Tipobrote");
                list.Add("Altura");
                list.Add("Altura2");
                list.Add("Bulbo");
                list.Add("Fechaingre");

                string createSql = "create table TMPPONY ([Wk] char(4), " +
                                                        "[Numero] char(5) , " +
                                                        "[Recolector] char(1), " +
                                                        "[Fecha] date , " +
                                                        "[Procede] char(4) , " +
                                                        "[Proveedor] char(5) , " +
                                                        "[Tipo] char(2), " +
                                                        "[Tipobrote] char(1), " +
                                                        "[Altura] char(3), " +
                                                        "[Altura2] char(3), " +
                                                        "[Bulbo] char(2), " +
                                                        "[Madurez] char(1) , " +
                                                        "[Yavale] Logical, " +
                                                        "[Deshidrata] Logical, " +
                                                        "[Vale] char(6) , " +
                                                        "[E100] date , " +
                                                        "[E100sal] Logical,  " +
                                                        "[E200] date , " +
                                                        "[E200sal] Logical, " +
                                                        "[E31] date , " +
                                                        "[E31sal] Logical, " +
                                                        "[E32] date , " +
                                                        "[E32sal] Logical, " +
                                                        "[Saneo] char(8) , " +
                                                        "[E400] date , " +
                                                        "[Contenedor] char(11) , " +
                                                        "[Wkenja] char(4) , " +
                                                        "[Gaveta] char(3) , " +
                                                        "[Probagric] char(1) , " +
                                                        "[Rango] char(3) , " +
                                                        "[Ingraiz] Logical, " +
                                                        "[Fechaingre] date)";
                con.Open();
            cmd.Connection = con;
            cmd.CommandText = createSql;
            cmd.ExecuteNonQuery();

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                string insertSql = "insert into " + fileName + "(Wk,Numero,Recolector,Fecha,Procede,Proveedor, Tipo,Tipobrote,Altura,Altura2,Bulbo,Fechaingre) values(";

                for (int i = 0; i < list.Count; i++)
                {

                   //if (ReplaceEscape(row[list[i].ToString()].ToString()).ToString() == "07/11/18")
                   // {
                   //   insertSql = insertSql + "ctod('" + ReplaceEscape(row[list[i].ToString()].ToString()) + "'), ";
                   // }else
                        if (ReplaceEscape(row[list[i].ToString()].ToString()).ToString() == "F")
                    {
                        insertSql = insertSql + "" + ReplaceEscape(row[list[i].ToString()].ToString()) + "alse, ";
                    }
                    else if (ReplaceEscape(row[list[i].ToString()].ToString()).ToString() == "0")
                    {
                        insertSql = insertSql + "" + ReplaceEscape(row[list[i].ToString()].ToString()) + ", ";
                    }
                    else if (ReplaceEscape(row[list[i].ToString()].ToString()).ToString() == "")
                    {
                        insertSql = insertSql + "' ', ";
                    }
                    else
                    {
                        insertSql = insertSql + "'" + ReplaceEscape(row[list[i].ToString()].ToString()) + "',";
                    }

                }
                insertSql = insertSql.Substring(0, insertSql.Length - 1) + ")";
                cmd.CommandText = insertSql;
                cmd.ExecuteNonQuery();
                }
                MessageBox.Show("El proceso de creacion de DBF termino correctamente", "Exito");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error creando DBF");
            }
            finally
            {
                con.Close();
            }
        }

        private static string GetConnection(string path)
        {
            return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;";
        }

        public static string ReplaceEscape(string str)
        {
            str = str.Replace("'", "''");
            return str;
        }

        private void showWarning(string error)
        {
            try
            {
                MessageBox.Show(error, "Advertencia");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en show warning" + ex.ToString());
            }
        }


    }
}
