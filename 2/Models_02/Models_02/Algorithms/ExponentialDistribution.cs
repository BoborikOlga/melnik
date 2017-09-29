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
        private List<double> _generatedNumbers;


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
            _generatedNumbers = new List<double>();
            foreach(var rand in _randomValues)
            {
                _generatedNumbers.Add(((-1) / _lambda) * Math.Log(rand));
            }

            return _generatedNumbers;
        }

        public double GetDispersion()
        {
            double d = 0;
            var _m = GetExpectancy();

            foreach (var number in _generatedNumbers)
            {
                d = d + Math.Pow((number - _m), 2);
            }
            d = d / _generatedNumbers.Count;
            d = d * _generatedNumbers.Count / (_generatedNumbers.Count - 1);

            return d;

            
        }

        public double GetExpectancy()
        {
            double _m = 0;
            foreach (var number in _generatedNumbers)
            {
                _m += number;
            }
            _m = _m / _generatedNumbers.Count;
            return _m;
        }

        public double GetAverage()
        {
            return Math.Sqrt(GetDispersion());
        }
    }
}
