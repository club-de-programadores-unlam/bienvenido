using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Patrones.Command;
using System.IO;

namespace Patrones.Test
{
    [TestFixture]
    public class CommandTest
    {
        const string FILE1 = "test.txt";
        const string FILE2 = "test2.txt";

        [SetUp]
        public void Init()
        {
            File.Delete(FILE1);
            File.Delete(FILE2);
        }

        [Test]
        public void TestBasico()
        {
            var composite = new CompositeCommand();
            composite.Add(new CreateFile("Creando Archivo", FILE1, "TEST"));
            composite.Add(new CopyFile("Copiando", FILE1, FILE2));
            composite.Add(new DeleteFile("Borrando", FILE1));
            var button = new Button(composite);

            button.Click();

            Assert.IsTrue(File.Exists(FILE2));
        }

        [Test]
        public void Descripcion()
        {
            var composite = new CompositeCommand();
            composite.Add(new CreateFile("a", FILE1, "TEST"));
            composite.Add(new CopyFile("b", FILE1, FILE2));
            composite.Add(new DeleteFile("c", FILE1));

            var desc = composite.Description;

            Assert.AreEqual(desc, "a\r\nb\r\nc\r\n");
        }
    }
}
