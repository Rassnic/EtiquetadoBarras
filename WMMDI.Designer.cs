namespace IZOTE
{
    partial class WMMDI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WMMDI));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.oPERACIONES = new System.Windows.Forms.ToolStripMenuItem();
            this.iNGRESOETIQUETASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gERERACIONDBFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPERACIONES});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // oPERACIONES
            // 
            this.oPERACIONES.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNGRESOETIQUETASToolStripMenuItem,
            this.gERERACIONDBFToolStripMenuItem});
            this.oPERACIONES.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.oPERACIONES.Name = "oPERACIONES";
            this.oPERACIONES.Size = new System.Drawing.Size(97, 20);
            this.oPERACIONES.Text = "OPERACIONES";
            // 
            // iNGRESOETIQUETASToolStripMenuItem
            // 
            this.iNGRESOETIQUETASToolStripMenuItem.Name = "iNGRESOETIQUETASToolStripMenuItem";
            this.iNGRESOETIQUETASToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.iNGRESOETIQUETASToolStripMenuItem.Text = "INGRESO ETIQUETAS";
            this.iNGRESOETIQUETASToolStripMenuItem.Click += new System.EventHandler(this.iNGRESOETIQUETASToolStripMenuItem_Click);
            // 
            // gERERACIONDBFToolStripMenuItem
            // 
            this.gERERACIONDBFToolStripMenuItem.Name = "gERERACIONDBFToolStripMenuItem";
            this.gERERACIONDBFToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.gERERACIONDBFToolStripMenuItem.Text = "GERERACION DBF";
            this.gERERACIONDBFToolStripMenuItem.Click += new System.EventHandler(this.gERERACIONDBFToolStripMenuItem_Click);
            // 
            // WMMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 751);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "WMMDI";
            this.Text = "WMMDI";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem oPERACIONES;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem iNGRESOETIQUETASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gERERACIONDBFToolStripMenuItem;
    }
}



