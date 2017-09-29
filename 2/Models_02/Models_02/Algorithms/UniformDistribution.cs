using System;
using System.Collections.Generic;
using Models_02.Interfaces;
using Models_02.Utils;

namespace Models_02.Algorithms
{
    class UniformDistribution : IAlgorithm
    {
        private double _a;
        private double _b;
        private readonly int _count = Tester.NumbersCount;
        private List<double> _randomValues;
        private List<double> _generatedNumbers;


        private UniformDistribution(IDictionary<string, object> parameters)
        {
            _a = (double)parameters["a"];
            _b = (double)parameters["b"];
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


        public static UniformDistribution Create(IDictionary<string, object> parameters)
        {
            return new UniformDistribution(parameters);
        }

        public List<double> GenerateNumbers()
        {
            _generatedNumbers = new List<double>();
            foreach(var rand in _randomValues)
            {
                _generatedNumbers.Add(_a + (_b - _a) * rand);
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
