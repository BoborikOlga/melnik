﻿using System;
using System.Collections.Generic;
using Models_02.Interfaces;
using System.Windows.Forms;
using Models_02.Utils;

namespace Models_02.Algorithms
{
    class GammaDistribution : IAlgorithm
    {
        private int _n;
        private readonly int _count = Tester.NumbersCount;
        private List<double> _randomValues;
        private List<double> _generatedNumbers;
        private double _lambda;
        Random _rand;


        private GammaDistribution(IDictionary<string, object> parameters)
        {
            _n = (int)parameters["n"];
            _lambda = (double)parameters["lambda"];
            _rand = new Random((int)DateTime.Now.Ticks);
        }


        public static GammaDistribution Create(IDictionary<string, object> parameters)
        {
            if (AreParamsValid(parameters))
            {
                return new GammaDistribution(parameters);
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
            if (n < 2)
            {
                MessageBox.Show("To little value of n, try higher");

                return false;
            }
            var lambda = (double)parameters["lambda"];
            if (lambda < 0)
            {
                MessageBox.Show("To little value of lambda, try higher");

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
                _generatedNumbers.Add(((-1) / _lambda) * Math.Log(Multiplicate(_randomValues)));
            }

            return _generatedNumbers;
        }

        private double Multiplicate(IReadOnlyCollection<double> values)
        {
            double mul = 1;
            foreach(var value in values)
            {
                mul *= value;
            }

            return mul;
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
