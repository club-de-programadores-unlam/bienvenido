using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patrones.Strategy
{
    public class Report
    {
        public string Title {get; private set;}
        public List<String> Body { get; private set; }
        IFormatStrategy _formatter;

        public Report(IFormatStrategy formatter)
        {
            _formatter = formatter;
  
            Title = "Esto es un titulo";
            Body = new List<string>();
            Body.Add("Esto es un texto...");
            Body.Add("Esto es otro texto...");
         }

        public string OutputReport()
        {
           return _formatter.OutputReport(this);
        }
    }
}
