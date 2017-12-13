using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperComputer;

namespace Variance
{
    class Variance : Function<double>
    {
        private string name = "Variance";
        public string Name
        {
            get { return name; }
        }

        private string help = "enrée Variance(chiffre séparés d'un espace)";
        public string HelpMessage
        {
            get { return help; }
        }
        private string[] paramname = { "une pool de nombres" };
        public string[] ParametersName
        {
            get { return paramname; }
        }

        public double Evaluate(string[] args)
        {
            double[] pool = Array.ConvertAll(args, double.Parse);
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
    }
}
