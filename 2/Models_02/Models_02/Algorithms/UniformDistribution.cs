using System;
using System.Collections.Generic;
using Models_02.Interfaces;

namespace Models_02.Algorithms
{
    class UniformDistribution : IAlgorithm
    {
        private int _n;
        private double _a;
        private double _b;
        private List<double> _randomValues;


        public UniformDistribution(IDictionary<string, object> parameters)
        {
            _n = (int)parameters["n"];
            _a = (double)parameters["a"];
            _b = (double)parameters["b"];

            Random rand = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < _n; i++)
            {
                _randomValues.Add(rand.NextDouble());
            }
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
    }
}
