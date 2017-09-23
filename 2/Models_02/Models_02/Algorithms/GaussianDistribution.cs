using System;
using System.Collections.Generic;
using Models_02.Interfaces;
using System.Windows.Forms;
using Models_02.Utils;

namespace Models_02.Algorithms
{
    class GaussianDistribution : IAlgorithm
    {
        private int _n;
        private readonly int _count = Tester.NumbersCount;
        private List<double> _randomValues;
        private List<double> _generatedNumbers;
        private double _expectancy;
        private double _m;
        private double _average;
        Random _rand;


        private GaussianDistribution(IDictionary<string, object> parameters)
        {
            _n = (int)parameters["n"];
            _expectancy = (double)parameters["m"];
            _average = (double)parameters["sigma"];
            _rand = new Random((int)DateTime.Now.Ticks);
        }


        public static GaussianDistribution Create(IDictionary<string, object> parameters)
        {
            if (AreParamsValid(parameters))
            {
                return new GaussianDistribution(parameters);
            }

            return null;
        }
        

        private void GenerateRandomValues()
        {
            _randomValues = new List<double>();
            for (int i = 0; i < _n; i++)
            {
                _randomValues.Add(_rand.NextDouble());
            }
        }

        private static bool AreParamsValid(IDictionary<string, object> parameters)
        {
            var n = (int)parameters["n"];
            var expectancy = (double)parameters["m"];
            var average = (double)parameters["sigma"];
            if (n < 6)
            {
                MessageBox.Show("To little value of n, try higher");

                return false;
            }
            if(expectancy < 0)
            {
                MessageBox.Show("To little value of m, try higher");

                return false;
            }
            if (average < 0)
            {
                MessageBox.Show("To little value of sigma, try higher");

                return false;
            }

            return true;
        }

        public List<double> GenerateNumbers()
        {
            _generatedNumbers = new List<double>();
            
            for(int i = 0; i < _count; i++)
            {
                GenerateRandomValues();
                _generatedNumbers.Add(_expectancy + _average * Math.Sqrt(12 / (double)_n) * (Sum(_randomValues) - (double)_n / 2));
            }

            return _generatedNumbers;
        }

        private double Sum(IReadOnlyCollection<double> values)
        {
            double sum = 0;
            foreach(var value in values)
            {
                sum += value;
            }

            return sum;
        }

        public double GetDispersion()
        {
            double d = 0;
            _m = GetExpectancy();

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
            _m = 0;
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
