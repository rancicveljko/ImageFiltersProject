
namespace MMSProject
{
    partial class frmImageFilters
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayChanelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanRemovalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectHomogenityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeWarpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showComparisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleColorizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleColorizeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMethodOfExecutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showConvolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.pbImageDisplay = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crossdomainColorizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.editToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.histogramToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(800, 28);
            this.msMainMenu.TabIndex = 0;
            this.msMainMenu.Text = "msMainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.openToolStripMenuItem.Text = "Load";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayChanelsToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.invertToolStripMenuItem,
            this.meanRemovalToolStripMenuItem,
            this.edgeDetectHomogenityToolStripMenuItem,
            this.timeWarpToolStripMenuItem,
            this.grayscaleToolStripMenuItem,
            this.simpleColorizeToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // displayChanelsToolStripMenuItem
            // 
            this.displayChanelsToolStripMenuItem.Name = "displayChanelsToolStripMenuItem";
            this.displayChanelsToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.displayChanelsToolStripMenuItem.Text = "Display channels";
            this.displayChanelsToolStripMenuItem.Click += new System.EventHandler(this.displayChanelsToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.invertToolStripMenuItem.Text = "Invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // meanRemovalToolStripMenuItem
            // 
            this.meanRemovalToolStripMenuItem.Name = "meanRemovalToolStripMenuItem";
            this.meanRemovalToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.meanRemovalToolStripMenuItem.Text = "Mean Removal";
            this.meanRemovalToolStripMenuItem.Click += new System.EventHandler(this.meanRemovalToolStripMenuItem_Click);
            // 
            // edgeDetectHomogenityToolStripMenuItem
            // 
            this.edgeDetectHomogenityToolStripMenuItem.Name = "edgeDetectHomogenityToolStripMenuItem";
            this.edgeDetectHomogenityToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.edgeDetectHomogenityToolStripMenuItem.Text = "Edge Detect Homogenity";
            this.edgeDetectHomogenityToolStripMenuItem.Click += new System.EventHandler(this.edgeDetectHomogenityToolStripMenuItem_Click);
            // 
            // timeWarpToolStripMenuItem
            // 
            this.timeWarpToolStripMenuItem.Name = "timeWarpToolStripMenuItem";
            this.timeWarpToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.timeWarpToolStripMenuItem.Text = "Time Warp";
            this.timeWarpToolStripMenuItem.Click += new System.EventHandler(this.timeWarpToolStripMenuItem_Click);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageMethodToolStripMenuItem,
            this.maxMethodToolStripMenuItem,
            this.customMethodToolStripMenuItem,
            this.showComparisonToolStripMenuItem});
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            // 
            // averageMethodToolStripMenuItem
            // 
            this.averageMethodToolStripMenuItem.Name = "averageMethodToolStripMenuItem";
            this.averageMethodToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.averageMethodToolStripMenuItem.Text = "Average method";
            this.averageMethodToolStripMenuItem.Click += new System.EventHandler(this.averageMethodToolStripMenuItem_Click);
            // 
            // maxMethodToolStripMenuItem
            // 
            this.maxMethodToolStripMenuItem.Name = "maxMethodToolStripMenuItem";
            this.maxMethodToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.maxMethodToolStripMenuItem.Text = "Max method";
            this.maxMethodToolStripMenuItem.Click += new System.EventHandler(this.maxMethodToolStripMenuItem_Click);
            // 
            // customMethodToolStripMenuItem
            // 
            this.customMethodToolStripMenuItem.Name = "customMethodToolStripMenuItem";
            this.customMethodToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.customMethodToolStripMenuItem.Text = "Custom method";
            this.customMethodToolStripMenuItem.Click += new System.EventHandler(this.customMethodToolStripMenuItem_Click);
            // 
            // showComparisonToolStripMenuItem
            // 
            this.showComparisonToolStripMenuItem.Name = "showComparisonToolStripMenuItem";
            this.showComparisonToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.showComparisonToolStripMenuItem.Text = "Show comparison";
            this.showComparisonToolStripMenuItem.Click += new System.EventHandler(this.showComparisonToolStripMenuItem_Click);
            // 
            // simpleColorizeToolStripMenuItem
            // 
            this.simpleColorizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleColorizeToolStripMenuItem1,
            this.crossdomainColorizeToolStripMenuItem});
            this.simpleColorizeToolStripMenuItem.Name = "simpleColorizeToolStripMenuItem";
            this.simpleColorizeToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.simpleColorizeToolStripMenuItem.Text = "Colorize";
            // 
            // simpleColorizeToolStripMenuItem1
            // 
            this.simpleColorizeToolStripMenuItem1.Name = "simpleColorizeToolStripMenuItem1";
            this.simpleColorizeToolStripMenuItem1.Size = new System.Drawing.Size(243, 26);
            this.simpleColorizeToolStripMenuItem1.Text = "Simple Colorize";
            this.simpleColorizeToolStripMenuItem1.Click += new System.EventHandler(this.simpleColorizeToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMethodOfExecutionToolStripMenuItem,
            this.showConvolutionToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // showMethodOfExecutionToolStripMenuItem
            // 
            this.showMethodOfExecutionToolStripMenuItem.Name = "showMethodOfExecutionToolStripMenuItem";
            this.showMethodOfExecutionToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.showMethodOfExecutionToolStripMenuItem.Text = "Show method of execution";
            this.showMethodOfExecutionToolStripMenuItem.Click += new System.EventHandler(this.showMethodOfExecutionToolStripMenuItem_Click);
            // 
            // showConvolutionToolStripMenuItem
            // 
            this.showConvolutionToolStripMenuItem.Name = "showConvolutionToolStripMenuItem";
            this.showConvolutionToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.showConvolutionToolStripMenuItem.Text = "Show convolution dependency";
            this.showConvolutionToolStripMenuItem.Click += new System.EventHandler(this.showConvolutionToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 242);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbImageDisplay
            // 
            this.pbImageDisplay.Location = new System.Drawing.Point(12, 25);
            this.pbImageDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbImageDisplay.Name = "pbImageDisplay";
            this.pbImageDisplay.Size = new System.Drawing.Size(300, 168);
            this.pbImageDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImageDisplay.TabIndex = 2;
            this.pbImageDisplay.TabStop = false;
            this.pbImageDisplay.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            this.pbImageDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // crossdomainColorizeToolStripMenuItem
            // 
            this.crossdomainColorizeToolStripMenuItem.Name = "crossdomainColorizeToolStripMenuItem";
            this.crossdomainColorizeToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.crossdomainColorizeToolStripMenuItem.Text = "Cross-domain Colorize";
            this.crossdomainColorizeToolStripMenuItem.Click += new System.EventHandler(this.crossdomainColorizeToolStripMenuItem_Click);
            // 
            // frmImageFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImageDisplay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.msMainMenu);
            this.MainMenuStrip = this.msMainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmImageFilters";
            this.Text = "Image Filters";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmImageFilters_Paint);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayChanelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanRemovalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectHomogenityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeWarpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMethodOfExecutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showConvolutionToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleColorizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleColorizeToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pbImageDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showComparisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crossdomainColorizeToolStripMenuItem;
    }
}

