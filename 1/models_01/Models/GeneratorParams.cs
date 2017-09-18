using models_01.Interfaces;

namespace models_01.Models
{
    public class GeneratorParams : IGeneratorParams
    {
        private int _m;
        private double _a;
        private double _r0;


        public GeneratorParams(double a, double r0, int m)
        {
            _m = m;
            _a = a;
            _r0 = r0;
        }


        public int M => _m;

        public double A => _a;

        public double R0 => _r0;
    }
}
