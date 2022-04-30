
namespace MMSProject
{
    partial class ChannelsDisplayForm
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
            this.pbSrcBmp = new System.Windows.Forms.PictureBox();
            this.pbEdit1Bmp = new System.Windows.Forms.PictureBox();
            this.pbEdit2Bmp = new System.Windows.Forms.PictureBox();
            this.pbEdit3Bmp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSrcBmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit1Bmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit2Bmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit3Bmp)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSrcBmp
            // 
            this.pbSrcBmp.Location = new System.Drawing.Point(13, 10);
            this.pbSrcBmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSrcBmp.Name = "pbSrcBmp";
            this.pbSrcBmp.Size = new System.Drawing.Size(125, 62);
            this.pbSrcBmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSrcBmp.TabIndex = 0;
            this.pbSrcBmp.TabStop = false;
            // 
            // pbEdit1Bmp
            // 
            this.pbEdit1Bmp.Location = new System.Drawing.Point(233, 26);
            this.pbEdit1Bmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbEdit1Bmp.Name = "pbEdit1Bmp";
            this.pbEdit1Bmp.Size = new System.Drawing.Size(125, 62);
            this.pbEdit1Bmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEdit1Bmp.TabIndex = 1;
            this.pbEdit1Bmp.TabStop = false;
            // 
            // pbEdit2Bmp
            // 
            this.pbEdit2Bmp.Location = new System.Drawing.Point(48, 137);
            this.pbEdit2Bmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbEdit2Bmp.Name = "pbEdit2Bmp";
            this.pbEdit2Bmp.Size = new System.Drawing.Size(125, 62);
            this.pbEdit2Bmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEdit2Bmp.TabIndex = 2;
            this.pbEdit2Bmp.TabStop = false;
            // 
            // pbEdit3Bmp
            // 
            this.pbEdit3Bmp.Location = new System.Drawing.Point(325, 145);
            this.pbEdit3Bmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbEdit3Bmp.Name = "pbEdit3Bmp";
            this.pbEdit3Bmp.Size = new System.Drawing.Size(125, 62);
            this.pbEdit3Bmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEdit3Bmp.TabIndex = 3;
            this.pbEdit3Bmp.TabStop = false;
            // 
            // ChannelsDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 482);
            this.Controls.Add(this.pbEdit3Bmp);
            this.Controls.Add(this.pbEdit2Bmp);
            this.Controls.Add(this.pbEdit1Bmp);
            this.Controls.Add(this.pbSrcBmp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChannelsDisplayForm";
            this.Text = "ChannelsDisplayForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ChannelsDisplayForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbSrcBmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit1Bmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit2Bmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit3Bmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSrcBmp;
        private System.Windows.Forms.PictureBox pbEdit1Bmp;
        private System.Windows.Forms.PictureBox pbEdit2Bmp;
        private System.Windows.Forms.PictureBox pbEdit3Bmp;
    }
}