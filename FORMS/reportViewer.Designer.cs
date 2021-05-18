namespace IZOTE.FORMS
{
    partial class reportViewer
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
            this.ViewerEtiqueta = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ViewerEtiqueta
            // 
            this.ViewerEtiqueta.ActiveViewIndex = -1;
            this.ViewerEtiqueta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ViewerEtiqueta.Cursor = System.Windows.Forms.Cursors.Default;
            this.ViewerEtiqueta.DisplayStatusBar = false;
            this.ViewerEtiqueta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewerEtiqueta.Location = new System.Drawing.Point(0, 0);
            this.ViewerEtiqueta.Name = "ViewerEtiqueta";
            this.ViewerEtiqueta.Size = new System.Drawing.Size(661, 485);
            this.ViewerEtiqueta.TabIndex = 0;
            this.ViewerEtiqueta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // reportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 485);
            this.Controls.Add(this.ViewerEtiqueta);
            this.Name = "reportViewer";
            this.Text = "reportViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ViewerEtiqueta;
    }
}