namespace MultivariateStatistics
{
    partial class Linear
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
            this.btnAddX = new System.Windows.Forms.Button();
            this.btnAddY = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAllVariables
            // 
            this.lstAllVariables.FormattingEnabled = true;
            this.lstAllVariables.ItemHeight = 20;
            this.lstAllVariables.Location = new System.Drawing.Point(47, 42);
            this.lstAllVariables.Name = "lstAllVariables";
            this.lstAllVariables.Size = new System.Drawing.Size(186, 324);
            this.lstAllVariables.TabIndex = 0;
            // 
            // lstXVariables
            // 
            this.lstXVariables.FormattingEnabled = true;
            this.lstXVariables.ItemHeight = 20;
            this.lstXVariables.Location = new System.Drawing.Point(406, 117);
            this.lstXVariables.Name = "lstXVariables";
            this.lstXVariables.Size = new System.Drawing.Size(258, 44);
            this.lstXVariables.TabIndex = 1;
            // 
            // lstYVariables
            // 
            this.lstYVariables.FormattingEnabled = true;
            this.lstYVariables.ItemHeight = 20;
            this.lstYVariables.Location = new System.Drawing.Point(406, 207);
            this.lstYVariables.Name = "lstYVariables";
            this.lstYVariables.Size = new System.Drawing.Size(258, 44);
            this.lstYVariables.TabIndex = 2;
            // 
            // btnAddX
            // 
            this.btnAddX.Location = new System.Drawing.Point(278, 117);
            this.btnAddX.Name = "btnAddX";
            this.btnAddX.Size = new System.Drawing.Size(75, 44);
            this.btnAddX.TabIndex = 3;
            this.btnAddX.Text = ">>>";
            this.btnAddX.UseVisualStyleBackColor = true;
            this.btnAddX.Click += new System.EventHandler(this.btnAddX_Click);
            // 
            // btnAddY
            // 
            this.btnAddY.Location = new System.Drawing.Point(278, 207);
            this.btnAddY.Name = "btnAddY";
            this.btnAddY.Size = new System.Drawing.Size(75, 44);
            this.btnAddY.TabIndex = 4;
            this.btnAddY.Text = ">>>";
            this.btnAddY.UseVisualStyleBackColor = true;
            this.btnAddY.Click += new System.EventHandler(this.btnAddY_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(483, 297);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 40);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Linear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAddY);
            this.Controls.Add(this.btnAddX);
            this.Controls.Add(this.lstYVariables);
            this.Controls.Add(this.lstXVariables);
            this.Controls.Add(this.lstAllVariables);
            this.Name = "Linear";
            this.Text = "Linear";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAllVariables;
        private System.Windows.Forms.Button btnAddX;
        private System.Windows.Forms.Button btnAddY;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.ListBox lstXVariables;
        public System.Windows.Forms.ListBox lstYVariables;
    }
}