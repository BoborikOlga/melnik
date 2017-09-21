using Models_02.Models;
using Models_02.Utils;
using System;
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
            var generatorParams = GetParamsFromTextFields();
            if (generatorParams == null)
            {
                MessageBox.Show(@"There is invalid input. Check text fields and try again.");

                return;
            }

            var validator = new Validator();
            if (!validator.AreParamsValid(generatorParams))
            {
                MessageBox.Show(@"Try again");

                return;
            }

            var generator = new RandomGenerator(generatorParams);
            

            var tester = new Tester();

            //var expectancy = tester.GetExpectancy(generatedNumbers);
            //var dispersion = tester.GetDispersion(generatedNumbers, expectancy);
            //var average = Math.Sqrt(dispersion);

            //DTextBox.Text = dispersion.ToString();
            //ExpectancyTextBox.Text = expectancy.ToString();
            //AverageTextBox.Text = average.ToString();
        }

        private GeneratorParams GetParamsFromTextFields()
        {
            try
            {
                var n = Convert.ToInt32(NTextBox.Text.Trim());
                var a = Convert.ToDouble(ATextBox.Text.Trim());
                var b = Convert.ToDouble(BTextBox.Text.Trim());

                return new GeneratorParams(a, b, n);
            }
            catch
            {
                return null;
            }
        }
    }
}
