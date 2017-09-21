using Models_02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Models_02.Utils
{
    public class Tester: ITester
    {
        public double GetExpectancy(IReadOnlyCollection<double> generatedNumbers)
        {
            return generatedNumbers.Sum() / generatedNumbers.Count;
        }

        public double GetDispersion(IReadOnlyCollection<double> generatedNumbers, double m)
        {
            double d = 0;

            foreach (var number in generatedNumbers)
            {
                d = d + Math.Pow((number - m), 2);
            }
            d = d / generatedNumbers.Count;
            d = d * generatedNumbers.Count / (generatedNumbers.Count - 1);

            return d;
        }
    }
}
