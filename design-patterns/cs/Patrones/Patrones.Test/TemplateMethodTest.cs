using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Patrones.TemplateMethod;
using Patrones;

namespace Patrones.Test
{
    [TestFixture]
    public class TemplateMethodTest
    {
        [Test]
        public void TestBasico()
        {
            var out1 = new HTMLReport().OutputReport();
            var out2 = new PlainTextReport().OutputReport();

            Assert.AreNotEqual(out1, out2);
        }
        
        [Test]
        public void TestCruzadoHTML()
        {
            var out1 = new HTMLReport().OutputReport();
            var out2 = new Strategy.Report(new Strategy.HTMLFormatter()).OutputReport();

            Assert.AreEqual(out1, out2);
        }

        [Test]
        public void TestCruzadoPlainText()
        {
            var out1 = new PlainTextReport().OutputReport();
            var out2 = new Strategy.Report(new Strategy.PlainTextFormatter()).OutputReport();

            Assert.AreEqual(out1, out2);
        }
    }
}
