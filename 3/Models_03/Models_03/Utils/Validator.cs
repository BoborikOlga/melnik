using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_03.Utils
{
    public class Validator
    {
        private const int defaultCount = 1000000;
        private const double defaultP = 0.7;
        private const double defaultPi1 = 0.7;
        private const double defaultPi2 = 0.75;

        private string _p;
        private string _pi1;
        private string _pi2;
        private string _count;


        public Validator(string p, string pi1, string pi2, string count)
        {
            _p = p.Trim().Replace(".", ",");
            _pi1 = pi1.Trim().Replace(".", ",");
            _pi2 = pi2.Trim().Replace(".", ",");
            _count = count.Trim();
        }


        public Dictionary<string, double> GetValidParams()
        {
            try
            {
                Dictionary<string, double> parameters = new Dictionary<string, double>();
                if (!String.IsNullOrEmpty(_count))
                {
                    if (Convert.ToInt32(_count) < 1)
                    {
                        return null;
                    }
                    parameters["count"] = Convert.ToInt32(_count);
                }
                else
                {
                    parameters["count"] = defaultCount;
                }
                if (!String.IsNullOrEmpty(_p))
                {
                    if (Convert.ToDouble(_p) < 0)
                    {
                        return null;
                    }
                    else
                    {
                        parameters["p"] = defaultP;
                    }
                }
                if (!String.IsNullOrEmpty(_pi1))
                {
                    if (Convert.ToDouble(_pi1) < 0)
                    {
                        return null;
                    }
                    else
                    {
                        parameters["Pi1"] = defaultPi1;
                    }
                }
                if (!String.IsNullOrEmpty(_pi2))
                {
                    if (Convert.ToDouble(_pi2) < 0)
                    {
                        return null;
                    }
                    else
                    {
                        parameters["Pi2"] = defaultPi2;
                    }
                }

                return parameters;
            }
            catch
            {
                return null;
            }
        }
    }
}
