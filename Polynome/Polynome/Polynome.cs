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
        private int degree;

        public Polynome(double[] coeffs)
        {
            while (coeffs.Last() == 0)
                coeffs = coeffs.Take(coeffs.Count() - 1).ToArray();

            this.coeffs = coeffs;
            degree = this.coeffs.Length - 1;
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
                        result = coeff.ToString();

                    else if (i == 1)
                        result = coeff.ToString() +"x" + result;

                    else
                        result = coeff.ToString() + "x^" + i.ToString() + result;

                    if (i + 1 < coeffs.Length && coeff > 0)
                        result = "+" + result;
                }
                
                i++;
               
            }
            if (result == "")
                result = "0";

            return result;
        }

        public static Polynome operator + (Polynome left, Polynome right)
        {
           
            Polynome smaller;
            Polynome bigger;
            int i = 0;
            if (left.Degree < right.Degree)
            {
                smaller = left;
                bigger = right;
            }
            else
            {
                smaller = right;
                bigger = left;
            }
            double[] coef = new double[bigger.Degree + 1];
            while (i <= smaller.Degree)
            {
                coef[i] = smaller.Coeffs[i] + bigger.Coeffs[i];
                i++;
            }
            while (i <= bigger.Degree)
            {
                coef[i] = bigger.Coeffs[i];
                i++;
            }
            return new Polynome(coef);
        }

        public int Degree
        {
            get { return degree; }
        }

        public double[] Coeffs
        {
            get { return coeffs; }
        }
    }
}
