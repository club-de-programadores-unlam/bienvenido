using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patrones.Strategy
{
    public class PlainTextFormatter : IFormatStrategy
    {
        public string OutputReport(Report context)
        {
            string aux = string.Empty;
            aux += "*****" + context.Title + "*****" + Environment.NewLine + Environment.NewLine;

            foreach (var item in context.Body)
            {
                aux += item + Environment.NewLine;
            }

            return aux;
        }
    }
}
