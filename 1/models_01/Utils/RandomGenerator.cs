using System.Collections.Generic;
using models_01.Interfaces;

namespace models_01.Utils
{
    public class RandomGenerator
    {
        private IGeneratorParams _generatorParams;


        public RandomGenerator(IGeneratorParams generatorParams)
        {
            _generatorParams = generatorParams;
        }


        public IGeneratorParams GeneratorParams
        {
            set => _generatorParams = value;
        }


        public List<double> GenerateNumbers()
        {
            var numbers = new List<double>();
            var count = _generatorParams.M;
            var coefficient = _generatorParams.A;
            var r = _generatorParams.R0;

            for (int i = 0; i < count; i++)
            {
                r = (coefficient * r) % count;
                numbers.Add(r / count);
            }

            return numbers;
        }
    }
}
