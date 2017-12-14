using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperComputer;

namespace Derivate
{
    public class Derivate : Function<Polynome.Polynome>
    {
        private string name = "Derivate";
        public string Name
        {
            get { return name; }
        }

        private string help = "Give the derivate of a polynome.";
        public string HelpMessage
        {
            get { return help; }
        }

        private string[] paramname = { "coefficiant of x^n", "coefficiant of x^n-1", "coefficiant of x^n-2", "...", "coefficiant of x^0" };
        public string[] ParametersName
        {
            get { return paramname; }
        }

        public Polynome.Polynome Evaluate(string[] args)
        {
            double[] coeffs;
            try
            {
                coeffs = (Array.ConvertAll(args, double.Parse)) ;
                Array.Reverse(coeffs);
                Polynome.Polynome polynome = new Polynome.Polynome(coeffs);
                return polynome.Derivate();
            }
            catch
            {
                throw new EvaluationException("Error : Follow the syntax.");
            }
        }
    }
}
