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
        double result;
        double expected;
        private double[] coef1 = { 1, 2, 3, 0 };
        Polynome pol1;
        private double[] coef2 = { 1, -2, -3 };
        Polynome pol2;
        private double[] coef3 = { 0, 0, -3 };
        Polynome pol3;
        private double[] coef4 = { 2, 0 };
        Polynome pol4;
        Polynome polP;
        Polynome polS;
        Polynome polD;

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
            Assert.AreEqual("-3x^2", pol3.ToString());
            Assert.AreEqual("2", pol4.ToString());
        }

        [Test()]
        public void TestPolDegree()
        {
            Assert.AreEqual(2, pol1.Degree);
            Assert.AreEqual(0, pol4.Degree);
        }

        [Test()]
        public void TestPolAdd()
        {
            polP = pol1 + pol2;
            Assert.AreEqual("2", polP.ToString());
            polP = pol1 + pol3 + pol4;
            Assert.AreEqual("2x+3", polP.ToString());
        }
        [Test()]
        public void TestPolSub()
        {
            polS = pol1 - pol1;
            Assert.AreEqual("0", polS.ToString());
            polS = pol1 - pol2 - pol4;
            Assert.AreEqual("6x^2+4x-2", polS.ToString());
        }
        [Test()]
        public void TestPolDeriv()
        {
            polD = pol1.Derivate();
            Assert.AreEqual("6x+2", polD.ToString());
            polD.Derivate();
            Assert.AreEqual("6x+2", polD.ToString());
            polD = polD.Derivate();
            Assert.AreEqual("6", polD.ToString());
            polD = polD.Derivate();
            Assert.AreEqual("0", polD.ToString());
        }

        [Test()]
        public void TestPolRootl()
        {
            result = pol1.FindRootsLine();
            expected =  2.0 / 6.0 ;
            Assert.AreEqual(expected, result);
        }
        [Test()]
        public void TestPolApply()
        {
            result = pol1.Apply(2);
            expected = 17;
            Assert.AreEqual(expected, result);
            result = pol4.Apply(2);
            expected = 2;
            Assert.AreEqual(expected, result);
            result = pol3.Apply(0);
            expected = 0;
            Assert.AreEqual(expected, result);


        }

        [Test()]
        public void TestPolNewt()
        {
            result = pol3.newtmethod(10);
            Assert.LessOrEqual(pol3.Apply(result), 0.01);
            Assert.GreaterOrEqual(pol3.Apply(result), -0.01);
            
            result = pol2.newtmethod(-3);
            Assert.LessOrEqual(result, 1.01);
            Assert.GreaterOrEqual(result, 0.99);
        }
    }
}
