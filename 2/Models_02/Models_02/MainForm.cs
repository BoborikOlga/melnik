using Models_02.Algorithms;
using Models_02.Interfaces;
using Models_02.Models;
using Models_02.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Models_02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeAlgComboBox();
        }


        private void InitializeAlgComboBox()
        {
            var distributions = Enum.GetValues(typeof(DistributionType));
            foreach(var distribution in distributions)
            {
                AlgComboBox.Items.Add(distribution.ToString() + " distribution");
            }
            AlgComboBox.SelectedIndex = 0;
        }


        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            var distribution = GetSelectedDistribution();
            var parameters = GetParametersFromTextFields(distribution);
            if (parameters == null)
            {
                MessageBox.Show(@"There is invalid input. Check text fields and try again.");

                return;
            }

            var algorithm = AlgorithmFactory.Create(distribution, parameters);
            if (algorithm == null)
            {
                MessageBox.Show(@"There are invalid params. Check text fields and try again.");

                return;
            }

            var generatedNumbers = algorithm.GenerateNumbers();
            var expectancy = algorithm.GetExpectancy();
            var dispersion = algorithm.GetDispersion();
            var average = algorithm.GetAverage();

            DTextBox.Text = dispersion.ToString();
            ExpectancyTextBox.Text = expectancy.ToString();
            AverageTextBox.Text = average.ToString();
        }

        private DistributionType GetSelectedDistribution()
        {
            var index = AlgComboBox.SelectedIndex;
            return (DistributionType)index;
        }

        private IDictionary<string, object> GetParametersFromTextFields(DistributionType distribution)
        {
            var parameters = new Dictionary<string, object>();
            try
            {
                switch (distribution)
                {
                    case DistributionType.Uniform:
                        {
                            parameters["a"] = Convert.ToDouble(ATextBox.Text.Trim());
                            parameters["b"] = Convert.ToDouble(BTextBox.Text.Trim());

                            return parameters;
                        }
                    case DistributionType.Exponential:
                        {
                            parameters["n"] = Convert.ToInt32(NTextBox.Text.Trim());
                            parameters["a"] = Convert.ToDouble(ATextBox.Text.Trim());
                            parameters["b"] = Convert.ToDouble(BTextBox.Text.Trim());

                            return parameters;
                        }
                    case DistributionType.Gamma:
                        {
                            parameters["n"] = Convert.ToInt32(NTextBox.Text.Trim());
                            parameters["a"] = Convert.ToDouble(ATextBox.Text.Trim());
                            parameters["b"] = Convert.ToDouble(BTextBox.Text.Trim());

                            return parameters;
                        }
                    case DistributionType.Simpson:
                        {
                            parameters["n"] = Convert.ToInt32(NTextBox.Text.Trim());
                            parameters["a"] = Convert.ToDouble(ATextBox.Text.Trim());
                            parameters["b"] = Convert.ToDouble(BTextBox.Text.Trim());

                            return parameters;
                        }
                    case DistributionType.Triangular:
                        {
                            parameters["n"] = Convert.ToInt32(NTextBox.Text.Trim());
                            parameters["a"] = Convert.ToDouble(ATextBox.Text.Trim());
                            parameters["b"] = Convert.ToDouble(BTextBox.Text.Trim());

                            return parameters;
                        }
                    case DistributionType.Gaussian:
                        {
                            parameters["n"] = Convert.ToInt32(NTextBox.Text.Trim());
                            parameters["m"] = Convert.ToDouble(MTextBox.Text.Trim());
                            parameters["sigma"] = Convert.ToDouble(SigmaTextBox.Text.Trim());

                            return parameters;
                        }
                }

                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
