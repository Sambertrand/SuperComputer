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
                "coucou 3 4",
                "Average",
                "Average superman",
                "Average 1 2 3 4 5 6",
                "Derivate",
                "Derivate superman",
                "Derivate 1 2 4 3",
                "Derivate 0",
                "Roots",
                "Roots superman",
                "Roots 4",
                "Roots 2 0",
                "StandartDeviation",
                "StandartDeviation superman",
                "StandartDeviation 1 2 3 4 5 6",
                "Variance",
                "Variance superman",
                "Variance 1 2 3 4 5 6"
            };
            output = new string[]
            {
                "Unkwon command",
                "Unkwon command",
                "Wrong parameters",
                "Wrong parameters",
                "3.5",
                "Wrong parameters",
                "Wrong parameters",
                "3x^2+4x+4",
                "0",
                "Wrong parameters",
                "Wrong parameters",
                "[None]",
                "[0]",
                "Wrong parameters",
                "Wrong parameters",
                Math.Sqrt(3.5).ToString(),
                "Wrong parameters",
                "Wrong parameters",
                "3.5"
            };
        }

        [Test()]
        public void TestCalcul()
        {
            for (int i = 0; i < input.Count(); i++)
                Assert.AreEqual(output[i], test.GetCalcul(input[i]));
        }
    }
}
