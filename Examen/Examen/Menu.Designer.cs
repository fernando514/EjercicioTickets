namespace Vista
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeSoporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.celulareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipoDeComputoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.tiposDeSoporteToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(814, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // tiposDeSoporteToolStripMenuItem
            // 
            this.tiposDeSoporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.celulareToolStripMenuItem,
            this.equipoDeComputoToolStripMenuItem});
            this.tiposDeSoporteToolStripMenuItem.Name = "tiposDeSoporteToolStripMenuItem";
            this.tiposDeSoporteToolStripMenuItem.Size = new System.Drawing.Size(165, 29);
            this.tiposDeSoporteToolStripMenuItem.Text = "Tipos de Soporte";
            // 
            // celulareToolStripMenuItem
            // 
            this.celulareToolStripMenuItem.Name = "celulareToolStripMenuItem";
            this.celulareToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.celulareToolStripMenuItem.Text = "Celulares";
            this.celulareToolStripMenuItem.Click += new System.EventHandler(this.celulareToolStripMenuItem_Click);
            // 
            // equipoDeComputoToolStripMenuItem
            // 
            this.equipoDeComputoToolStripMenuItem.Name = "equipoDeComputoToolStripMenuItem";
            this.equipoDeComputoToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.equipoDeComputoToolStripMenuItem.Text = "Equipo de Computo";
            this.equipoDeComputoToolStripMenuItem.Click += new System.EventHandler(this.equipoDeComputoToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 455);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivosToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem tiposDeSoporteToolStripMenuItem;
        private ToolStripMenuItem celulareToolStripMenuItem;
        private ToolStripMenuItem equipoDeComputoToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
    }
}