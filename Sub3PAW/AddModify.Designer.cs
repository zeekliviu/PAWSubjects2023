namespace Sub3PAW
{
    partial class AddModify
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
            this.numeTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nrOreTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salariuTb = new System.Windows.Forms.TextBox();
            this.marcaTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addmodBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numeTb
            // 
            this.numeTb.Location = new System.Drawing.Point(106, 37);
            this.numeTb.Name = "numeTb";
            this.numeTb.Size = new System.Drawing.Size(226, 20);
            this.numeTb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nr. ore";
            // 
            // nrOreTb
            // 
            this.nrOreTb.Location = new System.Drawing.Point(106, 99);
            this.nrOreTb.Name = "nrOreTb";
            this.nrOreTb.Size = new System.Drawing.Size(226, 20);
            this.nrOreTb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salariu";
            // 
            // salariuTb
            // 
            this.salariuTb.Location = new System.Drawing.Point(106, 165);
            this.salariuTb.Name = "salariuTb";
            this.salariuTb.Size = new System.Drawing.Size(226, 20);
            this.salariuTb.TabIndex = 5;
            // 
            // marcaTb
            // 
            this.marcaTb.Location = new System.Drawing.Point(106, 233);
            this.marcaTb.Name = "marcaTb";
            this.marcaTb.Size = new System.Drawing.Size(226, 20);
            this.marcaTb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Marca";
            // 
            // addmodBtn
            // 
            this.addmodBtn.Location = new System.Drawing.Point(32, 302);
            this.addmodBtn.Name = "addmodBtn";
            this.addmodBtn.Size = new System.Drawing.Size(322, 123);
            this.addmodBtn.TabIndex = 8;
            this.addmodBtn.Text = "Adauga / Modifica";
            this.addmodBtn.UseVisualStyleBackColor = true;
            this.addmodBtn.Click += new System.EventHandler(this.addmodBtn_Click);
            // 
            // AddModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.addmodBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.marcaTb);
            this.Controls.Add(this.salariuTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nrOreTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeTb);
            this.Name = "AddModify";
            this.Text = "AddModify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numeTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nrOreTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox salariuTb;
        private System.Windows.Forms.TextBox marcaTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addmodBtn;
    }
}