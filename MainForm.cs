using System;
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

        // Function to load the RunAsOptions
        private void LoadRunAsOptions()
        {
            // Create the XML Document Connection
            XmlDocument doc = new XmlDocument();
            doc.Load("Options.xml");

            foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node.Attributes[0].Value;
                string path = node["path"].InnerText;
                ApplicationListBox.Items.Add(new RunAs(name, path));
            }
        }
        

        private void ApplicationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // When the form loads - Call the function LoadRunAsOptions
            LoadRunAsOptions();
        }
    }
}
