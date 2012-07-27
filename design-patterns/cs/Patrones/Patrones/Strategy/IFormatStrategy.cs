using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patrones.Strategy
{
    public interface IFormatStrategy
    {
        string OutputReport(Report context);
    }
}
