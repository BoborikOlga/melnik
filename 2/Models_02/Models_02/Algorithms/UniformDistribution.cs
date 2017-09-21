using System;
using System.Collections.Generic;
using Models_02.Interfaces;

namespace Models_02.Algorithms
{
    class UniformDistribution : IAlgorithm
    {
        private double _a;
        private double _b;
        private const int _count = 10;
        private List<double> _randomValues;


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
            var numbers = new List<double>();
            foreach(var rand in _randomValues)
            {
                numbers.Add(_a + (_b - _a) * rand);
            }

            return numbers;
        }

        public double GetDispersion()
        {
            return (Math.Pow((_a - _b), 2)) / 12;
        }

        public double GetExpectancy()
        {
            return  (_a + _b) / 2;
        }

        public double GetAverage()
        {
            return Math.Sqrt(GetDispersion());
        }
    }
}
