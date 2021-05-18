using IZOTE.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IZOTE.FORMS
{
    public partial class frmIngresoEtiqueta : Form
    {

        private ClassConexionIZOTEBD conIZOTE = new ClassConexionIZOTEBD();
        private SqlCommand command = new SqlCommand();

        private CLASES.ClassRecolector mRecolector = new CLASES.ClassRecolector();
        private CLASES.ClassProcedencia mProcedencia = new CLASES.ClassProcedencia();
        private CLASES.ClassAltura  mAltura = new CLASES.ClassAltura();
        private CLASES.ClassBulbo mBulbo = new CLASES.ClassBulbo();
        private CLASES.ClassTipo mVariedad = new CLASES.ClassTipo();
        private CLASES.ClassBrote mBrote = new CLASES.ClassBrote();
        private CLASES.ClassTipoDano mDano = new CLASES.ClassTipoDano();
        private CLASES.ClassIzote mEtiqueta = new CLASES.ClassIzote();
        private CLASES.ClassProveedor oproveedor = new CLASES.ClassProveedor();

        private static string error = "";
        private static string YearWeek = "";
        private static int numero_inicial = 0;
        private static int numero_final = 0;
        private string id_provee = "";
        private string id_procede = "";

        public frmIngresoEtiqueta()
        {
            InitializeComponent();            
        }

        #region manejo combox

        private void getRecolector( string id_recolector)
        {
            try
            {
                cmbNoIdentificacion.DataSource = mRecolector.getRecolector(ref error);
                cmbNoIdentificacion.DisplayMember = "descripcion";
                cmbNoIdentificacion.ValueMember = "id";
                cmbNoIdentificacion.SelectedValue = id_recolector;
            }
            catch (Exception ex)
            {
                showError(error + " " + ex.ToString());
            }
        }

        //private void getProcedencia()
        //{
        //    try
        //    {
        //        cmbProcedencia.DataSource = mProcedencia.getProcedencia (ref error);
        //        cmbProcedencia.DisplayMember = "municipio";
        //        cmbProcedencia.ValueMember = "id";
        //        cmbProcedencia.SelectedValue = "2301";
        //    }
        //    catch (Exception ex)
        //    {
        //        showError(error + " " + ex.ToString());
        //    }
        //}

        private void getAltura()
        {
            try
            {
                cmbAltura.DataSource = mAltura.getAltura(ref error);
                cmbAltura.DisplayMember = "descripcion";
                cmbAltura.ValueMember = "id";
                cmbAltura.SelectedValue = "1";               
            }
            catch (Exception ex)
            {
                showError(error + " " + ex.ToString());
            }
        }

        private void getBulbo()
        {
            try
            {
                cmbBulbo.DataSource = mBulbo.getBulbo(ref error);
                cmbBulbo.DisplayMember = "descripcion";
                cmbBulbo.ValueMember = "id";
                cmbBulbo.SelectedValue = "2";
            }
            catch (Exception ex)
            {
                showError(error + " " + ex.ToString());
            }
        }

        private void getVariedad()
        {
            try
            {
                cmbLisoRamificado.DataSource = mVariedad.getVariedad(ref error);
                cmbLisoRamificado.DisplayMember = "descripcion";
                cmbLisoRamificado.ValueMember = "id";
                cmbLisoRamificado.SelectedValue = "1";
            }
            catch (Exception ex)
            {
                showError(error + " " + ex.ToString());
            }
        }

        private void getBrote()
        {
            try
            {
                cmbNormalBrote.DataSource = mBrote.getBrote(ref error);
                cmbNormalBrote.DisplayMember = "descripcion";
                cmbNormalBrote.ValueMember = "id";
                cmbNormalBrote.SelectedValue = "1";
            }
            catch (Exception ex)
            {
                showError(error + " " + ex.ToString());
            }
        }

        private void getDano()
        {
            try
            {
                cmbTipo .DataSource = mDano.getDano(ref error);
                cmbTipo.DisplayMember = "descripcion";
                cmbTipo.ValueMember = "id";
                cmbTipo.SelectedValue = "1";
            }
            catch (Exception ex)
            {
                showError(error + " " + ex.ToString());
            }
        }

        #endregion

        #region mensajes

        private void showSuccess(string message)
        {
            MessageBox.Show(message, "Bien hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showError(string _error)
        {
            MessageBox.Show(_error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void showWarning(string _error)
        {
            MessageBox.Show(_error, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void showWarning(string _error, string nombre_ventana)
        {
            MessageBox.Show(_error, nombre_ventana, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region obtener Week

        private void getYearWeek()
        {
            try
            {
                YearWeek = mEtiqueta.getYearNumberWeek(ref error);
            }
            catch (Exception ex)
            {
                showWarning(ex.ToString());
            }
        }

        private void getNumberWeek()
        {
            try
            {
                lblSemanaNumero.Text = mEtiqueta.getYearNumberWeek(ref error);
                txtSemana.Text = mEtiqueta.getYearNumberWeek(ref error);
                txtSemana.Enabled = false;               
            }
            catch (Exception ex)
            {
                showWarning(error + ex.ToString());
            }
        }

        private void manejaSemana()
        {
            try
            {
                if (!chkCambioSemana.Checked)
                {

                    txtSemana.Enabled = false;
                }
                else
                {
                    txtSemana.Enabled = true;
                    showWarning("USTED A SELECCIONADO CAMBIAR SEMANA");
                }
            }
            catch (Exception ex)
            {
                showWarning(ex.ToString());
            }
        }
                
        private void chkCambioSemana_CheckedChanged(object sender, EventArgs e)
        {
            manejaSemana();
        }

        private void getNumeroEtiquetas()
        {
            try
            {
                lblNoEtiquetasEmi.Text = mEtiqueta.numero_etiquetas(ref error, cmbNoIdentificacion.SelectedValue.ToString(), lblSemanaNumero.Text);
            }
            catch (Exception ex)
            {
                showError(error + " " + ex.ToString());
                throw;
            }
        }

        #endregion

        #region Manejo de Datos Guardar

        private void guardarEtiqueta()
        {
            //insertarInformacionEtiqueta();
            try
            {
                
                if (insertarInformacionEtiqueta())
                {
                    int inicial = numero_inicial + 1;
                    showWarning(txtNoEtiquetas.Text + "  Etiquetas agregadas con exito" + "\n\r" +
                              "Del No.:  " + lblSemanaNumero.Text + makeNoetiqueta(inicial.ToString()) + "\n\r" +
                              "Al No.:  " + lblSemanaNumero.Text+makeNoetiqueta(numero_final.ToString()) + "\n\r" +
                              "Del Recolector:  " + cmbNoIdentificacion.SelectedValue.ToString() + "\n\r" +
                              "Para el Proveedor: " + lblNameProvee.Text + "\n\r" +
                              "De Procedencia:  " + lblNameProcedencia.Text + "\n\r" ,
                              "Buen trabajo."); 
                     showSuccess("Etiquetas agregadas con exito.");
                     imprimirEtiqueta(numero_inicial, numero_final);
                     //resetControls();
                     this.Close();
                    }
                    else
                    {
                        showError("Ocurrio un error agregando bandejas.");
                    }
            }
            catch (Exception ex)
            {
                showWarning(ex.ToString());
            }
        }

        private void resetControls()
        {
            try
            {
                getRecolector("1");
            }
            catch (Exception ex)
            {
                showError(error + " " + ex.ToString());
            }
        }

        private Boolean validaInformacion()
        {
            return true;
        }

        private Boolean insertarInformacionEtiqueta()   
        {
            int numero_Etiqueta = Convert.ToInt32(lblNoEtiquetasEmi.Text);
            try
            {
                numero_inicial = numero_Etiqueta;
                numero_final = numero_inicial + Convert.ToInt32(txtNoEtiquetas.Text);

                bool returnBool = false;

                getCodigoPlanta();

                for (int i = 0; i < Convert.ToInt32(txtNoEtiquetas.Text); i++)
                {

                    numero_Etiqueta += 1;
                    if (mEtiqueta.insertIzote(ref error, txtSemana.Text,
                        makeNoetiqueta(numero_Etiqueta.ToString()),
                        cmbNoIdentificacion.SelectedValue.ToString(), Convert.ToDateTime(dtpFechaEtiqueta.Text),
                        makeNoprocedencia(txtProcedencia.Text), makeNoproveedor(txtProveedor.Text), cmbTipo.SelectedValue.ToString(), cmbNormalBrote.SelectedValue.ToString(),
                        cmbAltura.SelectedValue.ToString(), cmbAltura.SelectedValue.ToString(), cmbBulbo.SelectedValue.ToString(), "", "", "", "", 
                        Convert.ToDateTime(dtpFechaEtiqueta.Text), "",
                        Convert.ToDateTime(dtpFechaEtiqueta.Text), "", 
                        Convert.ToDateTime(dtpFechaEtiqueta.Text), "", 
                        Convert.ToDateTime(dtpFechaEtiqueta.Text), "", "", "", "", "", "", "", "", "", 
                        Convert.ToDateTime(dtpFechaEtiqueta.Text), "", 
                        Convert.ToInt32(cmbTipo.SelectedValue.ToString()),
                        id_procede.ToString(), id_provee.ToString(), cmbNoIdentificacion.SelectedValue.ToString()))
                    {
                        returnBool = true;
                    }
                    else
                    {
                        returnBool = false;
                    }
                }
                return returnBool;
            }
            catch (Exception ex)
            {
                showWarning("Bandeja No. " + numero_Etiqueta.ToString() + " >" + ex.ToString());
                return false;
            }
        }

        private static string codigo_planta = "";
        private void getCodigoPlanta()
        {
            try
            {
                codigo_planta = mVariedad.codigoVariedad(ref error, cmbTipo.SelectedValue.ToString());
            }
            catch (Exception ex)
            {                
                showWarning(ex.ToString());
            }
        }


        private void imprimirEtiqueta(int numero_inicial, int numero_final)
        {
            try
            {
                //FormularioEstaAbierto("reportViewer");
                numero_inicial += 1;
                reportViewer verReporte = new reportViewer();
                verReporte.imprimirEtiqueta(cmbNoIdentificacion.SelectedValue.ToString(), lblSemanaNumero.Text, numero_inicial.ToString(), numero_final.ToString());
                verReporte.Show();

            }
            catch (Exception ex)
            {
                showError(ex.ToString());
            }
            finally
            {
                conIZOTE.connection.Close();
            }
        }

        #endregion
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarEtiqueta();
        }

        private string makeNoetiqueta(string numero_Etiqueta)
        {
            try
            {
                string ceros = "";

                if (numero_Etiqueta.Length == 1)
                {
                    ceros = YearWeek + "0000" + numero_Etiqueta;
                }
                else if (numero_Etiqueta.Length == 2)
                {
                    ceros = YearWeek + "000" + numero_Etiqueta;
                }
                else if (numero_Etiqueta.Length == 3)
                {
                    ceros = YearWeek + "00" + numero_Etiqueta;
                }
                else if (numero_Etiqueta.Length == 4)
                {
                    ceros = YearWeek + "0" + numero_Etiqueta;
                }
                else if (numero_Etiqueta.Length == 5)
                {
                    ceros = YearWeek + "" + numero_Etiqueta;
                }

                return ceros;
            }
            catch (Exception ex)
            {
                showWarning(ex.ToString());
                return "00000000";
            }
        }

        private string makeNoproveedor(string numero_Proveedor)
        {
            try
            {
                string ceros = "";

                if (numero_Proveedor.Length == 1)
                {
                    ceros = "0000" + numero_Proveedor;
                }
                else if (numero_Proveedor.Length == 2)
                {
                    ceros = "000" + numero_Proveedor;
                }
                else if (numero_Proveedor.Length == 3)
                {
                    ceros = "00" + numero_Proveedor;
                }
                else if (numero_Proveedor.Length == 4)
                {
                    ceros = "0" + numero_Proveedor;
                }
                else if (numero_Proveedor.Length == 5)
                {
                    ceros = "" + numero_Proveedor;
                }

                return ceros;
            }
            catch (Exception ex)
            {
                showWarning(ex.ToString());
                return "00000000";
            }
        }

        private string makeNoprocedencia(string numero_Procedencia)
        {
            try
            {
                string ceros = "";

                if (numero_Procedencia.Length == 1)
                {
                    ceros = "000" + numero_Procedencia;
                }
                else if (numero_Procedencia.Length == 2)
                {
                    ceros = "00" + numero_Procedencia;
                }
                else if (numero_Procedencia.Length == 3)
                {
                    ceros = "0" + numero_Procedencia;
                }
                else if (numero_Procedencia.Length == 4)
                {
                    ceros = "" + numero_Procedencia;
                }
                return ceros;
            }
            catch (Exception ex)
            {
                showWarning(ex.ToString());
                return "00000000";
            }
        }

        private void cmbNoIdentificacion_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!cmbNoIdentificacion.SelectedValue.ToString().Equals("System.Data.DataRowView"))
            {
                if (cmbNoIdentificacion.SelectedValue.ToString().Equals("0"))
                {
                    lblEtiquetaEmi.Text = "";
                }
                else
                {
                    getNumeroEtiquetas();
                }
            }
    }

        private void frmIngresoEtiqueta_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "INGRESO DE ETIQUETAS";
                getRecolector("1");
                //getProcedencia();
                getAltura();
                getBulbo();
                getVariedad();
                getBrote();
                getDano();
                getNumberWeek();
                getNumeroEtiquetas();

            }
            catch (Exception ex)
            {
                showError(error + " " + ex.ToString());
            }
        }

        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumerosSinSignos(e);
        }

        public void SoloNumerosSinSignos(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;

            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;

            }
            else
            {
                pE.Handled = true;

            }
        }

        private void txtProveedor_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!txtProveedor.Text.Equals(""))
                {
                    getProvider(txtProveedor.Text.ToString());
                }
                else
                {
                    showWarning("Por favor ingrese un codigo de proveedor para poder buscarlo.");
                }
            }
            catch (Exception ex)
            {
                showError(ex.ToString());
            }
        }

        private void getProvider(string codigo_proveedor)
        {
            
            try
            {
                DataTable dtProveedor = oproveedor.getProviderSpecific(ref error, codigo_proveedor);
                if (dtProveedor == null)
                {
                    throw new Exception();
                }
                else if (dtProveedor.Rows.Count <= 0)
                {
                    showWarning("Codigo no existe o esta mal escrito, por favor verifiquelo y vuelva a intentarlo.", "Error en codigo");
                }
                else
                {
                    foreach (DataRow row in dtProveedor.Rows)
                    {
                        id_provee = row[0].ToString();
                        lblNameProvee.Text = row[1].ToString();
                        txtProveedor.Text = makeNoproveedor(txtProveedor.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                showWarning(error + " " + ex.ToString());
            }
        }

        private void txtProcedencia_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!txtProcedencia.Text.Equals(""))
                {
                    getProcedencia(txtProcedencia.Text.ToString());
                }
                else
                {
                    showWarning("Por favor ingrese un codigo de Procedencia para poder buscarlo.");
                }
            }
            catch (Exception ex)
            {
                showError(ex.ToString());
            }
        }

        private void getProcedencia(string codigo_procedencia)
        {
            try
            {
                DataTable dtProcedencia = mProcedencia.obtenerProcedencia(ref error, codigo_procedencia);
                if (dtProcedencia == null)
                {
                    throw new Exception();
                }
                else if (dtProcedencia.Rows.Count <= 0)
                {
                    showWarning("Codigo no existe o esta mal escrito, por favor verifiquelo y vuelva a intentarlo.", "Error en codigo");
                }
                else
                {
                    foreach (DataRow row in dtProcedencia.Rows)
                    {
                        id_procede = row[0].ToString();
                        lblNameProcedencia.Text = row[2].ToString();
                        txtProcedencia.Text = makeNoprocedencia(txtProcedencia.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                showWarning(error + " " + ex.ToString());
            }
        }

        private void txtSemana_Leave(object sender, EventArgs e)
        {
            try
            {
                lblSemanaNumero.Text = txtSemana.Text;
                getNumeroEtiquetas();

            }
            catch (Exception ex)
            {
                showWarning(error + "" + ex.ToString());
            }
        }
    }
    }
