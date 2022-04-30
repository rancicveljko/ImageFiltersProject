
namespace ImageFilters
{
    partial class CropHistogramParametersForm
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
            this.numT = new System.Windows.Forms.NumericUpDown();
            this.numC = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetParams = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "T:";
            // 
            // numT
            // 
            this.numT.Location = new System.Drawing.Point(84, 12);
            this.numT.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numT.Name = "numT";
            this.numT.Size = new System.Drawing.Size(120, 22);
            this.numT.TabIndex = 1;
            // 
            // numC
            // 
            this.numC.Location = new System.Drawing.Point(84, 56);
            this.numC.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numC.Name = "numC";
            this.numC.Size = new System.Drawing.Size(120, 22);
            this.numC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "C:";
            // 
            // btnSetParams
            // 
            this.btnSetParams.Location = new System.Drawing.Point(13, 100);
            this.btnSetParams.Name = "btnSetParams";
            this.btnSetParams.Size = new System.Drawing.Size(127, 34);
            this.btnSetParams.TabIndex = 4;
            this.btnSetParams.Text = "Set parameters";
            this.btnSetParams.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(155, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 34);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CropHistogramParametersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 155);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSetParams);
            this.Controls.Add(this.numC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numT);
            this.Controls.Add(this.label1);
            this.Name = "CropHistogramParametersForm";
            this.Text = "CropHistogramParametersForm";
            ((System.ComponentModel.ISupportInitialize)(this.numT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numT;
        private System.Windows.Forms.NumericUpDown numC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSetParams;
        private System.Windows.Forms.Button btnCancel;
    }
}