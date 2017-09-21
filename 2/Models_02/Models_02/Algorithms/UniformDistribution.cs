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


        private UniformDistribution(IDictionary<string, object> parameters)
        {
            _n = (int)parameters["n"];
            _a = (double)parameters["a"];
            _b = (double)parameters["b"];

            _randomValues = new List<double>();
            Random rand = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < _n; i++)
            {
                _randomValues.Add(rand.NextDouble());
            }
        }


        public static UniformDistribution Create(IDictionary<string, object> parameters)
        {
            if(AreParamsValid(parameters))
            {
                return new UniformDistribution(parameters);
            }

            return null;
        }

        private static bool AreParamsValid(IDictionary<string, object> parameters)
        {
            var n = (int)parameters["n"];
            if(n < 2)
            {
                return false;
            }

            return true;
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
