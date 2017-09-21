using System.Collections.Generic;
using Models_02.Interfaces;
using System;

namespace Models_02.Utils
{
    public class RandomGenerator
    {
        private IAlgorithm _algorithm;


        public RandomGenerator(IAlgorithm algorithm)
        {
            _algorithm = algorithm;            
        }


        public IAlgorithm Algorithm
        {
            get { return _algorithm; }
            set { _algorithm = value; }
        }

        public List<double> GenerateNumbers()
        {
            return _algorithm.GenerateNumbers();
        }
        
    }
}
