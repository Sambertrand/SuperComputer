using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SuperCalculator;

namespace SuperCalculator
{
    [TestFixture()]
    class TestComputer
    {
        string[] input;
        string[] output;
        SuperCalculator3000 test = new SuperCalculator3000("../dll");

        [SetUp()]
        public void Init()
        {

            input = new string[]
            {
                "coucou",
                "Average",
                "Roots 4",
                "Roots 2 0"
            };
            output = new string[]
            {
                "Unkwon command",
                "Wrong parameters",
                "[None]",
                "[0]"
            };
        }

        [Test()]
        public void TestCalcul()
        {
            for (int i = 0; i < input.Count(); i++)
            {
            Assert.AreEqual(output[i], test.GetCalcul(input[i]));
            }
        }
    }
}
