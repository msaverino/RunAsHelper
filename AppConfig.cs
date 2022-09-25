using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RunAsHelper
{
    internal class AppConfig
    {

        private readonly string AppDataConfig = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RunAs", "Config.xml");
        private readonly string AppDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RunAs");
        public string RunAsXML { get; private set; }
        public bool ConfirmExit { get; private set; }
        public string PreferredEditor { get; private set; }


        public void LoadAppConfig()
        {
            // Debugging purposes only
            // Remove the config file
            //File.Delete(AppDataConfig);

            // Check if the Config.xml file exists in the AppData folder
            if (File.Exists(AppDataConfig))
            {

                //Get each line of the config file.


                // The file exists.
                var xml = new XmlDocument();
                xml.Load(AppDataConfig);
                // Get the ConfirmExit value
                var confirmExit = xml.SelectSingleNode("RunAs/ConfirmExit").InnerText;
                // Get the XML Path for the applications to run
                var xmlForApplicationsToRun = xml.SelectSingleNode("RunAs/PathToXML").InnerText;
                // Get the preferred editor
                var preferredEditor = xml.SelectSingleNode("RunAs/PreferredEditor").InnerText;

                // Set the values
                RunAsXML = xmlForApplicationsToRun;
                ConfirmExit = Convert.ToBoolean(confirmExit);
                PreferredEditor = preferredEditor;
            }
            else
            {
                CreateAppConfig();
            }
        }

        private void CreateAppConfig()
        {
            // Check if the RunAs folder exists in the AppData folder
            if (!Directory.Exists(AppDataFolder))
            {
                // The folder does not exist, create it
                Directory.CreateDirectory(AppDataFolder);
            }

            


            // Create a new file
            XmlWriter config = new XmlTextWriter(AppDataConfig, null);
            // Write the XML file
            config.WriteStartDocument();
            config.WriteStartElement("RunAs");
            config.WriteStartElement("ConfirmExit");
            config.WriteString("True");
            config.WriteEndElement();
            config.WriteStartElement("PathToXML");
            config.WriteString("RunAs.xml");
            config.WriteEndElement();
            config.WriteStartElement("PreferredEditor");
            config.WriteString("Notepad.exe");
            config.WriteEndElement();
            config.WriteEndElement();
            // Close the XML file
            config.WriteEndDocument();
            config.Close();
            // Set the values
            RunAsXML = "RunAs.xml";
            ConfirmExit = true;
            PreferredEditor = "Notepad.exe";

        }
    }
}
