using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Patrones.Command
{
    public class CreateFile : Command
    {
        string _path, _contents;

        public CreateFile(string description, string path, string contents)
            : base(description)
        {
            _path = path;
            _contents = contents;
        }

        public override void Execute()
        {
            File.WriteAllText(_path, _contents);
        }

        public override void Undo()
        {
            File.Delete(_path);
        }
    }
}
