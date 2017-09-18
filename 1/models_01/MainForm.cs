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
            Calculate();
        }

        private void Calculate()
        {
            var generatorParams = GetParamsFromTextFields();
            if (generatorParams == null)
            {
                MessageBox.Show(@"There is invalid input. Check text fields and try again.");

                return;
            }

            var validator = new Validator();
            if (!validator.AreParamsValid(generatorParams, _intervals))
            {
                MessageBox.Show(@"Try again");

                return;
            }

            var generator = new RandomGenerator(generatorParams);
            var generatedNumbers = generator.GenerateNumbers();

            var tester = new Tester();
            CreateChart(tester, generatedNumbers, _intervals);

            var expectancy = tester.GetExpectancy(generatedNumbers);
            var dispersion = tester.GetDispersion(generatedNumbers, expectancy);
            var medium = tester.GetMedium(generatedNumbers, expectancy);
            var indirectSignsRation = tester.CheckByIndirectSigns(generatedNumbers);
            var period = tester.GetPeriod(generatedNumbers);
            var aperiodicLength = tester.GetAperiodicLength(generatedNumbers, period);


            PeriodTextBox.Text = period.ToString();
            AperiodicTextBox.Text = aperiodicLength.ToString();
            DTextBox.Text = dispersion.ToString();
            ExpectancyTextBox.Text = expectancy.ToString();
            MediumTextBox.Text = medium.ToString();
            RatioTextBox.Text = Math.Round(indirectSignsRation, 3).ToString();
        }

        private void CreateChart(ITester tester, IReadOnlyCollection<double> generatedNumbers, int intevals)
        {
            Graph.Series["Frequencies"].Points.Clear();
            var max = generatedNumbers.Max();
            var min = generatedNumbers.Min();

            var range = max - min;
            var intervalLength = range / intevals;

            var hittingCounts = tester.GetHittingCounts(generatedNumbers, intevals, intervalLength);
            var frequencies = tester.GetFrequencies(hittingCounts, generatedNumbers.Count);
            for (int i = 0; i < frequencies.Count; i++)
            {
                var endOfInterfval = Math.Round(min + (i + 1) * intervalLength, 2);
                Graph.Series["Frequencies"].Points.AddXY(endOfInterfval, frequencies[i]);
            }
        }

        private GeneratorParams GetParamsFromTextFields()
        {
            try
            {
                var m = Convert.ToInt32(MTextBox.Text.Trim());
                var a = Convert.ToDouble(ATextBox.Text.Trim());
                var r0 = Convert.ToDouble(RTextBox.Text.Trim());
                _intervals = Convert.ToInt32(IntervalsTextBox.Text.Trim());

                return new GeneratorParams(a, r0, m);
            }
            catch
            {
                return null;
            }
        }
    }
}
