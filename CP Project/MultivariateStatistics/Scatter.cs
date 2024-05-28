using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultivariateStatistics
{
    public partial class Scatter : Form
    {
        public Scatter()
        {
            InitializeComponent();
        }

        public void SetVariables(string[] variables)
        {
            lstAllVariables.Items.Clear();
            foreach (var variable in variables)
            {
                lstAllVariables.Items.Add(variable);
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (lstAllVariables.SelectedItem != null)
            {
                // Clear the X variables ListBox before adding the new selection
                lstXVariables.Items.Clear();
                lstXVariables.Items.Add(lstAllVariables.SelectedItem);
                // Optionally remove the selected item from lstAllVariables to prevent re-selection
                lstAllVariables.Items.Remove(lstAllVariables.SelectedItem);
            }
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            if (lstAllVariables.SelectedItem != null)
            {
                // Clear the Y variables ListBox before adding the new selection
                lstYVariables.Items.Clear();
                lstYVariables.Items.Add(lstAllVariables.SelectedItem);
                // Optionally remove the selected item from lstAllVariables to prevent re-selection
                lstAllVariables.Items.Remove(lstAllVariables.SelectedItem);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lstXVariables.Items.Count == 0 || lstYVariables.Items.Count == 0)
            {
                MessageBox.Show("Please select one variable for X and one for Y.");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public string SelectedXVariable
        {
            get { return lstXVariables.Items.Count > 0 ? lstXVariables.Items[0].ToString() : null; }
        }

        public string SelectedYVariable
        {
            get { return lstYVariables.Items.Count > 0 ? lstYVariables.Items[0].ToString() : null; }
        }
    }
}
