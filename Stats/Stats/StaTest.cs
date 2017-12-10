using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Stats
{
    class StaTest
    {
        [TestFixture()]
        public class TestStats
        {
            private double[] input1 = {1, 2, 3, 4, 5, 6};
            Stats Stat1;
            private double[] input2 = { -1, -2, -3, -4, -5, -6 };
            Stats Stat2;
            private double[] input3 = {1};
            Stats Stat3;

            [SetUp()]
            public void Init()
            {
                Stat1 = new Stats(input1);
                Stat2 = new Stats(input2);
                Stat3 = new Stats(input3);
            }

            [Test()]
            public void TestAvg()
            {
                Assert.AreEqual(3.5, Stat1.Average());
                Assert.AreEqual(-3.5, Stat2.Average());
                Assert.AreEqual(1, Stat3.Average());
            }

            [Test()]
            public void TestVar()
            {
                Assert.AreEqual(3.5, Stat1.Variance());
                Assert.AreEqual(3.5, Stat2.Variance());
                Assert.AreEqual(0, Stat3.Variance());
            }
            [Test()]
            public void TestStdVar()
            {
                Assert.AreEqual(Math.Sqrt(3.5), Stat1.StandartDeviation());
                Assert.AreEqual(Math.Sqrt(3.5), Stat2.StandartDeviation());
                Assert.AreEqual(0, Stat3.StandartDeviation());
            }


        }

    }
}
