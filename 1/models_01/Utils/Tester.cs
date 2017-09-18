using models_01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace models_01.Utils
{
    public class Tester : ITester
    {
        public int GetAperiodicLength(List<double> generatedNumbers, int period)
        {
            var index = generatedNumbers.Count;
            for (int i = 0; i + period < generatedNumbers.Count && generatedNumbers.Count == index; i++)
            {
                if (generatedNumbers[i] == generatedNumbers[i + period])
                {
                    index = i;
                }
            }

            return index + period;
        }

        public int GetPeriod(List<double> generatedNumbers)
        {
            var last = generatedNumbers.Last();
            var firstEqualIndex = generatedNumbers.Count;
            for (int i = generatedNumbers.Count - 2; i >= 0 && firstEqualIndex == generatedNumbers.Count; i--)
            {
                if (generatedNumbers[i] == last)
                {
                    firstEqualIndex = i;
                }
            }
            if (firstEqualIndex == generatedNumbers.Count)
            {
                return generatedNumbers.Count;
            }
            var secondEqualIndex = firstEqualIndex;
            for (int i = firstEqualIndex - 1; i >= 0 && secondEqualIndex == firstEqualIndex; i--)
            {
                if (generatedNumbers[i] == last)
                {
                    secondEqualIndex = i;
                }
            }
            if (secondEqualIndex == firstEqualIndex)
            {
                return secondEqualIndex;
            }

            return firstEqualIndex - secondEqualIndex;
        }

        public double CheckByIndirectSigns(List<double> generatedNumbers)
        {
            var couples = 0;
            for (int i = 0; i + 2 <= generatedNumbers.Count; i += 2)
            {
                if (generatedNumbers[i] + generatedNumbers[i + 1] < 1)
                {
                    couples++;
                }
            }

            return 2 * couples / (double)generatedNumbers.Count;
        }

        public double GetExpectancy(IReadOnlyCollection<double> generatedNumbers)
        {
            return generatedNumbers.Sum() / generatedNumbers.Count;
        }

        public double GetMedium(IReadOnlyCollection<double> generatedNumbers, double expectancy)
        {
            double sum = 0;
            foreach (var number in generatedNumbers)
            {
                sum += Math.Pow(number - expectancy, 2);
            }

            return sum / generatedNumbers.Count;
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

        public List<double> GetFrequencies(IReadOnlyCollection<int> hittingCounts, int numbers)
        {
            var frequencies = new List<double>();
            foreach (var hittings in hittingCounts)
            {
                frequencies.Add(hittings / (double)numbers);
            }

            return frequencies;
        }

        public IReadOnlyCollection<int> GetHittingCounts(IReadOnlyCollection<double> generatedNumbers, int intervals, double intervalLength)
        {
            var hittingCounts = new int[intervals];
            if (intervalLength == 0)
            {
                hittingCounts[0] = generatedNumbers.Count;

                return hittingCounts;
            }

            var min = generatedNumbers.Min();
            foreach (var value in generatedNumbers)
            {
                int intervalNumber = Convert.ToInt32(Math.Truncate((value - min) / intervalLength));
                if (intervalNumber == intervals)
                {
                    intervalNumber--;
                }
                hittingCounts[intervalNumber]++;
            }

            return hittingCounts;
        }
    }
}
