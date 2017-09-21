using System.Collections.Generic;

namespace Models_02.Interfaces
{
    public interface ITester
    {
        double GetDispersion(IReadOnlyCollection<double> generatedNumbers, double m);

        double GetExpectancy(IReadOnlyCollection<double> generatedNumbers);
    }
}