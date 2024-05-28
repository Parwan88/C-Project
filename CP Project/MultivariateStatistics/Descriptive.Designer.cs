namespace MultivariateStatistics
{
    partial class Descriptive
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
            this.VariableList = new System.Windows.Forms.ListBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.Variable = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VariableList
            // 
            this.VariableList.FormattingEnabled = true;
            this.VariableList.Location = new System.Drawing.Point(27, 44);
            this.VariableList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VariableList.Name = "VariableList";
            this.VariableList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.VariableList.Size = new System.Drawing.Size(68, 394);
            this.VariableList.TabIndex = 3;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(385, 450);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(63, 31);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Variable
            // 
            this.Variable.FormattingEnabled = true;
            this.Variable.Location = new System.Drawing.Point(332, 77);
            this.Variable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Variable.Name = "Variable";
            this.Variable.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Variable.Size = new System.Drawing.Size(105, 251);
            this.Variable.TabIndex = 5;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(176, 103);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(71, 74);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Select ->";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(176, 208);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 66);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete <-";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Descriptive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 536);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.Variable);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.VariableList);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Descriptive";
            this.Text = "Descriptive";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox VariableList;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ListBox Variable;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDelete;
    }
}