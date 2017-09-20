using System.Collections.Generic;

namespace models_01.Interfaces
{
    public interface ITester
    {
        double CheckByIndirectSigns(List<double> generatedNumbers);

        int GetAperiodicLength(List<double> generatedNumbers, int period);

        double GetDispersion(IReadOnlyCollection<double> generatedNumbers, double m);

        double GetExpectancy(IReadOnlyCollection<double> generatedNumbers);

        List<double> GetFrequencies(IReadOnlyCollection<int> hittingCounts, int numbers);

        IReadOnlyCollection<int> GetHittingCounts(IReadOnlyCollection<double> generatedNumbers, int intervals, double intervalLength);

        int GetPeriod(List<double> generatedNumbers);
    }
}