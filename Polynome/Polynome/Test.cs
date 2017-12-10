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
       
        private double[] coef1 = {1, 2, 3 };
        Polynome pol1;
        private double[] coef2 = { 1, -2, -3 };
        Polynome pol2;

        [SetUp()]
        public void Init()
        {
            pol1 = new Polynome(coef1);
            pol2 = new Polynome(coef2);
        }


        [Test()]
        public void TestwriteName()
        {
            Assert.AreEqual("3x^2+2x+1", pol1.ToString());
            Assert.AreEqual("-3x^2-2x+1", pol2.ToString());
        }
        

    }
}
