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
    public partial class Linear : Form
    {
        public Linear()
        {
            InitializeComponent();
        }

        public void SetVariables(string[] variables)
        {
            lstAllVariables.Items.Clear(); // Clear existing items
            foreach (string variable in variables)
            {
                lstAllVariables.Items.Add(variable); 
            }
        }

        private void btnAddX_Click(object sender, EventArgs e)
        {
            var selectedItem = lstAllVariables.SelectedItem;
            if (selectedItem != null && !lstYVariables.Items.Contains(selectedItem))
            {
                lstXVariables.Items.Add(selectedItem);
                lstAllVariables.Items.Remove(selectedItem);

                // Set the last added item as the selected item
                lstXVariables.SelectedIndex = lstXVariables.Items.Count - 1;
            }
        }

        private void btnAddY_Click(object sender, EventArgs e)
        {
            var selectedItem = lstAllVariables.SelectedItem;
            if (selectedItem != null && !lstXVariables.Items.Contains(selectedItem))
            {
                lstYVariables.Items.Add(selectedItem);
                lstAllVariables.Items.Remove(selectedItem);

                // Set the last added item as the selected item
                lstYVariables.SelectedIndex = lstYVariables.Items.Count - 1;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lstXVariables.Items.Count == 0 || lstYVariables.Items.Count == 0)
            {
                MessageBox.Show("Please add at least one variable to both X and Y.");
            }
            else
            {
                this.DialogResult = DialogResult.OK; // Indicate success
                this.Close(); // Close the form
            }
        }

        public string SelectedXVariable
        {
            get { return lstXVariables.SelectedItem?.ToString(); }
        }

        public string SelectedYVariable
        {
            get { return lstYVariables.SelectedItem?.ToString(); }
        }
    }
}
