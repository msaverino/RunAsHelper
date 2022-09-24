using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsHelper
{
    internal class RunAs
    {

        // This is the constructor for the RunAs class.
        public string Name { get; private set; }
        public string Path { get; private set; }

        public RunAs(string name, string path)
        {
            Name = name;
            Path = path;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
