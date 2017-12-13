using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperComputer;


namespace Polynome
{
    class PolDerivate : Function<Polynome>
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

        public Polynome Evaluate(string[] args)
        {
            double[] coeffs = Array.ConvertAll(args, double.Parse);
            Polynome polynome = new Polynome(coeffs);
            return polynome.Derivate();
        }
    }
}
