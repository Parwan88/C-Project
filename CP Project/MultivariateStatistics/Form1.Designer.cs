namespace MultivariateStatistics
{
    partial class FrmMain
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
            this.tcStat = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.txtStat = new System.Windows.Forms.TextBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptiveStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correlationCoefficientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearRegressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scatterPlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxScatterPlot = new System.Windows.Forms.PictureBox();
            this.tcStat.SuspendLayout();
            this.tp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tp2.SuspendLayout();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScatterPlot)).BeginInit();
            this.SuspendLayout();
            // 
            // tcStat
            // 
            this.tcStat.Controls.Add(this.tp1);
            this.tcStat.Controls.Add(this.tp2);
            this.tcStat.Location = new System.Drawing.Point(3, 41);
            this.tcStat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tcStat.Name = "tcStat";
            this.tcStat.SelectedIndex = 0;
            this.tcStat.Size = new System.Drawing.Size(2018, 1055);
            this.tcStat.TabIndex = 0;
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.dgvData);
            this.tp1.Location = new System.Drawing.Point(4, 29);
            this.tp1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tp1.Size = new System.Drawing.Size(2010, 1022);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "Data";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(4, 9);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 102;
            this.dgvData.Size = new System.Drawing.Size(1996, 988);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellValueChanged);
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.pictureBoxScatterPlot);
            this.tp2.Controls.Add(this.txtStat);
            this.tp2.Location = new System.Drawing.Point(4, 29);
            this.tp2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tp2.Size = new System.Drawing.Size(2010, 1022);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "Result";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // txtStat
            // 
            this.txtStat.Location = new System.Drawing.Point(6, 11);
            this.txtStat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStat.Multiline = true;
            this.txtStat.Name = "txtStat";
            this.txtStat.Size = new System.Drawing.Size(1993, 1013);
            this.txtStat.TabIndex = 0;
            // 
            // mnuMain
            // 
            this.mnuMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.analysisToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1082, 33);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(153, 34);
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 34);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descriptiveStatisticsToolStripMenuItem,
            this.correlationCoefficientToolStripMenuItem,
            this.linearRegressionToolStripMenuItem,
            this.scatterPlotToolStripMenuItem});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.analysisToolStripMenuItem.Text = "Analysis";
            // 
            // descriptiveStatisticsToolStripMenuItem
            // 
            this.descriptiveStatisticsToolStripMenuItem.Name = "descriptiveStatisticsToolStripMenuItem";
            this.descriptiveStatisticsToolStripMenuItem.Size = new System.Drawing.Size(290, 34);
            this.descriptiveStatisticsToolStripMenuItem.Text = "Descriptive Statistics";
            this.descriptiveStatisticsToolStripMenuItem.Click += new System.EventHandler(this.descriptiveStatisticsToolStripMenuItem_Click);
            // 
            // correlationCoefficientToolStripMenuItem
            // 
            this.correlationCoefficientToolStripMenuItem.Name = "correlationCoefficientToolStripMenuItem";
            this.correlationCoefficientToolStripMenuItem.Size = new System.Drawing.Size(290, 34);
            this.correlationCoefficientToolStripMenuItem.Text = "Correlation Coefficient";
            this.correlationCoefficientToolStripMenuItem.Click += new System.EventHandler(this.correlationCoefficientToolStripMenuItem_Click);
            // 
            // linearRegressionToolStripMenuItem
            // 
            this.linearRegressionToolStripMenuItem.Name = "linearRegressionToolStripMenuItem";
            this.linearRegressionToolStripMenuItem.Size = new System.Drawing.Size(290, 34);
            this.linearRegressionToolStripMenuItem.Text = "Linear Regression";
            this.linearRegressionToolStripMenuItem.Click += new System.EventHandler(this.linearRegressionToolStripMenuItem_Click);
            // 
            // scatterPlotToolStripMenuItem
            // 
            this.scatterPlotToolStripMenuItem.Name = "scatterPlotToolStripMenuItem";
            this.scatterPlotToolStripMenuItem.Size = new System.Drawing.Size(290, 34);
            this.scatterPlotToolStripMenuItem.Text = "Scatter Plot";
            this.scatterPlotToolStripMenuItem.Click += new System.EventHandler(this.scatterPlotToolStripMenuItem_Click);
            // 
            // pictureBoxScatterPlot
            // 
            this.pictureBoxScatterPlot.Location = new System.Drawing.Point(105, 53);
            this.pictureBoxScatterPlot.Name = "pictureBoxScatterPlot";
            this.pictureBoxScatterPlot.Size = new System.Drawing.Size(796, 434);
            this.pictureBoxScatterPlot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxScatterPlot.TabIndex = 1;
            this.pictureBoxScatterPlot.TabStop = false;
            this.pictureBoxScatterPlot.Click += new System.EventHandler(this.pictureBoxScatterPlot_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 677);
            this.Controls.Add(this.tcStat);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Multivariate Statistics Toolkit";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tcStat.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tp2.ResumeLayout(false);
            this.tp2.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScatterPlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcStat;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.TextBox txtStat;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descriptiveStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correlationCoefficientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linearRegressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scatterPlotToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxScatterPlot;
    }
}

