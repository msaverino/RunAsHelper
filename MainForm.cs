using System;
using System.CodeDom;
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
        public void LoadRunAsOptions(string XPath)
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

                    // Check if the arguments node is null or empty
                    if (node["arguments"] == null || node["arguments"].InnerText == "")
                    {
                        // check if the promptForArguments node is null or empty
                        if (node["PromptForArguments"] == null || node["PromptForArguments"].InnerText == "" || node["PromptForArguments"].InnerText.ToLower() == "false")
                        {
                            // name, path, "", false
                            ApplicationListBox.Items.Add(new RunAs(name, path, "", false));
                        }
                        else
                        {
                            // name, path, "", true
                            ApplicationListBox.Items.Add(new RunAs(name, path, "", true));
                        }
                    }
                    else
                    {
                        // check if the promptForArguments node is null or empty
                        if (node["PromptForArguments"] == null || node["PromptForArguments"].InnerText == "" || node["PromptForArguments"].InnerText.ToLower() == "false")
                        {
                            // name, path, arguments, false
                            ApplicationListBox.Items.Add(new RunAs(name, path, node["arguments"].InnerText, false));
                        }
                        else
                        {
                            // name, path, arguments, true
                            ApplicationListBox.Items.Add(new RunAs(name, path, node["arguments"].InnerText, true));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                // Ask the user to locate the file
                appConfig.UpdateAppConfig();
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
            CustomArguments customArguments = new CustomArguments();
            
            // See if the user has selected an item from the list
            if (ApplicationListBox.SelectedItem != null)
            {
                // Get the selected item
                RunAs runAs = (RunAs)ApplicationListBox.SelectedItem;
                // Check if the user wants to prompt for arguments
                if (runAs.PromptForArguments == true)
                {
                    // Show the Custom Arguments form
                    // Show the form
                    customArguments.ShowDialog();
                    // Get the arguments from the form
                    string arguments = customArguments.ReturnMessage;
                    // if arguments is null or empty, then we don't want to run the application
                    if (arguments == null || arguments == "")
                    {
                        // Do nothing
                    }
                    else
                    {
                        if (runAs.Arguments.Contains("{Replace}"))
                        {
                            // replace the argument with the string
                            var modifiedString = runAs.Arguments.Replace("{Replace}", arguments);
                            // display a messagebox with the modified string
                            System.Diagnostics.Process.Start(runAs.Path, modifiedString);

                        }
                        else
                        {
                            // Execute the application
                            System.Diagnostics.Process.Start(runAs.Path, runAs.Arguments + " " + arguments);
                        }
                    }
                }
                // else if runAs.Arguments exists
                else if (runAs.Arguments != null || runAs.Arguments != "")
                {
                    System.Diagnostics.Process.Start(runAs.Path, runAs.Arguments);
                } else
                {
                    // User just wants to run the application
                    System.Diagnostics.Process.Start(runAs.Path);
                }

                //}
                //else
                //{
                //    // Run the application without arguments
                //    System.Diagnostics.Process.Start(runAs.Path);
                //}
                customArguments.NullReturnMessage();
            }

        }

        private void RefreshToolStrip_Click(object sender, EventArgs e)
        {
            // Reloads the content of the list box.
            ApplicationListBox.Items.Clear();
            appConfig.LoadAppConfig();

            LoadRunAsOptions(appConfig.RunAsXML);
            // loop 1 time
            for (int i = 0; i < 1; i++)
            {
                if (ApplicationListBox.Items.Count == 0)
                {
                    // re-run LoadRunAsOptions
                    LoadRunAsOptions(appConfig.RunAsXML);

                }
                else
                {
                    // break out of the loop
                    break;
                }
            }


            // Reloads the app config
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
