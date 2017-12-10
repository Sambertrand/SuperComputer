using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stats
{
    public class Stats
    {
        private double[] pool;

        public Stats(double[] pool)
        {
            this.pool = pool;
        }
        //moyenne
        public double Average()
        {
            double average = pool.Average();
            return average;
        }

        //variance
        public double Variance()
        {
            double result = 0;
            if (pool.Count() > 1)
            {
                double avg = pool.Average();
                double sum = pool.Sum(d => Math.Pow(d - avg, 2));
                result = (sum) / (pool.Count() - 1);
            }
            else
            {
                result = 0;
            }
            return result;
        }

        //écart type
        public double StandartDeviation()
        {
            double result = 0;
            if (pool.Count() > 1)
            {
                double avg = pool.Average();
                double sum = pool.Sum(d => Math.Pow(d - avg, 2));
                result = Math.Sqrt((sum) / (pool.Count() - 1));
            }
            else
            {
                result = 0;
            }
            return result;
        }

    }
}
