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
                        if (coeff != 1)
                            result = coeff.ToString() +"x" + result;
                        else
                            result = "x" + result;
                    else
                        if (coeff != 1)
                            result = coeff.ToString() + "x^" + i.ToString() + result;
                        else
                            result = "x^" + i.ToString() + result;

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

        public double FindRootsLine()
        {
            double result;

            if (degree == 1)
                result = coeffs[0] / coeffs[1];
            else if (degree == 0)
                throw new Exception("Polynome cannot be of degree 0");
            else
            {
                Polynome polD = Derivate();
                while (polD.Degree > 1)
                    polD = polD.Derivate();
                result = polD.Coeffs[0] / polD.Coeffs[1];
            }
            return result;

        }

        private double newtmethod(double xo)
        {
            double xi = xo;
            int i = 0;
            while (Apply(xo) != 0 && i < 10000000)
            {
                if ((Math.Abs(Apply(xi)) <= Math.Abs(Apply(xo)) && i > 3) /*|| Derivate().Apply(xo) == 0*/)
                    throw new ArgumentException("Bad x0");
                xo = (-Apply(xo) / Derivate().Apply(xo)) + xo;
                i++;
            }
            return Math.Round(xo, 3);
        }

        public double Apply(double val)
        {
            double result = coeffs[0];
            int i = 1;
            while (i <= degree)
            {
                result += coeffs[i] * Math.Pow(val,i);
                i++;
            }
            return result;
        }
        
        public List<double> GetRoots()
        {
            List<double> roots = new List<double>();
            if (Degree == 1)
            {
                roots.Add(FindRootsLine());
            }
            if (Degree > 1)
            {
                List<double> extrems = Extremi();
                roots.Add(newtmethod(extrems.First() - 10));
                
                for (int i = 1; i < extrems.Count(); i++)
                {
                    roots.Add(newtmethod((extrems[i] - extrems[i - 1]) / 2.0)); 
                }

                roots.Add(newtmethod(extrems.Last() + 10));
            }
            return roots;
        }
        
        public List<double> Extremi()
        {
            List<double> extrems = Derivate().GetRoots();
            return extrems;
        }
    }
}
