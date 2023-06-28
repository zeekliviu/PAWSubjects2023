namespace Sub4PAW
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
            this.codVTb = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.Label();
            this.descCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.capTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod vagon";
            // 
            // codVTb
            // 
            this.codVTb.Location = new System.Drawing.Point(112, 35);
            this.codVTb.Name = "codVTb";
            this.codVTb.Size = new System.Drawing.Size(100, 20);
            this.codVTb.TabIndex = 1;
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Location = new System.Drawing.Point(28, 102);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(66, 13);
            this.desc.TabIndex = 2;
            this.desc.Text = "Descriere tip";
            // 
            // descCb
            // 
            this.descCb.FormattingEnabled = true;
            this.descCb.Items.AddRange(new object[] {
            "Cereale",
            "Ulei",
            "Carburant",
            "Fructe"});
            this.descCb.Location = new System.Drawing.Point(112, 99);
            this.descCb.Name = "descCb";
            this.descCb.Size = new System.Drawing.Size(100, 21);
            this.descCb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Capacitate";
            // 
            // capTb
            // 
            this.capTb.Location = new System.Drawing.Point(112, 171);
            this.capTb.Name = "capTb";
            this.capTb.Size = new System.Drawing.Size(100, 20);
            this.capTb.TabIndex = 5;
            this.capTb.Validating += new System.ComponentModel.CancelEventHandler(this.capTb_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
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
            this.ClientSize = new System.Drawing.Size(280, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.capTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descCb);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.codVTb);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codVTb;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.ComboBox descCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox capTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}