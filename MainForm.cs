using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RunAsHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool ConfirmExit = true;
        private string PathToConfig = "runas.xml";
        private readonly string AppDataConfig = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RunAs", "Config.xml");
        private readonly string AppDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RunAs");
        private string PreferedEditor = "notepad.exe";


        private void LoadUserOptions()
        {
            // Check if the Config.Xml file exists in %Appdata%\RunAs\Config.xml


            if (File.Exists(AppDataConfig))
            {
                // Read the XML file
                var xml = new XmlDocument();
                xml.Load(AppDataConfig);
                // Get the ConfirmExit value
                var confirmExit = xml.SelectSingleNode("RunAs/ConfirmExit").InnerText;
                // Get the PathToConfig value
                var pathToConfig = xml.SelectSingleNode("RunAs/PathToConfig").InnerText;
                var preferedEditor = xml.SelectSingleNode("RunAs/PreferedEditor").InnerText;
                
                // Assign the variables to the UserConfig class
                ConfirmExit = Convert.ToBoolean(confirmExit);
                PathToConfig = pathToConfig;
                PreferedEditor = preferedEditor;
                
            }
            else
            {
                // Create the %Appdata%\RunAs folder (if it doesn't exist)
                if (!Directory.Exists(AppDataFolder))
                {
                    Directory.CreateDirectory(AppDataFolder);
                }
                // Set the default values for the XML file
                var confirmExit = ConfirmExit;
                var pathToConfig = PathToConfig;
                // Create a new file
                XmlWriter config = new XmlTextWriter(AppDataConfig, null);
                // Write the XML file
                config.WriteStartDocument();
                config.WriteStartElement("RunAs");
                config.WriteStartElement("ConfirmExit");
                config.WriteString(ConfirmExit.ToString());
                config.WriteEndElement();
                config.WriteStartElement("PathToConfig");
                config.WriteString(PathToConfig);
                config.WriteEndElement();
                config.WriteStartElement("PreferedEditor");
                config.WriteString(PreferedEditor);
                config.WriteEndElement();
                config.WriteEndElement();
                // Close the XML file
                config.WriteEndDocument();
                config.Close();

            }

            
        }

        // Update the Path to Config XML
        private void UpdateAppConfig(string path)
        {
            // Open the config XML File
            XmlDocument doc = new XmlDocument();
            doc.Load(AppDataConfig);
            doc.SelectSingleNode("RunAs/PathToConfig").InnerText = path;
            // Save the config
            doc.Save(AppDataConfig);
            PathToConfig = path;
        }
    
        // Function to load the RunAsOptions
        private void LoadRunAsOptions(string XPath)
        {
            // Create the XML Document Connection
            XmlDocument doc = new XmlDocument();
            
            try
            {
                // Load the XML file
                doc.Load(XPath);
                foreach (XmlNode node in doc.DocumentElement)
                {
                    string name = node.Attributes[0].Value;
                    string path = node["path"].InnerText;
                    ApplicationListBox.Items.Add(new RunAs(name, path));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                // Ask the user to locate the file
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "XML File|*.xml";
                ofd.Title = "Select the runas.xml file";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Load the XML file
                    doc.Load(ofd.FileName);
                    foreach (XmlNode node in doc.DocumentElement)
                    {
                        string name = node.Attributes[0].Value;
                        string path = node["path"].InnerText;
                        ApplicationListBox.Items.Add(new RunAs(name, path));
                    }
                    // Update the path to the XML file
                    UpdateAppConfig(ofd.FileName);
                }
            }
        }
        
        private void RunWithoutParams(string path)
        {

            // Create the Process
            System.Diagnostics.Process.Start(path);
        }

        private void ModifyRunAsXMLDocument()
        {
            // Opens "runas.xml" in the default application
            System.Diagnostics.Process.Start("runas.xml");
        }
        

        private void ApplicationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // When the form loads - Call the function LoadRunAsOptions
            LoadUserOptions();
            LoadRunAsOptions(PathToConfig);
            
        }

        private void ButtonExecute_Click(object sender, EventArgs e)
        {
            // See if the user has selected an item from the list
            if (ApplicationListBox.SelectedItem != null)
            {
                // Get the selected item
                RunAs runAs = (RunAs)ApplicationListBox.SelectedItem;

                RunWithoutParams(runAs.Path);
            }

        }

        private void RefreshToolStrip_Click(object sender, EventArgs e)
        {
            // Reloads the content of the list box.
            ApplicationListBox.Items.Clear();
            LoadRunAsOptions(PathToConfig);
        }

        private void ExitToolStrip_Click(object sender, EventArgs e)
        {
            // Confirm with the user wants to exit the application
            if(ConfirmExit == true)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Close the application
                    this.Close();
                }
            } else
            {
                this.Close();
            }

        }

        private void OpenXMLToolStrip_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(PreferedEditor, PathToConfig);
        }


        private void ModifyXMLDefaultToolStrip_Click(object sender, EventArgs e)
        {
            // Open runas.xml with the default application
            ModifyRunAsXMLDocument();
        }
       
    }
}
