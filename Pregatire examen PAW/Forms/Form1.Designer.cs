namespace Pregatire_examen_PAW
{
    partial class Form1
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
            this.insereazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewPoligoane = new System.Windows.Forms.ListView();
            this.cod_figura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eticheta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grosime_linie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salvareSerializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareDeserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insereazaToolStripMenuItem,
            this.salvareSerializareToolStripMenuItem,
            this.restaurareDeserializareToolStripMenuItem,
            this.desenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // insereazaToolStripMenuItem
            // 
            this.insereazaToolStripMenuItem.Name = "insereazaToolStripMenuItem";
            this.insereazaToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.insereazaToolStripMenuItem.Text = "Insereaza poligon";
            this.insereazaToolStripMenuItem.Click += new System.EventHandler(this.insereazaToolStripMenuItem_Click);
            // 
            // listViewPoligoane
            // 
            this.listViewPoligoane.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cod_figura,
            this.eticheta,
            this.grosime_linie});
            this.listViewPoligoane.HideSelection = false;
            this.listViewPoligoane.Location = new System.Drawing.Point(82, 73);
            this.listViewPoligoane.Name = "listViewPoligoane";
            this.listViewPoligoane.Size = new System.Drawing.Size(641, 279);
            this.listViewPoligoane.TabIndex = 1;
            this.listViewPoligoane.UseCompatibleStateImageBehavior = false;
            this.listViewPoligoane.View = System.Windows.Forms.View.Details;
            // 
            // cod_figura
            // 
            this.cod_figura.Text = "cod_figura";
            this.cod_figura.Width = 113;
            // 
            // eticheta
            // 
            this.eticheta.Text = "eticheta";
            this.eticheta.Width = 137;
            // 
            // grosime_linie
            // 
            this.grosime_linie.Text = "grosime_linie";
            this.grosime_linie.Width = 113;
            // 
            // salvareSerializareToolStripMenuItem
            // 
            this.salvareSerializareToolStripMenuItem.Name = "salvareSerializareToolStripMenuItem";
            this.salvareSerializareToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.salvareSerializareToolStripMenuItem.Text = "Salvare (Serializare)";
            this.salvareSerializareToolStripMenuItem.Click += new System.EventHandler(this.salvareSerializareToolStripMenuItem_Click);
            // 
            // restaurareDeserializareToolStripMenuItem
            // 
            this.restaurareDeserializareToolStripMenuItem.Name = "restaurareDeserializareToolStripMenuItem";
            this.restaurareDeserializareToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.restaurareDeserializareToolStripMenuItem.Text = "Restaurare (Deserializare)";
            this.restaurareDeserializareToolStripMenuItem.Click += new System.EventHandler(this.restaurareDeserializareToolStripMenuItem_Click);
            // 
            // desenToolStripMenuItem
            // 
            this.desenToolStripMenuItem.Name = "desenToolStripMenuItem";
            this.desenToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.desenToolStripMenuItem.Text = "Desen";
            this.desenToolStripMenuItem.Click += new System.EventHandler(this.desenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewPoligoane);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem insereazaToolStripMenuItem;
        private System.Windows.Forms.ListView listViewPoligoane;
        private System.Windows.Forms.ColumnHeader cod_figura;
        private System.Windows.Forms.ColumnHeader eticheta;
        private System.Windows.Forms.ColumnHeader grosime_linie;
        private System.Windows.Forms.ToolStripMenuItem salvareSerializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareDeserializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desenToolStripMenuItem;
    }
}

