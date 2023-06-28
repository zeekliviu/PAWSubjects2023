namespace Sub7PAW
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
            this.adaugaPizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.citireToppinguriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficUtilizareToppinguriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaPizzaToolStripMenuItem,
            this.citireToolStripMenuItem,
            this.citireToppinguriToolStripMenuItem,
            this.graficUtilizareToppinguriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(465, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adaugaPizzaToolStripMenuItem
            // 
            this.adaugaPizzaToolStripMenuItem.Name = "adaugaPizzaToolStripMenuItem";
            this.adaugaPizzaToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.adaugaPizzaToolStripMenuItem.Text = "Adauga pizza";
            this.adaugaPizzaToolStripMenuItem.Click += new System.EventHandler(this.adaugaPizzaToolStripMenuItem_Click);
            // 
            // citireToolStripMenuItem
            // 
            this.citireToolStripMenuItem.Name = "citireToolStripMenuItem";
            this.citireToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.citireToolStripMenuItem.Text = "Citire pizze";
            this.citireToolStripMenuItem.Click += new System.EventHandler(this.citireToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(38, 48);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(394, 301);
            this.treeView1.TabIndex = 1;
            // 
            // citireToppinguriToolStripMenuItem
            // 
            this.citireToppinguriToolStripMenuItem.Name = "citireToppinguriToolStripMenuItem";
            this.citireToppinguriToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.citireToppinguriToolStripMenuItem.Text = "Adaugare topping-uri";
            this.citireToppinguriToolStripMenuItem.Click += new System.EventHandler(this.citireToppinguriToolStripMenuItem_Click);
            // 
            // graficUtilizareToppinguriToolStripMenuItem
            // 
            this.graficUtilizareToppinguriToolStripMenuItem.Name = "graficUtilizareToppinguriToolStripMenuItem";
            this.graficUtilizareToppinguriToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.graficUtilizareToppinguriToolStripMenuItem.Text = "Grafic utilizare topping-uri";
            this.graficUtilizareToppinguriToolStripMenuItem.Click += new System.EventHandler(this.graficUtilizareToppinguriToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 372);
            this.Controls.Add(this.treeView1);
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
        private System.Windows.Forms.ToolStripMenuItem adaugaPizzaToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem citireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citireToppinguriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficUtilizareToppinguriToolStripMenuItem;
    }
}

