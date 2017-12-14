using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperComputer;

namespace StandartDeviation
{
    public class StandartDeviation : Function<double>
    {
        private string name = "StandartDeviation";
        public string Name
        {
            get { return name; }
        }
        

        private string help = "Calculates the standart deviation of a pool of numbers(I1,I2,I3,..., In-1, In)";
        public string HelpMessage
        {
            get { return help; }
        }
        private string[] paramname = { "I1", "I2", "I3", "...", "In - 1", "In" };
        public string[] ParametersName
        {
            get { return paramname; }
        }

        public double Evaluate(string[] args)
        {
            try
            {
                double[] pool = Array.ConvertAll(args, double.Parse);
                double result = 0;
                if (pool.Count() > 1)
                {
                    double avg = pool.Average();
                    double sum = pool.Sum(d => Math.Pow(d - avg, 2));
                    result = Math.Sqrt((sum) / (pool.Count() - 1));
                }
                else if(pool.Count() == 1)
                {
                    result = 0;
                }
                else
                {
                    throw new EvaluationException("Error: Put at least one number");
                }
                return result;
            }
            catch
            {
                throw new EvaluationException("Error : Follow the syntax");
            }
            
            
        }
    }
}