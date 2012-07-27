using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Patrones.Command
{
    public class DeleteFile : Command
    {
        string _path, _previousContents;

        public DeleteFile(string description, string path) : base(description) {
            _path = path;
        }

        public override void Execute()
        {
            if (File.Exists(_path)) {
                _previousContents = File.ReadAllText(_path);
            }

            File.Delete(_path);
        }

        public override void Undo()
        {
            File.WriteAllText(_path, _previousContents);
        }
    }
}
