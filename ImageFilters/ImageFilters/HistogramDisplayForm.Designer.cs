
namespace ImageFilters
{
    partial class HistogramDisplayForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pbSrcBmp = new System.Windows.Forms.PictureBox();
            this.chartB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cropHistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbSrcBmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartR)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSrcBmp
            // 
            this.pbSrcBmp.Location = new System.Drawing.Point(12, 31);
            this.pbSrcBmp.Name = "pbSrcBmp";
            this.pbSrcBmp.Size = new System.Drawing.Size(100, 50);
            this.pbSrcBmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSrcBmp.TabIndex = 0;
            this.pbSrcBmp.TabStop = false;
            // 
            // chartB
            // 
            chartArea1.Name = "ChartArea1";
            this.chartB.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartB.Legends.Add(legend1);
            this.chartB.Location = new System.Drawing.Point(416, 234);
            this.chartB.Name = "chartB";
            this.chartB.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartB.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "B Channel Values";
            this.chartB.Series.Add(series1);
            this.chartB.Size = new System.Drawing.Size(372, 204);
            this.chartB.TabIndex = 9;
            this.chartB.Text = "chart3";
            // 
            // chartG
            // 
            chartArea2.Name = "ChartArea1";
            this.chartG.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartG.Legends.Add(legend2);
            this.chartG.Location = new System.Drawing.Point(12, 234);
            this.chartG.Name = "chartG";
            this.chartG.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartG.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Lime};
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "G Channel Values";
            this.chartG.Series.Add(series2);
            this.chartG.Size = new System.Drawing.Size(372, 204);
            this.chartG.TabIndex = 8;
            this.chartG.Text = "chart2";
            // 
            // chartR
            // 
            chartArea3.Name = "ChartArea1";
            this.chartR.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartR.Legends.Add(legend3);
            this.chartR.Location = new System.Drawing.Point(416, 12);
            this.chartR.Name = "chartR";
            this.chartR.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartR.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "R Channel Values";
            this.chartR.Series.Add(series3);
            this.chartR.Size = new System.Drawing.Size(372, 204);
            this.chartR.TabIndex = 7;
            this.chartR.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cropHistogramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cropHistogramToolStripMenuItem
            // 
            this.cropHistogramToolStripMenuItem.Name = "cropHistogramToolStripMenuItem";
            this.cropHistogramToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.cropHistogramToolStripMenuItem.Text = "Crop Histogram";
            this.cropHistogramToolStripMenuItem.Click += new System.EventHandler(this.cropHistogramToolStripMenuItem_Click);
            // 
            // HistogramDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartB);
            this.Controls.Add(this.chartG);
            this.Controls.Add(this.chartR);
            this.Controls.Add(this.pbSrcBmp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HistogramDisplayForm";
            this.Text = "HistogramDisplayForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HistogramDisplayForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbSrcBmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartR)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSrcBmp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartR;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cropHistogramToolStripMenuItem;
    }
}