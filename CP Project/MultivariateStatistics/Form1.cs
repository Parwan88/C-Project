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

namespace MultivariateStatistics
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        string[] lines;
        string[] colnames;
        string[][] strValues;
        double[][] dblValues;
        string fileName;

        private static FrmMain instance = null;

        public static FrmMain Instance
        {
            get
            {
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private void correlationCoefficientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count == 0)
            {
                string q = "No data is loaded. Load data?";
                MessageBoxButtons b = MessageBoxButtons.YesNo;
                DialogResult r = MessageBox.Show(q, "Missing Data", b);
                if (r == DialogResult.Yes)
                    LoadData();
            }
            else
            {
                FrmCoef.Instance = new FrmCoef();
                FrmCoef.Instance.GetVList(colnames);
                FrmCoef.Instance.Show();
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            int c = e.ColumnIndex;

            //update dblValues from data grid
            dblValues[r][c] = Convert.ToDouble(dgvData.Rows[r].Cells[c].Value);

            //update originally read data lines
            lines[r + 1] = dblValues[r][0].ToString();
            for (int i = 1; i < dblValues[r].Length; i++)
                lines[r + 1] += "\t" + dblValues[r][i];
        }

        public void GetCoefficient(int i, int j)
        {
            double result = Mathtool.GetCoefficient(dblValues, i, j);
            txtStat.Text = "Correlation Coefficient between " + colnames[i] + " and " + colnames[j] + " is: " + result.ToString("#.##");
            tcStat.SelectedTab = tp2;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string q = "Do you want to save data?";
            MessageBoxButtons b = MessageBoxButtons.YesNo;
            DialogResult r = MessageBox.Show(q, "Save Data?", b);

            //write lines to the original text file
            if (r == DialogResult.Yes)
            {
                if (lines != null)
                    File.WriteAllLines(fileName, lines);
            }
            Application.Exit();
        }

        public void LoadData()
        {
            OpenFileDialog mydialog = new OpenFileDialog();
            mydialog.InitialDirectory = @"c:\";
            mydialog.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";

            if (mydialog.ShowDialog() == DialogResult.OK)
            {
                fileName = mydialog.FileName;
                lines = File.ReadAllLines(fileName);

            }


            
            

            //use list as intermediate step to remove blank lines
            List<string> temp = new List<string>();

            foreach (string x in lines)
            {
                if (!string.IsNullOrEmpty(x))
                    temp.Add(x);
            }
            lines = temp.ToArray();

            
            int h = lines.Length;

            //put invidual data item into strValues
            strValues = new string[h - 1][];
            //the first row makes up column names
            colnames = lines[0].Split('\t');

            foreach (string x in colnames)
                dgvData.Columns.Add(x, x);

            for (int i = 1; i < h; i++)
            {
                strValues[i - 1] = lines[i].Split('\t');
            }

            int w = colnames.Length;
            dblValues = new double[h - 1][];

            dgvData.ColumnCount = w;
            for (int i = 0; i < h - 1; i++)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvData);
                dblValues[i] = new double[w];
                for (int j = 0; j < strValues[i].Length; j++)
                {
                    r.Cells[j].Value = strValues[i][j];
                    dblValues[i][j] = Convert.ToDouble(strValues[i][j]);
                }
                dgvData.Rows.Add(r);

            }
            tcStat.SelectedTab = tp1;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void descriptiveStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Descriptive descriptiveForm = new Descriptive();
            descriptiveForm.SetVariables(colnames); 
            if (descriptiveForm.ShowDialog(this) == DialogResult.OK)
            {
                string[] selectedVariables = descriptiveForm.SelectedVariables;
                StringBuilder resultBuilder = new StringBuilder();

                if (selectedVariables.Length < 2)
                {
                    MessageBox.Show("Please select at least two variables.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (var variable in selectedVariables)
                {
                    int index = Array.IndexOf(colnames, variable);
                    if (index == -1) continue; // If the variable was not found, skip it

                    List<double> variableData = dblValues.Select(row => row[index]).ToList();
                    DescriptiveStat stats = Mathtool.GetDescriptiveStat(variableData);

                    resultBuilder.AppendLine($"Descriptive Statistics for {variable}:");
                    resultBuilder.AppendLine($"  Max: {stats.max.ToString("N2")}");
                    resultBuilder.AppendLine($"  Min: {stats.min.ToString("N2")}");
                    resultBuilder.AppendLine($"  Sum: {stats.sum.ToString("N2")}");
                    resultBuilder.AppendLine($"  Mean: {stats.avg.ToString("N2")}");
                    resultBuilder.AppendLine($"  Variance: {stats.var.ToString("N2")}");
                    resultBuilder.AppendLine($"  Standard Deviation: {stats.stddev.ToString("N2")}");
                    resultBuilder.AppendLine($"  Median: {stats.median.ToString("N2")}");
                    resultBuilder.AppendLine($"  Range: {stats.range}");
                    resultBuilder.AppendLine(); 
                }

                // Set the text of the txtStat control to the resultBuilder string
                txtStat.Text = resultBuilder.ToString();

                
                tcStat.SelectedTab = tp2;
            }
        }

        private void linearRegressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Linear linearForm = new Linear();
            linearForm.SetVariables(colnames);
            if (linearForm.ShowDialog(this) == DialogResult.OK)
            {
                
                string xVariable = linearForm.SelectedXVariable;
                string yVariable = linearForm.SelectedYVariable;

                
                int xIndex = Array.IndexOf(colnames, xVariable);
                int yIndex = Array.IndexOf(colnames, yVariable);
                List<double> xData = dblValues.Select(row => row[xIndex]).ToList();
                List<double> yData = dblValues.Select(row => row[yIndex]).ToList();

                
                var (Slope, Intercept, RSquared) = Mathtool.PerformLinearRegression(xData, yData);

                // Display results
                txtStat.Text = $"Linear Regression between {xVariable} and {yVariable}:\n" +
                               $"Slope: {Slope}\nIntercept: {Intercept}\nR-Squared: {RSquared}";
                tcStat.SelectedTab = tp2; 
            }
        }


        private void DrawScatterPlot(List<double> xData, List<double> yData)
        {
            Bitmap bmp = new Bitmap(pictureBoxScatterPlot.Width, pictureBoxScatterPlot.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White); 

                // Determine the range for the graph
                double xMax = xData.Max();
                double xMin = xData.Min();
                double yMax = yData.Max();
                double yMin = yData.Min();

                // Calculate scale factors considering the margin
                double xScale = (pictureBoxScatterPlot.Width - 40) / (xMax - xMin);
                double yScale = (pictureBoxScatterPlot.Height - 40) / (yMax - yMin);

                // Draw each point
                for (int i = 0; i < xData.Count; i++)
                {
                    // Convert data values to pixel positions considering the margin and invert the y-axis
                    int x = (int)((xData[i] - xMin) * xScale) + 20;
                    int y = pictureBoxScatterPlot.Height - (int)((yData[i] - yMin) * yScale) - 20;
                    g.FillEllipse(Brushes.Black, x - 2, y - 2, 4, 4);
                }

                
                var (slope, intercept) = PerformLinearRegression(xData, yData);

                // Calculate start and end points for the regression line considering the margin and invert the y-axis
                // Make sure the line extends across the full width of the PictureBox
                Point startPoint = new Point(
                    20,
                    pictureBoxScatterPlot.Height - (int)((slope * xMin + intercept - yMin) * yScale) - 20
                );
                Point endPoint = new Point(
                    pictureBoxScatterPlot.Width - 20,
                    pictureBoxScatterPlot.Height - (int)((slope * xMax + intercept - yMin) * yScale) - 20
                );

                
                g.DrawLine(new Pen(Color.Red, 2), startPoint, endPoint);
            }

            
            pictureBoxScatterPlot.Image = bmp;
        }

        private (double Slope, double Intercept) PerformLinearRegression(List<double> xData, List<double> yData)
        {
            // Implementation of the linear regression to get the slope and intercept...
            
            var result = Mathtool.PerformLinearRegression(xData, yData);
            return (result.Slope, result.Intercept);
        }



        private void scatterPlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scatter scatterForm = new Scatter();
            scatterForm.SetVariables(colnames); // Pass the column names to the Scatter form

            if (scatterForm.ShowDialog(this) == DialogResult.OK)
            {
                // Retrieve the selected X and Y variables
                string xVariable = scatterForm.SelectedXVariable;
                string yVariable = scatterForm.SelectedYVariable;

                if (!string.IsNullOrEmpty(xVariable) && !string.IsNullOrEmpty(yVariable))
                {
                    int xIndex = Array.IndexOf(colnames, xVariable);
                    int yIndex = Array.IndexOf(colnames, yVariable);

                    List<double> xData = dblValues.Select(row => row[xIndex]).ToList();
                    List<double> yData = dblValues.Select(row => row[yIndex]).ToList();

                    DrawScatterPlot(xData, yData); // Call the method to draw the scatter plot
                }
                else
                {
                    MessageBox.Show("Please select one variable for X and one for Y.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBoxScatterPlot_Click(object sender, EventArgs e)
        {

        }
    }
}