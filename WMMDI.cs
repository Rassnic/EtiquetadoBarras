using IZOTE.FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IZOTE
{
    public partial class WMMDI : Form
    {

        public WMMDI()
        {
            InitializeComponent();
            this.Text = "IZOTE";
            frmIngresoEtiqueta   show = new frmIngresoEtiqueta();
            show.MdiParent = this;
            show.Show();
            show.Location = new Point(50, 50);
        }
               
        private void iNGRESOETIQUETASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmIngresoEtiqueta ver = new frmIngresoEtiqueta();
                ver.MdiParent = this;
                ver.Show();
                ver.Location = new Point(0, 0);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void gERERACIONDBFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmGenerarDbf ver = new frmGenerarDbf();
                ver.MdiParent = this;
                ver.Show();
                ver.Location = new Point(0, 0);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
