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

        readonly AppConfig appConfig = new AppConfig();

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
                    // Check if the arguments node exists
                    if (node["arguments"] != null)
                    {
                        string arguments = node["arguments"].InnerText;
                        // Add the RunAs option to the list
                        ApplicationListBox.Items.Add(new RunAs(name, path, arguments));
                    }
                    else
                    {
                        // Add the RunAs option to the list
                        ApplicationListBox.Items.Add(new RunAs(name, path, ""));
                    }
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
                        string arguments = node["arguments"].InnerText;

                        ApplicationListBox.Items.Add(new RunAs(name, path, arguments));
                    }
                    // Update the path to the XML file
                    //UpdateAppConfig(ofd.FileName);
                }
            }
        }

        private void ApplicationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // When the form loads, we want to Load the App Config information.
            appConfig.LoadAppConfig();


            LoadRunAsOptions(appConfig.RunAsXML);
            
        }

        private void ButtonExecute_Click(object sender, EventArgs e)
        {
            // See if the user has selected an item from the list
            if (ApplicationListBox.SelectedItem != null)
            {
                // Get the selected item
                RunAs runAs = (RunAs)ApplicationListBox.SelectedItem;
                // Check if the arguments are empty
                if (runAs.Arguments != "")
                {
                    // Run the application with the arguments
                    System.Diagnostics.Process.Start(runAs.Path, runAs.Arguments);
                }
                else
                {
                    System.Diagnostics.Process.Start(runAs.Path);

                }
            }

        }

        private void RefreshToolStrip_Click(object sender, EventArgs e)
        {
            // Reloads the content of the list box.
            ApplicationListBox.Items.Clear();
            LoadRunAsOptions(appConfig.RunAsXML);

            // Reloads the app config
            appConfig.LoadAppConfig();
        }

        private void ExitToolStrip_Click(object sender, EventArgs e)
        {
            // Confirm with the user wants to exit the application
            if(appConfig.ConfirmExit == true)
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


        // Functio to update the RunAs XML options.
        private void OpenXMLToolStrip_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(appConfig.PreferredEditor, appConfig.RunAsXML);
        }
       
    }
}
