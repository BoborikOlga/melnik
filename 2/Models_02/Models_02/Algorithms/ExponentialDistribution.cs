using System;
using System.Collections.Generic;
using Models_02.Interfaces;
using System.Windows.Forms;
using Models_02.Utils;

namespace Models_02.Algorithms
{
    class ExponentialDistribution : IAlgorithm
    {
        private double _lambda;
        private readonly int _count = Tester.NumbersCount;
        private List<double> _randomValues;


        private ExponentialDistribution(IDictionary<string, object> parameters)
        {
            _lambda = (double)parameters["lambda"];
            GenerateRandomValues();
        }


        private void GenerateRandomValues()
        {
            _randomValues = new List<double>();
            Random rand = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < _count; i++)
            {
                _randomValues.Add(rand.NextDouble());
            }
        }


        private static bool AreParamsValid(IDictionary<string, object> parameters)
        {
            var lambda = (double)parameters["lambda"];
            if (lambda < 0)
            {
                MessageBox.Show("To little value of lambda, try higher");

                return false;
            }
          
            return true;
        }

        public static ExponentialDistribution Create(IDictionary<string, object> parameters)
        {
            if (AreParamsValid(parameters))
            {
                return new ExponentialDistribution(parameters);
            }

            return null;
        }

        public List<double> GenerateNumbers()
        {
            var numbers = new List<double>();
            foreach(var rand in _randomValues)
            {
                numbers.Add(((-1) / _lambda) * Math.Log(rand));
            }

            return numbers;
        }

        public double GetDispersion()
        {
            return 1 / Math.Pow(_lambda, 2);
        }

        public double GetExpectancy()
        {
            return 1 / _lambda;
        }

        public double GetAverage()
        {
            return 1 / _lambda;
        }
    }
}
