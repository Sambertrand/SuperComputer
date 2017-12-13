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

        private string help = "this is a help message";
        public string HelpMessage
        {
            get { return help; }
        }

        private string[] paramname = { "Un polynome" };
        public string[] ParametersName
        {
            get { return paramname; }
        }

        public Polynome.Polynome Evaluate(string[] args)
        {
            double[] coeffs = Array.ConvertAll(args, double.Parse);
            Polynome.Polynome polynome = new Polynome.Polynome(coeffs);
            return polynome.Derivate();
        }
    }
}
