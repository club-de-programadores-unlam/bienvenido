using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Patrones.Command
{
    public class CopyFile : Command
    {
        string _source, _target, _previousContents;

        public CopyFile(string description, string source, string target)
            : base(description)
        {
            _source = source;
            _target = target;
        } 

        public override void Execute()
        {
            if (File.Exists(_target)) {
                _previousContents = File.ReadAllText(_target);
            }

            File.Copy(_source, _target);
        }

        public override void Undo()
        {
            File.WriteAllText(_target, _previousContents);
        }
    }
}
