using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Patrones.Strategy;

namespace Patrones.Test
{
    [TestFixture]
    public class StrategyTest
    {
        [Test]
        public void TestBasico()
        {
            var out1 = new Report(new HTMLFormatter()).OutputReport();
            var out2 = new Report(new PlainTextFormatter()).OutputReport();

            Assert.AreNotEqual(out1, out2);
        }
    }
}
