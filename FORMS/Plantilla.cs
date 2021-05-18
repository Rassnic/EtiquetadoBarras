using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IZOTE.FORMS
{
    public partial class Plantilla : Form
    {
        public Plantilla()
        {
            InitializeComponent();
        }
        private Int32 _id_Perfil;

        public Int32 Id_Perfil
        {
            get { return _id_Perfil; }
            set { _id_Perfil = value; }
        }
    }
}
