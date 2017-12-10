using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperComputer;

namespace Stats
{
    class StandartDeviation : Function<double>
    {
        private string name = "StandartDeviation";
        public string Name
        {
            get { return name; }
        }

        private string help = "the help message will be written down here.... later";
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
            Stats Stats = new Stats(pool);
            return Stats.StandartDeviation();
        }
    }
}
