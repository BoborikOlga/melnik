using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace models_01
{
    public partial class MainForm : Form
    {
        private int _intervals;


        public MainForm()
        {
            InitializeComponent();
        }


        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (!AreFieldsValid())
            {
                MessageBox.Show(@"Try again");

                return;
            }
            var generatorParams = GetParamsFromTextFields();
            var generator = new RandomGenerator(generatorParams);
            var generatedNumbers = generator.GenerateNumbers();

            CreateChart(generatedNumbers);
            var expectancy = GetExpectancy(generatedNumbers);
            var dispersion = GetDispersion(generatedNumbers, expectancy);
            var medium = GetMedium(generatedNumbers, expectancy);
            var indirectSignsRation = CheckByIndirectSigns(generatedNumbers);

            DTextBox.Text = dispersion.ToString();
            ExpectancyTextBox.Text = expectancy.ToString();
            MediumTextBox.Text = medium.ToString();
            RatioTextBox.Text = Math.Round(indirectSignsRation, 3).ToString();
        }

        private double CheckByIndirectSigns(List<double> generatedNumbers)
        {
            var couples = 0;
            for (int i = 1; i < generatedNumbers.Count; i++)
            {
                if (generatedNumbers[i - 1] + generatedNumbers[i] < 1)
                {
                    couples++;
                }
            }

            return couples / (double) generatedNumbers.Count;
        }

        private double GetExpectancy(IReadOnlyCollection<double> generatedNumbers)
        {
            return generatedNumbers.Sum() / generatedNumbers.Count;
        }

        private double GetMedium(IReadOnlyCollection<double> generatedNumbers, double expectancy)
        {
            double sum = 0;
            foreach (var number in generatedNumbers)
            {
                sum += Math.Pow(number - expectancy, 2);
            }

            return sum / generatedNumbers.Count;
        }

        private double GetDispersion(IReadOnlyCollection<double> generatedNumbers, double m)
        {
            double d = 0;

            foreach (var number in generatedNumbers)
            {
                d = d + Math.Pow((number - m), 2);
            }
            d = d / generatedNumbers.Count;
            d = d * generatedNumbers.Count / (generatedNumbers.Count - 1);

            return d;
        }

        private void CreateChart(IReadOnlyCollection<double> generatedNumbers)
        {
            Graph.Series["Frequencies"].Points.Clear();
            var max = generatedNumbers.Max();
            var min = generatedNumbers.Min();

            var range = max - min;
            var intervalLength = range / _intervals;

            var hittingCounts = GetHittingCounts(generatedNumbers, _intervals, intervalLength);
            var frequencies = GetFrequencies(hittingCounts, generatedNumbers.Count);
            for (int i = 0; i < frequencies.Count; i++)
            {
                var endOfInterfval = Math.Round(min + (i + 1) * intervalLength, 2);
                Graph.Series["Frequencies"].Points.AddXY(endOfInterfval, frequencies[i]);
            }
        }

        private List<double> GetFrequencies(IReadOnlyCollection<int> hittingCounts, int numbers)
        {
            var frequencies = new List<double>();
            foreach (var hittings in hittingCounts)
            {
                frequencies.Add(hittings / (double)numbers);
            }

            return frequencies;
        }

        private IReadOnlyCollection<int> GetHittingCounts(IReadOnlyCollection<double> generatedNumbers, int intervals, double intervalLength)
        {
            var hittingCounts = new int[intervals];
            var min = generatedNumbers.Min();
            foreach (var value in generatedNumbers)
            {
                int intervalNumber = Convert.ToInt32(Math.Truncate((value - min) / intervalLength));
                if (intervalNumber == intervals)
                {
                    intervalNumber--;
                }
                hittingCounts[intervalNumber]++;
            }

            return hittingCounts;
        }

        private GeneratorParams GetParamsFromTextFields()
        {
            var m = Convert.ToInt32(MTextBox.Text.Trim());
            var a = Convert.ToDouble(ATextBox.Text.Trim());
            var r0 = Convert.ToDouble(RTextBox.Text.Trim());
            _intervals = Convert.ToInt32(IntervalsTextBox.Text.Trim());

            return new GeneratorParams(a, r0, m);
        }

        private bool AreFieldsValid()
        {
            try
            {
                var m = MTextBox.Text.Trim();
                if (m.Length == 0 || Convert.ToInt32(m) < 1)
                {
                    MessageBox.Show(@"Wrong M value");

                    return false;
                }
                if (ATextBox.Text.Trim().Length == 0)
                {
                    MessageBox.Show(@"Wrong A value");

                    return false;
                }
                if (RTextBox.Text.Trim().Length == 0)
                {
                    MessageBox.Show(@"Wrong R value");

                    return false;
                }
                if (IntervalsTextBox.Text.Trim().Length == 0 || Convert.ToInt32(IntervalsTextBox.Text.Trim()) < 20)
                {
                    MessageBox.Show(@"Wrong intervals count");

                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                return false;
            }
        }
    }
}
