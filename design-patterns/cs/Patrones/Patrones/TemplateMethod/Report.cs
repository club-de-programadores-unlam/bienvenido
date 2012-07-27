using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patrones.TemplateMethod
{
    public abstract class Report
    {
        public string Title { get; private set; }
        public List<String> Body { get; private set; }

        public Report()
        {
            Title = "Esto es un titulo";
            Body = new List<string>();
            Body.Add("Esto es un texto...");
            Body.Add("Esto es otro texto...");
        }

        public string OutputReport()
        {
            string aux = string.Empty;

            aux += OutputStart();
            aux += OutputHead();
            aux += OutputBodyStart();
            aux += OutputBody();
            aux += OutputBodyEnd();
            aux += OutputEnd();

            return aux;
        }

        protected abstract string OutputStart();
        protected abstract string OutputHead();
        protected abstract string OutputBodyStart();
        protected abstract string OutputBodyEnd();
        protected abstract string OutputEnd();
        protected abstract string OutputLine(string line);

        protected string OutputBody()
        {
            string aux = string.Empty;
            foreach (var item in Body)
            {
                aux += OutputLine(item);
            }

            return aux;
        }
    }
}
