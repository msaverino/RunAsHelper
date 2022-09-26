namespace RunAsHelper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ApplicationListBox = new System.Windows.Forms.ListBox();
            this.ButtonExecute = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenXMLToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplicationListBox
            // 
            this.ApplicationListBox.FormattingEnabled = true;
            this.ApplicationListBox.Location = new System.Drawing.Point(9, 27);
            this.ApplicationListBox.Name = "ApplicationListBox";
            this.ApplicationListBox.Size = new System.Drawing.Size(215, 134);
            this.ApplicationListBox.TabIndex = 0;
            this.ApplicationListBox.SelectedIndexChanged += new System.EventHandler(this.ApplicationListBox_SelectedIndexChanged);
            // 
            // ButtonExecute
            // 
            this.ButtonExecute.Location = new System.Drawing.Point(9, 172);
            this.ButtonExecute.Name = "ButtonExecute";
            this.ButtonExecute.Size = new System.Drawing.Size(215, 37);
            this.ButtonExecute.TabIndex = 2;
            this.ButtonExecute.Text = "Execute";
            this.ButtonExecute.UseVisualStyleBackColor = true;
            this.ButtonExecute.Click += new System.EventHandler(this.ButtonExecute_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(236, 24);
            this.MenuStrip.TabIndex = 5;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshToolStrip,
            this.OpenXMLToolStrip,
            this.ExitToolStrip});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // RefreshToolStrip
            // 
            this.RefreshToolStrip.Name = "RefreshToolStrip";
            this.RefreshToolStrip.Size = new System.Drawing.Size(177, 22);
            this.RefreshToolStrip.Text = "Refresh Application";
            this.RefreshToolStrip.Click += new System.EventHandler(this.RefreshToolStrip_Click);
            // 
            // OpenXMLToolStrip
            // 
            this.OpenXMLToolStrip.Name = "OpenXMLToolStrip";
            this.OpenXMLToolStrip.Size = new System.Drawing.Size(177, 22);
            this.OpenXMLToolStrip.Text = "Modify XML";
            this.OpenXMLToolStrip.Click += new System.EventHandler(this.OpenXMLToolStrip_Click);
            // 
            // ExitToolStrip
            // 
            this.ExitToolStrip.Name = "ExitToolStrip";
            this.ExitToolStrip.Size = new System.Drawing.Size(177, 22);
            this.ExitToolStrip.Text = "Exit";
            this.ExitToolStrip.Click += new System.EventHandler(this.ExitToolStrip_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 221);
            this.Controls.Add(this.ButtonExecute);
            this.Controls.Add(this.ApplicationListBox);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Run As Helper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ApplicationListBox;
        private System.Windows.Forms.Button ButtonExecute;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenXMLToolStrip;
    }
}

