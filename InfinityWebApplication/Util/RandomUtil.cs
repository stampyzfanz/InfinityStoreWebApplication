using System;

namespace InfinityWebApplication.Util
{
    public class RandomUtil : IRandomUtil
    {
        public RandomUtil()
        {
            _rand = new Random();
        }

        private readonly Random _rand;

        // For example, if you want to see whether a coin flips heads, call DoesEventOccur(0.5m)
        public bool DoesEventOccur(double probability)
        {
            return _rand.NextDouble() < probability;
        }

        public double GetRandomGuassian(double min, double max, int skew)
        {
            // This was translated from JS -> C# from https://stackoverflow.com/a/49434653
            // Since NextDouble() -> [0, 1) u > 0
            double u = 1.0 - _rand.NextDouble();
            double v = 1.0 - _rand.NextDouble();

            double num = Math.Sqrt(-2.0 * Math.Log(u)) *
                         Math.Cos(2.0 * Math.PI * v);
            num = num / 10.0 + 0.5;
            if (num > 1 || num < 0)
            {
                // Resample between 0 and 1 if out of range
                num = this.GetRandomGuassian(min, max, skew);
            }
            else
            {
                // Skew the number
                num = Math.Pow(num, skew);
                // Stretch to fill range
                num *= max - min;
                // Offset to min
                num += min;
            }
            return num;
        }
    }

    public interface IRandomUtil
    {
        double GetRandomGuassian(double min, double max, int skew);
        bool DoesEventOccur(double probability);
    }
}