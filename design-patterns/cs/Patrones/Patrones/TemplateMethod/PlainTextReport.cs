using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patrones.TemplateMethod
{
    public class PlainTextReport : Report
    {
        protected override string OutputStart()
        {
            return string.Empty;
        }

        protected override string OutputHead()
        {
            return "*****" + Title + "*****" + Environment.NewLine + Environment.NewLine;
        }

        protected override string OutputBodyStart()
        {
            return string.Empty;
        }

        protected override string OutputBodyEnd()
        {
            return string.Empty;
        }

        protected override string OutputEnd()
        {
            return string.Empty;
        }

        protected override string OutputLine(string line)
        {
            return line + Environment.NewLine;
        }
    }
}
