using Models_02.Algorithms;
using Models_02.Interfaces;
using Models_02.Models;
using System.Collections.Generic;

namespace Models_02.Utils
{
    public class AlgorithmFactory
    {
        public static IAlgorithm Create(DistributionType distribution, IDictionary<string, object> parameters)
        {
            switch (distribution)
            {
                case DistributionType.Uniform:
                    {
                        return UniformDistribution.Create(parameters);
                    }
                case DistributionType.Exponential:
                    {
                        return ExponentialDistribution.Create(parameters);
                    }
                case DistributionType.Gamma:
                    {
                        return GammaDistribution.Create(parameters);
                    }
                case DistributionType.Simpson:
                    {
                        return SimpsonDistribution.Create(parameters);
                    }
                case DistributionType.Triangular:
                    {
                        return TriangularDistribution.Create(parameters);
                    }
                case DistributionType.Gaussian:
                    {
                        return GaussianDistribution.Create(parameters);
                    }
            }

            return null;
        }
    }
}
