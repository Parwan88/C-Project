namespace MultivariateStatistics
{
    partial class Scatter
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
            this.lstAllVariables = new System.Windows.Forms.ListBox();
            this.lstXVariables = new System.Windows.Forms.ListBox();
            this.lstYVariables = new System.Windows.Forms.ListBox();
            this.btnX = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAllVariables
            // 
            this.lstAllVariables.FormattingEnabled = true;
            this.lstAllVariables.ItemHeight = 20;
            this.lstAllVariables.Location = new System.Drawing.Point(43, 46);
            this.lstAllVariables.Name = "lstAllVariables";
            this.lstAllVariables.Size = new System.Drawing.Size(125, 304);
            this.lstAllVariables.TabIndex = 0;
            // 
            // lstXVariables
            // 
            this.lstXVariables.FormattingEnabled = true;
            this.lstXVariables.ItemHeight = 20;
            this.lstXVariables.Location = new System.Drawing.Point(430, 106);
            this.lstXVariables.Name = "lstXVariables";
            this.lstXVariables.Size = new System.Drawing.Size(254, 44);
            this.lstXVariables.TabIndex = 1;
            // 
            // lstYVariables
            // 
            this.lstYVariables.FormattingEnabled = true;
            this.lstYVariables.ItemHeight = 20;
            this.lstYVariables.Location = new System.Drawing.Point(430, 193);
            this.lstYVariables.Name = "lstYVariables";
            this.lstYVariables.Size = new System.Drawing.Size(254, 44);
            this.lstYVariables.TabIndex = 2;
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(241, 106);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(73, 44);
            this.btnX.TabIndex = 3;
            this.btnX.Text = ">>>";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnY
            // 
            this.btnY.Location = new System.Drawing.Point(241, 193);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(73, 44);
            this.btnY.TabIndex = 4;
            this.btnY.Text = ">>>";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(584, 302);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 60);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Scatter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.lstYVariables);
            this.Controls.Add(this.lstXVariables);
            this.Controls.Add(this.lstAllVariables);
            this.Name = "Scatter";
            this.Text = "Scatter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAllVariables;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.ListBox lstXVariables;
        public System.Windows.Forms.ListBox lstYVariables;
    }
}