using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsHelper
{
    internal class UserConfig
    {
        // This is a constructor for the UserConfig class.
        public bool ConfirmExit { get; private set; }
        public string PathToConfig { get; private set; }

        // Create a new instance of the UserConfig class
        public UserConfig(bool confirmExit, string pathToConfig)
        {
            ConfirmExit = confirmExit;
            PathToConfig = pathToConfig;
        }

        // Return the path to the XML file
        public string GetPathToConfig()
        {
            return PathToConfig;
        }

        // Return the ConfirmExit value
        public bool GetConfirmExit()
        {
            return ConfirmExit;
        }

    }
}
