using Models_02.Models;
using System;
using System.Windows.Forms;

namespace Models_02.Utils
{
    public class Validator
    {
        public bool AreParamsValid(GeneratorParams generatorParams)
        {
            try
            {

                if (generatorParams.N < 2)
                {
                    MessageBox.Show(@"Wrong N value");

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
