using System.Collections.Generic;
using Models_02.Interfaces;
using System;

namespace Models_02.Utils
{
    public class RandomGenerator
    {
        private IDictionary<string, object> _generatorParams;
        private IAlgorithm _algorithm;


        public RandomGenerator(IDictionary<string, object> generatorParams, IAlgorithm algorithm)
        {
            _generatorParams = generatorParams;
            _randomValues = new List<double>();
            _algorithm = algorithm;
            
        }


        public IAlgorithm Algorithm
        {
            get { return _algorithm; }
            set { _algorithm = value; }
        }

        public List<double> GenerateNumbers()
        {
            return _algorithm.GenerateNumbers(_generatorParams);
        }
        
    }
}
