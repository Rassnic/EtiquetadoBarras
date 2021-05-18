using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;

namespace IZOTE.FORMS
{
    public partial class reportViewer : Form
    {
        public reportViewer()
        {
            InitializeComponent();
        }

        private void reportViewer_Load(object sender, EventArgs e)
        {

        }

        private CLASES.ClassEtiquetas mEtiqueta = new CLASES.ClassEtiquetas();
        private CLASES.ClassIzote mIzote = new CLASES.ClassIzote();
        private static string error = "";

        public void imprimirEtiqueta(string recolector, string yearWek, string numero_inicial, string numero_final)
        {
            try
            {

                DataTable prueba = mEtiqueta.etiquetasIzote(ref error, Convert.ToInt32(numero_inicial), Convert.ToInt32(numero_final), Convert.ToInt32(yearWek), Convert.ToInt32(recolector));
                ReportDocument crystal = new ReportDocument();
                crystal.Load(@"C:\REPORTESIZOTE\rptEtiquetasIzote.rpt");

                crystal.SetDataSource(prueba);
                ViewerEtiqueta.ReportSource = crystal;
            }
            catch (Exception)
            {
                throw;
            }      
        }

    }
}
