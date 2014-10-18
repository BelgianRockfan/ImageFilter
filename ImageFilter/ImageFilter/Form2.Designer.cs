namespace ImageFilter
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nmrX = new System.Windows.Forms.NumericUpDown();
            this.nmrY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmrX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(112, 86);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(193, 86);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nmrX
            // 
            this.nmrX.Location = new System.Drawing.Point(37, 40);
            this.nmrX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrX.Name = "nmrX";
            this.nmrX.Size = new System.Drawing.Size(84, 20);
            this.nmrX.TabIndex = 5;
            // 
            // nmrY
            // 
            this.nmrY.Location = new System.Drawing.Point(147, 40);
            this.nmrY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrY.Name = "nmrY";
            this.nmrY.Size = new System.Drawing.Size(82, 20);
            this.nmrY.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 121);
            this.Controls.Add(this.nmrY);
            this.Controls.Add(this.nmrX);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Image Filter";
            ((System.ComponentModel.ISupportInitialize)(this.nmrX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nmrX;
        private System.Windows.Forms.NumericUpDown nmrY;
    }
}