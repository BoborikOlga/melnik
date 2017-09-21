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
            var algorithm = GetAlgorithm();
            if (algorithm == null)
            {
                MessageBox.Show(@"There is invalid input. Check text fields and try again.");

                return;
            }

            var generator = new RandomGenerator(algorithm);
            var generatedNumbers = generator.GenerateNumbers();

            var tester = new Tester();

            //var expectancy = tester.GetExpectancy(generatedNumbers);
            //var dispersion = tester.GetDispersion(generatedNumbers, expectancy);
            //var average = Math.Sqrt(dispersion);

            //DTextBox.Text = dispersion.ToString();
            //ExpectancyTextBox.Text = expectancy.ToString();
            //AverageTextBox.Text = average.ToString();
        }

        private IAlgorithm GetAlgorithm()
        {
            try
            {
                var parameters = new Dictionary<string, object>();
                var index = AlgComboBox.SelectedIndex;
                var distribution = (DistributionType)index;

                switch (distribution)
                {
                    case DistributionType.Uniform:
                        {
                            parameters["n"] = Convert.ToInt32(NTextBox.Text.Trim());
                            parameters["a"] = Convert.ToDouble(ATextBox.Text.Trim());
                            parameters["b"] = Convert.ToDouble(BTextBox.Text.Trim());

                            return UniformDistribution.Create(parameters);
                        }
                    case DistributionType.Exponential:
                        {
                            parameters["n"] = Convert.ToInt32(NTextBox.Text.Trim());
                            parameters["a"] = Convert.ToDouble(ATextBox.Text.Trim());
                            parameters["b"] = Convert.ToDouble(BTextBox.Text.Trim());
                            break;
                        }
                    case DistributionType.Gamma:
                        {
                            parameters["n"] = Convert.ToInt32(NTextBox.Text.Trim());
                            parameters["a"] = Convert.ToDouble(ATextBox.Text.Trim());
                            parameters["b"] = Convert.ToDouble(BTextBox.Text.Trim());
                            break;
                        }
                    case DistributionType.Simpson:
                        {
                            parameters["n"] = Convert.ToInt32(NTextBox.Text.Trim());
                            parameters["a"] = Convert.ToDouble(ATextBox.Text.Trim());
                            parameters["b"] = Convert.ToDouble(BTextBox.Text.Trim());
                            break;
                        }
                    case DistributionType.Triangular:
                        {
                            parameters["n"] = Convert.ToInt32(NTextBox.Text.Trim());
                            parameters["a"] = Convert.ToDouble(ATextBox.Text.Trim());
                            parameters["b"] = Convert.ToDouble(BTextBox.Text.Trim());
                            break;
                        }
                    case DistributionType.Gaussian:
                        {
                            parameters["n"] = Convert.ToInt32(NTextBox.Text.Trim());
                            parameters["a"] = Convert.ToDouble(ATextBox.Text.Trim());
                            parameters["b"] = Convert.ToDouble(BTextBox.Text.Trim());
                            break;
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
