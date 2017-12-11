using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynome
{
    public class Polynome
    {
        private double[] coeffs;
        public double[] Coeffs
        {
            get { return coeffs; }
        }

        private int degree;
        public int Degree
        {
            get { return degree; }
        }

        public Polynome(double[] coeffs)
        {
            while (coeffs.Last() == 0 && coeffs.Length > 1)
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
            double[] coefs = new double[bigger.Degree + 1];
            while (i <= smaller.Degree)
            {
                coefs[i] = smaller.Coeffs[i] + bigger.Coeffs[i];
                i++;
            }
            while (i <= bigger.Degree)
            {
                coefs[i] = bigger.Coeffs[i];
                i++;
            }
            return new Polynome(coefs);
        }

        public static Polynome operator - (Polynome left, Polynome right)
        {
            double[] invcoefs = new double[right.Degree + 1];
            int i = 0;
            while (i <= right.Degree)
            {
                invcoefs[i] = -right.Coeffs[i];
                i++;
            }
            Polynome invright = new Polynome(invcoefs);
            return left + invright;
        }

        public Polynome Derivate()
        {
            double[] coefs = new double[degree];
            int i = 1;
            while (i <= degree)
            {
                coefs[i - 1] = coeffs[i] * i;
                i++;
            }
            if (degree == 0)
                coefs = new double[] { 0 };
            return new Polynome(coefs);
        }

        public List<double> FindRoots()
        {
            List<double> result = new List<double>();
            double[] x;
            if (degree == 0)
                result = null;
            if (degree == 1)
                result.Add(coeffs[0] / coeffs[1]);
            while (x.Count() > 1)
            {
                x = this.Derivate().FindRoots();
            }
            else
            {
                result = newtmethod(x[0]);
            }
            return result;
        }

        private List<double> newtmethod(double x0)
        {
            double root;

            return null;
        }

    }
}
