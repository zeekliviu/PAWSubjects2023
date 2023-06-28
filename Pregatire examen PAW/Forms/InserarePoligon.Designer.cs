namespace Pregatire_examen_PAW.Forms
{
    partial class coordonateTxtBox
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
            this.nrPuncteTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nrpLabel = new System.Windows.Forms.Label();
            this.puncteTxtBox = new System.Windows.Forms.TextBox();
            this.grosimeLbl = new System.Windows.Forms.Label();
            this.thicknessNDD = new System.Windows.Forms.NumericUpDown();
            this.colorCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessNDD)).BeginInit();
            this.SuspendLayout();
            // 
            // nrPuncteTxtBox
            // 
            this.nrPuncteTxtBox.Location = new System.Drawing.Point(116, 33);
            this.nrPuncteTxtBox.Name = "nrPuncteTxtBox";
            this.nrPuncteTxtBox.Size = new System.Drawing.Size(211, 20);
            this.nrPuncteTxtBox.TabIndex = 0;
            this.nrPuncteTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nr. puncte";
            // 
            // nrpLabel
            // 
            this.nrpLabel.AutoSize = true;
            this.nrpLabel.Location = new System.Drawing.Point(12, 83);
            this.nrpLabel.Name = "nrpLabel";
            this.nrpLabel.Size = new System.Drawing.Size(35, 13);
            this.nrpLabel.TabIndex = 2;
            this.nrpLabel.Text = "label2";
            // 
            // puncteTxtBox
            // 
            this.puncteTxtBox.Location = new System.Drawing.Point(27, 135);
            this.puncteTxtBox.Multiline = true;
            this.puncteTxtBox.Name = "puncteTxtBox";
            this.puncteTxtBox.Size = new System.Drawing.Size(300, 177);
            this.puncteTxtBox.TabIndex = 3;
            // 
            // grosimeLbl
            // 
            this.grosimeLbl.AutoSize = true;
            this.grosimeLbl.Location = new System.Drawing.Point(24, 339);
            this.grosimeLbl.Name = "grosimeLbl";
            this.grosimeLbl.Size = new System.Drawing.Size(45, 13);
            this.grosimeLbl.TabIndex = 4;
            this.grosimeLbl.Text = "Grosime";
            // 
            // thicknessNDD
            // 
            this.thicknessNDD.DecimalPlaces = 1;
            this.thicknessNDD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.thicknessNDD.Location = new System.Drawing.Point(88, 337);
            this.thicknessNDD.Name = "thicknessNDD";
            this.thicknessNDD.Size = new System.Drawing.Size(120, 20);
            this.thicknessNDD.TabIndex = 5;
            // 
            // colorCb
            // 
            this.colorCb.FormattingEnabled = true;
            this.colorCb.Location = new System.Drawing.Point(87, 393);
            this.colorCb.Name = "colorCb";
            this.colorCb.Size = new System.Drawing.Size(121, 21);
            this.colorCb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Culoare";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(224, 337);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(117, 77);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Adauga Poligon";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // coordonateTxtBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 450);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colorCb);
            this.Controls.Add(this.thicknessNDD);
            this.Controls.Add(this.grosimeLbl);
            this.Controls.Add(this.puncteTxtBox);
            this.Controls.Add(this.nrpLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nrPuncteTxtBox);
            this.Name = "coordonateTxtBox";
            this.Text = "InserarePoligon";
            ((System.ComponentModel.ISupportInitialize)(this.thicknessNDD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nrPuncteTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nrpLabel;
        private System.Windows.Forms.TextBox puncteTxtBox;
        private System.Windows.Forms.Label grosimeLbl;
        private System.Windows.Forms.NumericUpDown thicknessNDD;
        private System.Windows.Forms.ComboBox colorCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBtn;
    }
}