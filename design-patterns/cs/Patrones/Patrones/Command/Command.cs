using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patrones.Command
{
    public abstract class Command
    {
        public string Description { get; private set; }

        public Command(string description)
        {
            Description = description;
        }

        #region Metodos Abstractos

        public abstract void Execute();
        public abstract void Undo();

        #endregion
    }
}
