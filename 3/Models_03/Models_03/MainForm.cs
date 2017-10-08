using Models_03.Models;
using Models_03.Utils;
using System;
using System.Windows.Forms;

namespace Models_03
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ImitateButton_Click(object sender, EventArgs e)
        {
            var validator = new Validator(PTextBox.Text, FirstPiTextBox.Text, SecondPiTextBox.Text, TicksTextBox.Text);
            var parameters = validator.GetValidParams();
            if (parameters == null)
            {
                MessageBox.Show("Invalid params");

                return;
            }
            var system = new QueuingSystem(parameters);
            var result = system.Imitate();
            if(result == null)
            {
                MessageBox.Show("Result error");

                return;
            }
            ATextBox.Text = Math.Round(result["A"], 2).ToString();
            LcTextBox.Text = Math.Round(result["Lc"], 2).ToString();
            WcTextBox.Text = Math.Round(result["Wc"], 2).ToString();
        }
    }
}
