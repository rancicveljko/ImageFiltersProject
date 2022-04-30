
namespace MMSProject
{
    partial class ColorFilterParameters
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSetColorFilterParams = new System.Windows.Forms.Button();
            this.numRValue = new System.Windows.Forms.NumericUpDown();
            this.numGValue = new System.Windows.Forms.NumericUpDown();
            this.numBValue = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "B";
            // 
            // btnSetColorFilterParams
            // 
            this.btnSetColorFilterParams.Location = new System.Drawing.Point(24, 190);
            this.btnSetColorFilterParams.Name = "btnSetColorFilterParams";
            this.btnSetColorFilterParams.Size = new System.Drawing.Size(136, 29);
            this.btnSetColorFilterParams.TabIndex = 6;
            this.btnSetColorFilterParams.Text = "Set parameters";
            this.btnSetColorFilterParams.UseVisualStyleBackColor = true;
            this.btnSetColorFilterParams.Click += new System.EventHandler(this.btnSetColorFilterParams_Click);
            // 
            // numRValue
            // 
            this.numRValue.Location = new System.Drawing.Point(110, 28);
            this.numRValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRValue.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.numRValue.Name = "numRValue";
            this.numRValue.Size = new System.Drawing.Size(150, 27);
            this.numRValue.TabIndex = 7;
            // 
            // numGValue
            // 
            this.numGValue.Location = new System.Drawing.Point(110, 80);
            this.numGValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numGValue.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.numGValue.Name = "numGValue";
            this.numGValue.Size = new System.Drawing.Size(150, 27);
            this.numGValue.TabIndex = 8;
            // 
            // numBValue
            // 
            this.numBValue.Location = new System.Drawing.Point(110, 128);
            this.numBValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBValue.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.numBValue.Name = "numBValue";
            this.numBValue.Size = new System.Drawing.Size(150, 27);
            this.numBValue.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(201, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ColorFilterParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 249);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.numBValue);
            this.Controls.Add(this.numGValue);
            this.Controls.Add(this.numRValue);
            this.Controls.Add(this.btnSetColorFilterParams);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ColorFilterParameters";
            this.Text = "ColorFilterParameters";
            this.Load += new System.EventHandler(this.ColorFilterParameters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetColorFilterParams;
        private System.Windows.Forms.NumericUpDown numRValue;
        private System.Windows.Forms.NumericUpDown numGValue;
        private System.Windows.Forms.NumericUpDown numBValue;
        private System.Windows.Forms.Button btnCancel;
    }
}