using System;
using System.Windows.Forms;
using models_01.Models;

namespace models_01.Utils
{
    public class Validator
    {
        public bool AreParamsValid(GeneratorParams generatorParams, int intervals)
        {
            try
            {

                if (generatorParams.M < 2)
                {
                    MessageBox.Show(@"Wrong M value");

                    return false;
                }
                if (generatorParams.A < 0)
                {
                    MessageBox.Show(@"Wrong A value");

                    return false;
                }
                if (generatorParams.R0 < 0)
                {
                    MessageBox.Show(@"Wrong R value");

                    return false;
                }
                if (intervals < 2)
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
