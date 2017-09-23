using System.Collections.Generic;

namespace Models_02.Interfaces
{
    public interface IAlgorithm
    {
        List<double> GenerateNumbers();

        double GetDispersion();

        double GetExpectancy();

        double GetAverage();
    }
}