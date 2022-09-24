﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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


        // Make a private variable to store the path to the XML file
        private string xmlPath = "Options.xml";

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
                ofd.Title = "Select the Options.xml file";
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
                    // UPdate the path to the XML file
                    xmlPath = ofd.FileName;
                }
            }



        }

        private void ModifyXMLDocument()
        {
            // Opens "Options.xml" in the default application
            System.Diagnostics.Process.Start("Options.xml");
        }
        

        private void ApplicationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // When the form loads - Call the function LoadRunAsOptions
            LoadRunAsOptions(xmlPath);
        }

        private void ButtonExecute_Click(object sender, EventArgs e)
        {
            // See if the user has selected an item from the list
            if (ApplicationListBox.SelectedItem != null)
            {
                // Get the selected item
                RunAs runAs = (RunAs)ApplicationListBox.SelectedItem;

                // Create the Process
                System.Diagnostics.Process.Start(runAs.Path);
            }
        }

        private void RefreshToolStrip_Click(object sender, EventArgs e)
        {
            // Reloads the content of the list box.
            ApplicationListBox.Items.Clear();
            LoadRunAsOptions(xmlPath);
        }

        private void ExitToolStrip_Click(object sender, EventArgs e)
        {
            // Confirm with the user wants to exit the application
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Close the application
                this.Close();
            }
        }

        private void OpenXMLToolStrip_Click(object sender, EventArgs e)
        {
        }

        private void ModifyXMLVSCodeToolStrip_Click(object sender, EventArgs e)
        {
            // Open Options.xml with VSCode
            // If the requested application is not found, open the XML in the default application.
            try
            {
                System.Diagnostics.Process.Start("code", "Options.xml");
            } catch
            {
                ModifyXMLDocument();
            }
        }

        private void ModifyXMLNPPPToolStrip_Click(object sender, EventArgs e)
        {

            // Open the Options.xml with Notepad ++
            // If the requested application is not found, open the XML in the default application.
            try
            {
                System.Diagnostics.Process.Start("C:\\Program Files\\Notepad++\\notepad++.exe", "Options.xml");
            }
            catch
            {
                ModifyXMLDocument();
            }
        }

        private void ModifyXMLNPToolStrip_Click(object sender, EventArgs e)
        {
            // Open the Options.xml with Notepad ++
            // If the requested application is not found, open the XML in the default application.
            try
            {
                System.Diagnostics.Process.Start("notepad", "Options.xml");
            }
            catch
            {
                ModifyXMLDocument();
            }
        }

        private void ModifyXMLDefaultToolStrip_Click(object sender, EventArgs e)
        {
            // Open Options.Xml with the default application
            ModifyXMLDocument();
        }

        private void RunAsAdminToolStrip_Click(object sender, EventArgs e)
        {
            if (ApplicationListBox.SelectedItem != null)
            {
                // Get the selected item
                RunAs runAs = (RunAs)ApplicationListBox.SelectedItem;

                // Create the process and run it as an administrator
                
            }
        }
    }
}
