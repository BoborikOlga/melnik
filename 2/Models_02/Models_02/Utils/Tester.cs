using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_02.Utils
{
    public class Tester
    {
        private static int _numbersCount;


        public static int NumbersCount
        {
            get => _numbersCount;
            set { _numbersCount = value; }
        }


        public static List<double> GetFrequencies(IReadOnlyCollection<double> generatedNumbers, int intervals, double intervalLength)
        {
            var frequencies = new List<double>();
            
            var hittingCounts = GetHittingCounts(generatedNumbers, intervals, intervalLength);
            foreach (var hittings in hittingCounts)
            {
                frequencies.Add(hittings / (double)generatedNumbers.Count);
            }

            return frequencies;
        }


        private static IReadOnlyCollection<int> GetHittingCounts(IReadOnlyCollection<double> generatedNumbers, int intervals, double intervalLength)
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
