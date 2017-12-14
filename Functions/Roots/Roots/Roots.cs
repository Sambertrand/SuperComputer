using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperComputer;

namespace Roots
{
    public class Roots : Function<List<double>>
    {
        private string name = "Roots";
        public string Name
        {
            get { return name; }
        }

        private string help = "Gives the roots of a polynome (be carefull, double roots will show twice).";
        public string HelpMessage
        {
            get { return help; }
        }

        private string[] paramname = { "coefficiant of x^n", "coefficiant of x^n-1", "coefficiant of x^n-2", "...", "coefficiant of x^0" };
        public string[] ParametersName
        {
            get { return paramname; }
        }

        public List<double> Evaluate(string[] args)
        {
            double[] coeffs;
            try
            {
                coeffs = (Array.ConvertAll(args, double.Parse));
                Array.Reverse(coeffs);
                Polynome.Polynome polynome = new Polynome.Polynome(coeffs);
                return polynome.Roots();
            }
            catch
            {
                throw new EvaluationException("Error : Follow the syntax.");
            }
        }
    }
}
