using Models_02.Algorithms;
using Models_02.Interfaces;
using Models_02.Models;
using Models_02.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Models_02
{
    public partial class MainForm : Form
    {
        private const int _intervals = 20;
        private IDictionary<string, List<TextBox>> algorytmsTextBoxes;
        private IDictionary<string, List<Label>> algorytmsLabels;


        public MainForm()
        {
            InitializeComponent();
            InitializeAlgorythmsTextBoxes();
            InitializeAlgorythmsLabels();
            InitializeAlgComboBox();  
        }


        private void InitializeAlgorythmsLabels()
        {
            algorytmsLabels = new Dictionary<string, List<Label>>();
            var distributions = Enum.GetValues(typeof(DistributionType));
            foreach (var distribution in distributions)
            {
                algorytmsLabels[distribution.ToString()] = new List<Label>();
            }

            algorytmsLabels[DistributionType.Uniform.ToString()].Add(ALabel);
            algorytmsLabels[DistributionType.Uniform.ToString()].Add(BLabel);

            algorytmsLabels[DistributionType.Exponential.ToString()].Add(LambdaLabel);

            algorytmsLabels[DistributionType.Gamma.ToString()].Add(NLabel);
            algorytmsLabels[DistributionType.Gamma.ToString()].Add(LambdaLabel);

            algorytmsLabels[DistributionType.Gaussian.ToString()].Add(NLabel);
            algorytmsLabels[DistributionType.Gaussian.ToString()].Add(MLabel);
            algorytmsLabels[DistributionType.Gaussian.ToString()].Add(SigmaLabel);

            algorytmsLabels[DistributionType.Simpson.ToString()].Add(ALabel);
            algorytmsLabels[DistributionType.Simpson.ToString()].Add(BLabel);

            algorytmsLabels[DistributionType.Triangular.ToString()].Add(ALabel);
            algorytmsLabels[DistributionType.Triangular.ToString()].Add(BLabel);
        }

        private void InitializeAlgorythmsTextBoxes()
        {
            algorytmsTextBoxes = new Dictionary<string, List<TextBox>>();
            var distributions = Enum.GetValues(typeof(DistributionType));
            foreach(var distribution in distributions)
            {
                algorytmsTextBoxes[distribution.ToString()] = new List<TextBox>();
            }

            algorytmsTextBoxes[DistributionType.Uniform.ToString()].Add(ATextBox);
            algorytmsTextBoxes[DistributionType.Uniform.ToString()].Add(BTextBox);

            algorytmsTextBoxes[DistributionType.Exponential.ToString()].Add(LambdaTextBox);

            algorytmsTextBoxes[DistributionType.Gamma.ToString()].Add(NTextBox);
            algorytmsTextBoxes[DistributionType.Gamma.ToString()].Add(LambdaTextBox);

            algorytmsTextBoxes[DistributionType.Gaussian.ToString()].Add(NTextBox);
            algorytmsTextBoxes[DistributionType.Gaussian.ToString()].Add(MTextBox);
            algorytmsTextBoxes[DistributionType.Gaussian.ToString()].Add(SigmaTextBox);

            algorytmsTextBoxes[DistributionType.Simpson.ToString()].Add(ATextBox);
            algorytmsTextBoxes[DistributionType.Simpson.ToString()].Add(BTextBox);

            algorytmsTextBoxes[DistributionType.Triangular.ToString()].Add(ATextBox);
            algorytmsTextBoxes[DistributionType.Triangular.ToString()].Add(BTextBox);
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
            if(!IsTestCountValid())
            {
                MessageBox.Show("Wrong test count value, try again.");

                return;
            }
            Calculate();
        }

        private bool IsTestCountValid()
        {
            try
            {
                Tester.NumbersCount = Convert.ToInt32(CountTextBox.Text.Trim());
                if (Tester.NumbersCount < 1)
                {
                    return false;
                }

                return true;
            }
            catch
            {
                return false;
            }
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

            CreateChart(algorithm.GenerateNumbers());
            DTextBox.Text = algorithm.GetDispersion().ToString();
            ExpectancyTextBox.Text = algorithm.GetExpectancy().ToString();
            AverageTextBox.Text = algorithm.GetAverage().ToString();
        }

        private DistributionType GetSelectedDistribution()
        {
            var index = AlgComboBox.SelectedIndex;
            return (DistributionType)index;
        }

        private void CreateChart(List<double> generatedNumbers)
        {
            Chart.Series["Numbers"].Points.Clear();
            var max = generatedNumbers.Max();
            var min = generatedNumbers.Min();

            var range = max - min;
            var intervalLength = range / _intervals;

            var frequencies = Tester.GetFrequencies(generatedNumbers, _intervals, intervalLength);
            for (int i = 0; i < frequencies.Count; i++)
            {
                var endOfInterfval = Math.Round(min + (i + 1) * intervalLength, 2);
                Chart.Series["Numbers"].Points.AddXY(endOfInterfval, frequencies[i]);
            }
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
                            parameters["a"] = Convert.ToDouble(ATextBox.Text.Trim().Replace(".", ","));
                            parameters["b"] = Convert.ToDouble(BTextBox.Text.Trim().Replace(".", ","));

                            return parameters;
                        }
                    case DistributionType.Exponential:
                        {
                            parameters["lambda"] = Convert.ToDouble(LambdaTextBox.Text.Trim().Replace(".", ","));

                            return parameters;
                        }
                    case DistributionType.Gamma:
                        {
                            parameters["n"] = Convert.ToInt32(NTextBox.Text.Trim());
                            parameters["lambda"] = Convert.ToDouble(LambdaTextBox.Text.Trim().Replace(".", ","));

                            return parameters;
                        }
                    case DistributionType.Simpson:
                        {
                            parameters["a"] = Convert.ToDouble(ATextBox.Text.Trim().Replace(".", ","));
                            parameters["b"] = Convert.ToDouble(BTextBox.Text.Trim().Replace(".", ","));

                            return parameters;
                        }
                    case DistributionType.Triangular:
                        {
                            parameters["a"] = Convert.ToDouble(ATextBox.Text.Trim().Replace(".", ","));
                            parameters["b"] = Convert.ToDouble(BTextBox.Text.Trim().Replace(".", ","));

                            return parameters;
                        }
                    case DistributionType.Gaussian:
                        {
                            parameters["n"] = Convert.ToInt32(NTextBox.Text.Trim());
                            parameters["m"] = Convert.ToDouble(MTextBox.Text.Trim().Replace(".", ","));
                            parameters["sigma"] = Convert.ToDouble(SigmaTextBox.Text.Trim().Replace(".", ","));

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

        private void AlgComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectAlgorithm((sender as ComboBox).SelectedIndex);
        }

        private void SelectAlgorithm(int number)
        {
            var algorythm = (DistributionType)number;
            SelectAlgorithmTextBoxes(algorythm);
            SelectAlgorithmLabels(algorythm);
        }

        private void SelectAlgorithmTextBoxes(DistributionType algorythm)
        {
            foreach (var textBoxes in algorytmsTextBoxes)
            {
                foreach (var textBox in textBoxes.Value)
                {
                    textBox.Visible = false;
                    textBox.Clear();
                }
            }

            foreach (var textBox in algorytmsTextBoxes[algorythm.ToString()])
            {
                textBox.Visible = true;
            }
        }

        private void SelectAlgorithmLabels(DistributionType algorythm)
        {
            foreach (var labels in algorytmsLabels)
            {
                foreach (var label in labels.Value)
                {
                    label.Visible = false;
                }
            }

            foreach (var label in algorytmsLabels[algorythm.ToString()])
            {
                label.Visible = true;
            }
        }
    }
}
