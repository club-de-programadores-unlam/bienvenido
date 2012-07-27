using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patrones.Command
{
    public class Button
    {
        private Command command;

        public Button(Command command)
        {
            this.command = command;
        }

        public void Click()
        {
            this.command.Execute();
        }
    }
}
