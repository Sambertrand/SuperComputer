using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Polynome
{
    [TestFixture()]
    public class TestPolynome
    {

        private double[] coef1 = { 1, 2, 3, 0 };
        Polynome pol1;
        private double[] coef2 = { 1, -2, -3 };
        Polynome pol2;
        private double[] coef3 = { 0, -3 };
        Polynome pol3;
        private double[] coef4 = {2, 0};
        Polynome pol4;
        Polynome polP;

        [SetUp()]
        public void Init()
        {
            pol1 = new Polynome(coef1);
            pol2 = new Polynome(coef2);
            pol3 = new Polynome(coef3);
            pol4 = new Polynome(coef4);
        }


        [Test()]
        public void TestwritePol()
        {
            Assert.AreEqual("3x^2+2x+1", pol1.ToString());
            Assert.AreEqual("-3x^2-2x+1", pol2.ToString());
            Assert.AreEqual("-3x", pol3.ToString());
            Assert.AreEqual("2", pol4.ToString());
        }

        [Test()]
        public void TestPolDegree()
        {
            Assert.AreEqual(2, pol1.Degree);
            Assert.AreEqual(1, pol3.Degree);
        }

        [Test()]
        public void TestPolAdd()
        {
            polP = pol1 + pol2;
            Assert.AreEqual("2", polP.ToString());
            polP = pol1 + pol3 + pol4;
            Assert.AreEqual("3x^2-1x+3", polP.ToString());
        }
    }
}
