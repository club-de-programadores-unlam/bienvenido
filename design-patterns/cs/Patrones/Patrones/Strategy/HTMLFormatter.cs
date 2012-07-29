using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patrones.Strategy
{
    public class HTMLFormatter : IFormatStrategy
    {
        public string OutputReport(Report context)
        {
            string aux = string.Empty;

            aux += "<html>";
            aux += "<head>";
            aux += "<title>";
            aux += context.Title;
            aux += "</title>";
            aux += "</head>";

            aux += "<body>";
            foreach (var item in context.Body)
            {
                aux += "<p>" + item + "</p>";
            }
            aux += "</body>";

            aux += "</html>";
            return aux;
        }
    }
}
