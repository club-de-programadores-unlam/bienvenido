using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patrones.TemplateMethod
{
    public class HTMLReport : Report
    {
        protected override string OutputStart()
        {
            return "<html>";
        }

        protected override string OutputHead()
        {
            string aux = string.Empty;

            aux += "<head>";
            aux += "<title>";
            aux += Title;
            aux += "</title>";
            aux += "</head>";

            return aux;
        }

        protected override string OutputBodyStart()
        {
            return "<body>";
        }

        protected override string OutputBodyEnd()
        {
           return  "</body>";
        }

        protected override string OutputEnd()
        {
            return "</html>";
        }

        protected override string OutputLine(string line)
        {
            return "<p>" + line + "</p>";
        }
    }
}
