namespace BicicleteCiureaByZeek
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.codUTb = new System.Windows.Forms.TextBox();
            this.numeTb = new System.Windows.Forms.TextBox();
            this.codBTb = new System.Windows.Forms.TextBox();
            this.durataTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod utilizator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cod bicicleta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Durata utilizare";
            // 
            // codUTb
            // 
            this.codUTb.Location = new System.Drawing.Point(152, 31);
            this.codUTb.Name = "codUTb";
            this.codUTb.ReadOnly = true;
            this.codUTb.Size = new System.Drawing.Size(100, 20);
            this.codUTb.TabIndex = 4;
            // 
            // numeTb
            // 
            this.numeTb.Location = new System.Drawing.Point(152, 84);
            this.numeTb.Name = "numeTb";
            this.numeTb.Size = new System.Drawing.Size(100, 20);
            this.numeTb.TabIndex = 5;
            // 
            // codBTb
            // 
            this.codBTb.Location = new System.Drawing.Point(152, 132);
            this.codBTb.Name = "codBTb";
            this.codBTb.Size = new System.Drawing.Size(100, 20);
            this.codBTb.TabIndex = 6;
            // 
            // durataTb
            // 
            this.durataTb.Location = new System.Drawing.Point(152, 173);
            this.durataTb.Name = "durataTb";
            this.durataTb.Size = new System.Drawing.Size(100, 20);
            this.durataTb.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Trimite";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 284);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.durataTb);
            this.Controls.Add(this.codBTb);
            this.Controls.Add(this.numeTb);
            this.Controls.Add(this.codUTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codUTb;
        private System.Windows.Forms.TextBox numeTb;
        private System.Windows.Forms.TextBox codBTb;
        private System.Windows.Forms.TextBox durataTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}