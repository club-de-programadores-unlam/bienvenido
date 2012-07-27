using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patrones.Command
{
    public class CompositeCommand : Command
    {
        IList<Command> commands = new List<Command>();

        public CompositeCommand() : base("") { }

        public void Add(Command command)
        {
            commands.Add(command);
        }

        #region Metodos Abstractos Implementados

        public override void Execute()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }

        public override void Undo()
        {
            foreach (var command in commands.Reverse())
            {
                command.Undo();
            }
        }

        public new string Description
        {
            get
            {
                string aux = string.Empty;
                foreach (var command in commands)
                {
                    aux += command.Description + Environment.NewLine;
                }

                return aux;
            }
        }

        #endregion
    }
}
