using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperComputer;

namespace Average
{
    public class Average : Function<double>
    {
        private string name = "Average";
        public string Name
        {
            get { return name; }
        }

        private string help = "Average(serie de nombre divisés par un espace";
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
            return pool.Average();
        }
    }
}

