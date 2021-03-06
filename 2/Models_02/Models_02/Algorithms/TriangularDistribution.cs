﻿using System;
using System.Collections.Generic;
using Models_02.Interfaces;
using Models_02.Utils;

namespace Models_02.Algorithms
{
    class TriangularDistribution : IAlgorithm
    {
        private double _a;
        private double _b;
        private double _m;
        private readonly int _count = Tester.NumbersCount;
        private List<double> _randomValues;
        private List<double> _generatedNumbers;
        Random _rand;

        private TriangularDistribution(IDictionary<string, object> parameters)
        {
            _a = (double)parameters["a"];
            _b = (double)parameters["b"];
            _rand = new Random((int)DateTime.Now.Ticks);
        }


        private void GenerateRandomValues()
        {
            _randomValues = new List<double>();
            _randomValues.Add(_rand.NextDouble());
            _randomValues.Add(_rand.NextDouble());
        }


        public static TriangularDistribution Create(IDictionary<string, object> parameters)
        {
            return new TriangularDistribution(parameters);
        }

        public List<double> GenerateNumbers()
        {
            _generatedNumbers = new List<double>();
            for(int i = 0; i < _count; i++)
            {
                GenerateRandomValues();
                _generatedNumbers.Add(_a + (_b - _a) * Math.Max(_randomValues[0], _randomValues[1]));
            }

            return _generatedNumbers;
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
