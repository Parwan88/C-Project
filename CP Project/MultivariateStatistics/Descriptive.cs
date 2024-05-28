using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;

namespace MultivariateStatistics
{
    public partial class Descriptive : Form
    {
        public Descriptive()
        {
            InitializeComponent();
        }


        public void SetVariables(string[] variables)
        {
            VariableList.Items.Clear(); 
            foreach (string var in variables)
            {
                VariableList.Items.Add(var); 
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
                this.DialogResult = DialogResult.OK; 
                this.Close(); 
            
        }

        public string[] SelectedVariables
        {
            get { return Variable.Items.Cast<string>().ToArray(); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (var item in VariableList.SelectedItems)
            {
                Variable.Items.Add(item);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var itemsToRemove = Variable.SelectedItems.Cast<string>().ToList();
            foreach (var item in itemsToRemove)
            {
                Variable.Items.Remove(item);
            }
        }
    }
}
