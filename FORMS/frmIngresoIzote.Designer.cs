namespace IZOTE.FORMS
{
    partial class frmIngresoEtiqueta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoEtiqueta));
            this.cmbNoIdentificacion = new System.Windows.Forms.ComboBox();
            this.cmbBulbo = new System.Windows.Forms.ComboBox();
            this.cmbAltura = new System.Windows.Forms.ComboBox();
            this.cmbNormalBrote = new System.Windows.Forms.ComboBox();
            this.cmbLisoRamificado = new System.Windows.Forms.ComboBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtSemana = new System.Windows.Forms.TextBox();
            this.txtNoEtiquetas = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNoEtiquetas = new System.Windows.Forms.Label();
            this.lblBulbo = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblNormalBrote = new System.Windows.Forms.Label();
            this.lblLisoRamificado = new System.Windows.Forms.Label();
            this.lblSemana = new System.Windows.Forms.Label();
            this.lblProcedencia = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblNoIdentificacion = new System.Windows.Forms.Label();
            this.dtpFechaEtiqueta = new System.Windows.Forms.DateTimePicker();
            this.lblSemanaNumero = new System.Windows.Forms.Label();
            this.lbaSemanaEtiquetado = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblDano = new System.Windows.Forms.Label();
            this.lblNoEtiquetasEmi = new System.Windows.Forms.Label();
            this.lblEtiquetaEmi = new System.Windows.Forms.Label();
            this.chkCambioSemana = new System.Windows.Forms.CheckBox();
            this.lblNameProvee = new System.Windows.Forms.Label();
            this.lblNameProcedencia = new System.Windows.Forms.Label();
            this.txtProcedencia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbNoIdentificacion
            // 
            this.cmbNoIdentificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNoIdentificacion.FormattingEnabled = true;
            this.cmbNoIdentificacion.Location = new System.Drawing.Point(167, 156);
            this.cmbNoIdentificacion.Name = "cmbNoIdentificacion";
            this.cmbNoIdentificacion.Size = new System.Drawing.Size(174, 21);
            this.cmbNoIdentificacion.TabIndex = 1;
            this.cmbNoIdentificacion.SelectedIndexChanged += new System.EventHandler(this.cmbNoIdentificacion_SelectedIndexChanged);
            // 
            // cmbBulbo
            // 
            this.cmbBulbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBulbo.FormattingEnabled = true;
            this.cmbBulbo.Location = new System.Drawing.Point(299, 456);
            this.cmbBulbo.Name = "cmbBulbo";
            this.cmbBulbo.Size = new System.Drawing.Size(174, 21);
            this.cmbBulbo.TabIndex = 8;
            // 
            // cmbAltura
            // 
            this.cmbAltura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAltura.FormattingEnabled = true;
            this.cmbAltura.Location = new System.Drawing.Point(299, 422);
            this.cmbAltura.Name = "cmbAltura";
            this.cmbAltura.Size = new System.Drawing.Size(174, 21);
            this.cmbAltura.TabIndex = 7;
            // 
            // cmbNormalBrote
            // 
            this.cmbNormalBrote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNormalBrote.FormattingEnabled = true;
            this.cmbNormalBrote.Location = new System.Drawing.Point(299, 347);
            this.cmbNormalBrote.Name = "cmbNormalBrote";
            this.cmbNormalBrote.Size = new System.Drawing.Size(174, 21);
            this.cmbNormalBrote.TabIndex = 5;
            // 
            // cmbLisoRamificado
            // 
            this.cmbLisoRamificado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLisoRamificado.FormattingEnabled = true;
            this.cmbLisoRamificado.Location = new System.Drawing.Point(299, 308);
            this.cmbLisoRamificado.Name = "cmbLisoRamificado";
            this.cmbLisoRamificado.Size = new System.Drawing.Size(174, 21);
            this.cmbLisoRamificado.TabIndex = 4;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(198, 219);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(85, 20);
            this.txtProveedor.TabIndex = 2;
            this.txtProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProveedor_KeyPress);
            this.txtProveedor.Leave += new System.EventHandler(this.txtProveedor_Leave);
            // 
            // txtSemana
            // 
            this.txtSemana.Location = new System.Drawing.Point(467, 159);
            this.txtSemana.Name = "txtSemana";
            this.txtSemana.Size = new System.Drawing.Size(174, 20);
            this.txtSemana.TabIndex = 10;
            this.txtSemana.Leave += new System.EventHandler(this.txtSemana_Leave);
            // 
            // txtNoEtiquetas
            // 
            this.txtNoEtiquetas.Location = new System.Drawing.Point(325, 504);
            this.txtNoEtiquetas.Name = "txtNoEtiquetas";
            this.txtNoEtiquetas.Size = new System.Drawing.Size(174, 20);
            this.txtNoEtiquetas.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(368, 567);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 37);
            this.btnGuardar.TabIndex = 118;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(167, 567);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 37);
            this.btnSalir.TabIndex = 117;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNoEtiquetas
            // 
            this.lblNoEtiquetas.AutoSize = true;
            this.lblNoEtiquetas.Location = new System.Drawing.Point(127, 507);
            this.lblNoEtiquetas.Name = "lblNoEtiquetas";
            this.lblNoEtiquetas.Size = new System.Drawing.Size(174, 13);
            this.lblNoEtiquetas.TabIndex = 116;
            this.lblNoEtiquetas.Text = "TOTAL DE ETIQUETAS A EMITIR";
            // 
            // lblBulbo
            // 
            this.lblBulbo.AutoSize = true;
            this.lblBulbo.Location = new System.Drawing.Point(231, 459);
            this.lblBulbo.Name = "lblBulbo";
            this.lblBulbo.Size = new System.Drawing.Size(43, 13);
            this.lblBulbo.TabIndex = 115;
            this.lblBulbo.Text = "BULBO";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(224, 425);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(50, 13);
            this.lblAltura.TabIndex = 114;
            this.lblAltura.Text = "ALTURA";
            // 
            // lblNormalBrote
            // 
            this.lblNormalBrote.AutoSize = true;
            this.lblNormalBrote.Location = new System.Drawing.Point(147, 350);
            this.lblNormalBrote.Name = "lblNormalBrote";
            this.lblNormalBrote.Size = new System.Drawing.Size(127, 13);
            this.lblNormalBrote.TabIndex = 113;
            this.lblNormalBrote.Text = "NORMAL / CON BROTE";
            // 
            // lblLisoRamificado
            // 
            this.lblLisoRamificado.AutoSize = true;
            this.lblLisoRamificado.Location = new System.Drawing.Point(166, 308);
            this.lblLisoRamificado.Name = "lblLisoRamificado";
            this.lblLisoRamificado.Size = new System.Drawing.Size(108, 13);
            this.lblLisoRamificado.TabIndex = 112;
            this.lblLisoRamificado.Text = "LISO / RAMIFICADO";
            // 
            // lblSemana
            // 
            this.lblSemana.AutoSize = true;
            this.lblSemana.Location = new System.Drawing.Point(390, 159);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(52, 13);
            this.lblSemana.TabIndex = 110;
            this.lblSemana.Text = "SEMANA";
            // 
            // lblProcedencia
            // 
            this.lblProcedencia.AutoSize = true;
            this.lblProcedencia.Location = new System.Drawing.Point(44, 267);
            this.lblProcedencia.Name = "lblProcedencia";
            this.lblProcedencia.Size = new System.Drawing.Size(129, 13);
            this.lblProcedencia.TabIndex = 109;
            this.lblProcedencia.Text = "CODIGO PROCEDENCIA";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(53, 226);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(120, 13);
            this.lblProveedor.TabIndex = 108;
            this.lblProveedor.Text = "CODIGO PROVEEDOR";
            // 
            // lblNoIdentificacion
            // 
            this.lblNoIdentificacion.AutoSize = true;
            this.lblNoIdentificacion.Location = new System.Drawing.Point(12, 156);
            this.lblNoIdentificacion.Name = "lblNoIdentificacion";
            this.lblNoIdentificacion.Size = new System.Drawing.Size(130, 13);
            this.lblNoIdentificacion.TabIndex = 107;
            this.lblNoIdentificacion.Text = "No. DE IDENTIFICACION";
            // 
            // dtpFechaEtiqueta
            // 
            this.dtpFechaEtiqueta.Location = new System.Drawing.Point(179, 63);
            this.dtpFechaEtiqueta.Name = "dtpFechaEtiqueta";
            this.dtpFechaEtiqueta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEtiqueta.TabIndex = 11;
            // 
            // lblSemanaNumero
            // 
            this.lblSemanaNumero.AutoSize = true;
            this.lblSemanaNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemanaNumero.Location = new System.Drawing.Point(492, 63);
            this.lblSemanaNumero.Name = "lblSemanaNumero";
            this.lblSemanaNumero.Size = new System.Drawing.Size(17, 18);
            this.lblSemanaNumero.TabIndex = 105;
            this.lblSemanaNumero.Text = "0";
            // 
            // lbaSemanaEtiquetado
            // 
            this.lbaSemanaEtiquetado.AutoSize = true;
            this.lbaSemanaEtiquetado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaSemanaEtiquetado.Location = new System.Drawing.Point(399, 63);
            this.lbaSemanaEtiquetado.Name = "lbaSemanaEtiquetado";
            this.lbaSemanaEtiquetado.Size = new System.Drawing.Size(76, 18);
            this.lbaSemanaEtiquetado.TabIndex = 104;
            this.lbaSemanaEtiquetado.Text = "SEMANA";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(110, 63);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(63, 18);
            this.lblfecha.TabIndex = 103;
            this.lblfecha.Text = "FECHA";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(299, 384);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(174, 21);
            this.cmbTipo.TabIndex = 6;
            // 
            // lblDano
            // 
            this.lblDano.AutoSize = true;
            this.lblDano.Location = new System.Drawing.Point(147, 387);
            this.lblDano.Name = "lblDano";
            this.lblDano.Size = new System.Drawing.Size(127, 13);
            this.lblDano.TabIndex = 129;
            this.lblDano.Text = "CON DAÑO / SIN DAÑO";
            // 
            // lblNoEtiquetasEmi
            // 
            this.lblNoEtiquetasEmi.AutoSize = true;
            this.lblNoEtiquetasEmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoEtiquetasEmi.Location = new System.Drawing.Point(492, 99);
            this.lblNoEtiquetasEmi.Name = "lblNoEtiquetasEmi";
            this.lblNoEtiquetasEmi.Size = new System.Drawing.Size(17, 18);
            this.lblNoEtiquetasEmi.TabIndex = 132;
            this.lblNoEtiquetasEmi.Text = "0";
            // 
            // lblEtiquetaEmi
            // 
            this.lblEtiquetaEmi.AutoSize = true;
            this.lblEtiquetaEmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaEmi.Location = new System.Drawing.Point(305, 99);
            this.lblEtiquetaEmi.Name = "lblEtiquetaEmi";
            this.lblEtiquetaEmi.Size = new System.Drawing.Size(181, 18);
            this.lblEtiquetaEmi.TabIndex = 131;
            this.lblEtiquetaEmi.Text = "ETIQUETAS EMITIDAS";
            // 
            // chkCambioSemana
            // 
            this.chkCambioSemana.AutoSize = true;
            this.chkCambioSemana.Location = new System.Drawing.Point(495, 185);
            this.chkCambioSemana.Name = "chkCambioSemana";
            this.chkCambioSemana.Size = new System.Drawing.Size(122, 17);
            this.chkCambioSemana.TabIndex = 133;
            this.chkCambioSemana.Text = "CAMBIAR SEMANA";
            this.chkCambioSemana.UseVisualStyleBackColor = true;
            this.chkCambioSemana.CheckedChanged += new System.EventHandler(this.chkCambioSemana_CheckedChanged);
            // 
            // lblNameProvee
            // 
            this.lblNameProvee.AutoSize = true;
            this.lblNameProvee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNameProvee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblNameProvee.Location = new System.Drawing.Point(342, 218);
            this.lblNameProvee.Name = "lblNameProvee";
            this.lblNameProvee.Size = new System.Drawing.Size(151, 18);
            this.lblNameProvee.TabIndex = 134;
            this.lblNameProvee.Text = "Nombre Proveedor";
            // 
            // lblNameProcedencia
            // 
            this.lblNameProcedencia.AutoSize = true;
            this.lblNameProcedencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNameProcedencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblNameProcedencia.Location = new System.Drawing.Point(342, 257);
            this.lblNameProcedencia.Name = "lblNameProcedencia";
            this.lblNameProcedencia.Size = new System.Drawing.Size(102, 18);
            this.lblNameProcedencia.TabIndex = 135;
            this.lblNameProcedencia.Text = "Procedencia";
            // 
            // txtProcedencia
            // 
            this.txtProcedencia.Location = new System.Drawing.Point(198, 258);
            this.txtProcedencia.MaxLength = 4;
            this.txtProcedencia.Name = "txtProcedencia";
            this.txtProcedencia.Size = new System.Drawing.Size(85, 20);
            this.txtProcedencia.TabIndex = 3;
            this.txtProcedencia.Leave += new System.EventHandler(this.txtProcedencia_Leave);
            // 
            // frmIngresoEtiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 625);
            this.Controls.Add(this.txtProcedencia);
            this.Controls.Add(this.lblNameProcedencia);
            this.Controls.Add(this.lblNameProvee);
            this.Controls.Add(this.chkCambioSemana);
            this.Controls.Add(this.lblNoEtiquetasEmi);
            this.Controls.Add(this.lblEtiquetaEmi);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblDano);
            this.Controls.Add(this.cmbNoIdentificacion);
            this.Controls.Add(this.cmbBulbo);
            this.Controls.Add(this.cmbAltura);
            this.Controls.Add(this.cmbNormalBrote);
            this.Controls.Add(this.cmbLisoRamificado);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtSemana);
            this.Controls.Add(this.txtNoEtiquetas);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblNoEtiquetas);
            this.Controls.Add(this.lblBulbo);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblNormalBrote);
            this.Controls.Add(this.lblLisoRamificado);
            this.Controls.Add(this.lblSemana);
            this.Controls.Add(this.lblProcedencia);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblNoIdentificacion);
            this.Controls.Add(this.dtpFechaEtiqueta);
            this.Controls.Add(this.lblSemanaNumero);
            this.Controls.Add(this.lbaSemanaEtiquetado);
            this.Controls.Add(this.lblfecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIngresoEtiqueta";
            this.Text = "frmIngresoEtiqueta";
            this.Load += new System.EventHandler(this.frmIngresoEtiqueta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNoIdentificacion;
        private System.Windows.Forms.ComboBox cmbBulbo;
        private System.Windows.Forms.ComboBox cmbAltura;
        private System.Windows.Forms.ComboBox cmbNormalBrote;
        private System.Windows.Forms.ComboBox cmbLisoRamificado;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtSemana;
        private System.Windows.Forms.TextBox txtNoEtiquetas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblNoEtiquetas;
        private System.Windows.Forms.Label lblBulbo;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblNormalBrote;
        private System.Windows.Forms.Label lblLisoRamificado;
        private System.Windows.Forms.Label lblSemana;
        private System.Windows.Forms.Label lblProcedencia;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblNoIdentificacion;
        private System.Windows.Forms.DateTimePicker dtpFechaEtiqueta;
        private System.Windows.Forms.Label lblSemanaNumero;
        private System.Windows.Forms.Label lbaSemanaEtiquetado;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblDano;
        private System.Windows.Forms.Label lblNoEtiquetasEmi;
        private System.Windows.Forms.Label lblEtiquetaEmi;
        private System.Windows.Forms.CheckBox chkCambioSemana;
        private System.Windows.Forms.Label lblNameProvee;
        private System.Windows.Forms.Label lblNameProcedencia;
        private System.Windows.Forms.TextBox txtProcedencia;
    }
}