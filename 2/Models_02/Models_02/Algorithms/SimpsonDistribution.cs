using System;
using System.Collections.Generic;
using Models_02.Interfaces;
using System.Windows.Forms;
using Models_02.Utils;

namespace Models_02.Algorithms
{
    class SimpsonDistribution : IAlgorithm
    {
        private readonly int _count = Tester.NumbersCount;
        private double _a;
        private double _b;
        private List<double> _randomValuesY;
        private List<double> _randomValuesZ;
        private List<double> _generatedNumbers;
        private double _expectancy;
        

        private SimpsonDistribution(IDictionary<string, object> parameters)
        {
            _a = (double)parameters["a"];
            _b = (double)parameters["b"];
            GenerateRandomValues();
        }


        public static SimpsonDistribution Create(IDictionary<string, object> parameters)
        {
            return new SimpsonDistribution(parameters);
        }
        

        private void GenerateRandomValues()
        {
            _randomValuesZ = new List<double>();
            _randomValuesY = new List<double>();
            Random randY = new Random((int)DateTime.Now.Ticks);
            Random randZ = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < _count; i++)
            {
                _randomValuesY.Add(randY.NextDouble() * (_b / 2 - _a / 2) + _a / 2);
                _randomValuesZ.Add(randZ.NextDouble() * (_b / 2 - _a / 2) + _a / 2);
            }
        }

        public List<double> GenerateNumbers()
        {
            _generatedNumbers = new List<double>();
            
            for(int i = 0; i < _count; i++)
            {
                _generatedNumbers.Add(_randomValuesY[i] + _randomValuesZ[i]);
            }

            return _generatedNumbers;
        }

        public double GetDispersion()
        {
            double d = 0;
            var m = GetExpectancy();

            foreach (var number in _generatedNumbers)
            {
                d = d + Math.Pow((number - m), 2);
            }
            d = d / _generatedNumbers.Count;
            d = d * _generatedNumbers.Count / (_generatedNumbers.Count - 1);

            return d;
        }

        public double GetExpectancy()
        {
            _expectancy = 0;
            foreach (var number in _generatedNumbers)
            {
                _expectancy += number;
            }

            return _expectancy / _generatedNumbers.Count;
        }

        public double GetAverage()
        {
            return Math.Sqrt(GetDispersion());
        }
    }
}
