namespace BasicCalculator_Mark
{
    partial class FrmBasicCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.TextBox();
            this.cbOperators = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelShowTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(25, 57);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(179, 20);
            this.x.TabIndex = 1;
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(25, 132);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(179, 20);
            this.y.TabIndex = 2;
            // 
            // cbOperators
            // 
            this.cbOperators.FormattingEnabled = true;
            this.cbOperators.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbOperators.Location = new System.Drawing.Point(53, 93);
            this.cbOperators.Name = "cbOperators";
            this.cbOperators.Size = new System.Drawing.Size(121, 21);
            this.cbOperators.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox1.Location = new System.Drawing.Point(12, 158);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(215, 77);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCompute.Location = new System.Drawing.Point(53, 254);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(128, 23);
            this.btnCompute.TabIndex = 5;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(20, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total:";
            // 
            // LabelShowTotal
            // 
            this.LabelShowTotal.AutoSize = true;
            this.LabelShowTotal.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LabelShowTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShowTotal.ForeColor = System.Drawing.Color.Green;
            this.LabelShowTotal.Location = new System.Drawing.Point(21, 198);
            this.LabelShowTotal.Name = "LabelShowTotal";
            this.LabelShowTotal.Size = new System.Drawing.Size(45, 19);
            this.LabelShowTotal.TabIndex = 7;
            this.LabelShowTotal.Text = "0000";
            // 
            // FrmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(239, 289);
            this.Controls.Add(this.LabelShowTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cbOperators);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmBasicCalculator";
            this.Text = "FrmBasicCalculator";
            this.Load += new System.EventHandler(this.FrmBasicCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.ComboBox cbOperators;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelShowTotal;
    }
}

