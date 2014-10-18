namespace ImageFilter
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
            this.brwserInput = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.brwserOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lstDimensions = new System.Windows.Forms.ListBox();
            this.btnAddDmns = new System.Windows.Forms.Button();
            this.btnRemoveDmns = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // brwserInput
            // 
            this.brwserInput.SelectedPath = "C:\\Users\\jeroen\\Pictures";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Input folder...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Output folder...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 75);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(320, 20);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 104);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(320, 20);
            this.txtOutput.TabIndex = 3;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // brwserOutput
            // 
            this.brwserOutput.SelectedPath = "C:\\Users\\jeroen\\Desktop";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(173, 311);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(159, 55);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lstDimensions
            // 
            this.lstDimensions.FormattingEnabled = true;
            this.lstDimensions.Location = new System.Drawing.Point(12, 174);
            this.lstDimensions.Name = "lstDimensions";
            this.lstDimensions.Size = new System.Drawing.Size(134, 121);
            this.lstDimensions.TabIndex = 5;
            // 
            // btnAddDmns
            // 
            this.btnAddDmns.Location = new System.Drawing.Point(153, 174);
            this.btnAddDmns.Name = "btnAddDmns";
            this.btnAddDmns.Size = new System.Drawing.Size(107, 23);
            this.btnAddDmns.TabIndex = 6;
            this.btnAddDmns.Text = "Add Dimension";
            this.btnAddDmns.UseVisualStyleBackColor = true;
            this.btnAddDmns.Click += new System.EventHandler(this.btnAddDmns_Click);
            // 
            // btnRemoveDmns
            // 
            this.btnRemoveDmns.Location = new System.Drawing.Point(153, 204);
            this.btnRemoveDmns.Name = "btnRemoveDmns";
            this.btnRemoveDmns.Size = new System.Drawing.Size(107, 23);
            this.btnRemoveDmns.TabIndex = 7;
            this.btnRemoveDmns.Text = "Remove Dimension";
            this.btnRemoveDmns.UseVisualStyleBackColor = true;
            this.btnRemoveDmns.Click += new System.EventHandler(this.btnRemoveDmns_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dimensions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveDmns);
            this.Controls.Add(this.btnAddDmns);
            this.Controls.Add(this.lstDimensions);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog brwserInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.FolderBrowserDialog brwserOutput;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ListBox lstDimensions;
        private System.Windows.Forms.Button btnAddDmns;
        private System.Windows.Forms.Button btnRemoveDmns;
        private System.Windows.Forms.Label label1;
    }
}

