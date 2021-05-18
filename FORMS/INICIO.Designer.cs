namespace IZOTE.FORMS
{
    partial class INICIO
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
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btndescargardbf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(127, 83);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(151, 80);
            this.btnIngreso.TabIndex = 0;
            this.btnIngreso.Text = "INGRESAR ETIQUETAS";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndescargardbf
            // 
            this.btndescargardbf.Location = new System.Drawing.Point(127, 210);
            this.btndescargardbf.Name = "btndescargardbf";
            this.btndescargardbf.Size = new System.Drawing.Size(151, 78);
            this.btndescargardbf.TabIndex = 1;
            this.btndescargardbf.Text = "DESCARGAR DBF";
            this.btndescargardbf.UseVisualStyleBackColor = true;
            this.btndescargardbf.Click += new System.EventHandler(this.btndescargardbf_Click);
            // 
            // INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 379);
            this.Controls.Add(this.btndescargardbf);
            this.Controls.Add(this.btnIngreso);
            this.Name = "INICIO";
            this.Text = "INICIO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btndescargardbf;
    }
}