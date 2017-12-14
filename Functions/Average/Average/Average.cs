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

        private string help = "Calculates the average of a pool of numbers(a,b;c) like so:\nAverage a b c" ;
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
            try
            {
                double[] pool = Array.ConvertAll(args, double.Parse);
                if (pool.Count() > 0)
                {
                    return pool.Average();
                }
                else
                {
                    throw new EvaluationException("Error : Put at least one number");
                }
            }
            catch
            {
                throw new EvaluationException("Error : Follow the syntax");
            }
               
            
                
        }
    }
}

