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
        //moyenne variance et ecart type
        public double Average()
        {
            double sum = pool.Sum();
            double count = pool.Count();
            double average = sum / count;
            return average;
        }

        public

    }
}
