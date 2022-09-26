using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunAsHelper
{
    public partial class CustomArguments : Form
    {
        public CustomArguments()
        {
            InitializeComponent();
        }

        public string ReturnMessage { get; private set; }
        
        public void NullReturnMessage()
        {
            ReturnMessage = null;
        }



        private void Arguments_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                ReturnMessage = Arguments.Text;
                this.Close();
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ReturnMessage = Arguments.Text;
            this.Close();
        }
    }
}
