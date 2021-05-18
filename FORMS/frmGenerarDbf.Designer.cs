namespace IZOTE.FORMS
{
    partial class frmGenerarDbf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerarDbf));
            this.btndescargardbf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndescargardbf
            // 
            this.btndescargardbf.Location = new System.Drawing.Point(89, 92);
            this.btndescargardbf.Name = "btndescargardbf";
            this.btndescargardbf.Size = new System.Drawing.Size(151, 80);
            this.btndescargardbf.TabIndex = 2;
            this.btndescargardbf.Text = "DESCARGAR DBF";
            this.btndescargardbf.UseVisualStyleBackColor = true;
            this.btndescargardbf.Click += new System.EventHandler(this.btndescargardbf_Click);
            // 
            // frmGenerarDbf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 274);
            this.Controls.Add(this.btndescargardbf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGenerarDbf";
            this.Text = "frmGenerarDbf";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndescargardbf;
    }
}