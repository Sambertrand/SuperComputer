using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperComputer;

namespace Polynome
{
    public class Polynome
    {
        private double[] coeffs;

        public Polynome(double[] coeffs)
        {
            this.coeffs = coeffs;
        }

        public override string ToString()
        {
            string result = "";
            int i = 0;
            foreach(double coeff in coeffs)
            {
                if (coeff != 0)
                {
                    if (i == 0)
                    {
                        result = coeff.ToString();
                    }
                    else if (i == 1)
                    {
                        result = coeff.ToString() +"x" + result;
                    }
                    else
                    {
                        result = coeff.ToString() + "x^" + i.ToString() + result;
                    }
                    if (i+1 != coeffs.Count() && coeff > 0)
                    {
                        result = "+" + result;
                    }
                }
                i++;
               
            }
            return result;
        }
    }
}
