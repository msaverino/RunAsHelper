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
            this.ModifyXMLVSCodeToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyXMLNPPPToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyXMLNPToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyXMLDefaultToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.RunAsAdminToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplicationListBox
            // 
            this.ApplicationListBox.FormattingEnabled = true;
            this.ApplicationListBox.Location = new System.Drawing.Point(9, 27);
            this.ApplicationListBox.Name = "ApplicationListBox";
            this.ApplicationListBox.Size = new System.Drawing.Size(201, 134);
            this.ApplicationListBox.TabIndex = 0;
            this.ApplicationListBox.SelectedIndexChanged += new System.EventHandler(this.ApplicationListBox_SelectedIndexChanged);
            // 
            // ButtonExecute
            // 
            this.ButtonExecute.Location = new System.Drawing.Point(9, 167);
            this.ButtonExecute.Name = "ButtonExecute";
            this.ButtonExecute.Size = new System.Drawing.Size(201, 37);
            this.ButtonExecute.TabIndex = 2;
            this.ButtonExecute.Text = "Execute";
            this.ButtonExecute.UseVisualStyleBackColor = true;
            this.ButtonExecute.Click += new System.EventHandler(this.ButtonExecute_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.RunAsAdminToolStrip});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(225, 24);
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
            this.RefreshToolStrip.Size = new System.Drawing.Size(180, 22);
            this.RefreshToolStrip.Text = "Refresh Application";
            this.RefreshToolStrip.Click += new System.EventHandler(this.RefreshToolStrip_Click);
            // 
            // OpenXMLToolStrip
            // 
            this.OpenXMLToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModifyXMLVSCodeToolStrip,
            this.ModifyXMLNPPPToolStrip,
            this.ModifyXMLNPToolStrip,
            this.ModifyXMLDefaultToolStrip});
            this.OpenXMLToolStrip.Name = "OpenXMLToolStrip";
            this.OpenXMLToolStrip.Size = new System.Drawing.Size(180, 22);
            this.OpenXMLToolStrip.Text = "Modify XML";
            this.OpenXMLToolStrip.Click += new System.EventHandler(this.OpenXMLToolStrip_Click);
            // 
            // ModifyXMLVSCodeToolStrip
            // 
            this.ModifyXMLVSCodeToolStrip.Name = "ModifyXMLVSCodeToolStrip";
            this.ModifyXMLVSCodeToolStrip.Size = new System.Drawing.Size(173, 22);
            this.ModifyXMLVSCodeToolStrip.Text = "Visual Studio Code";
            this.ModifyXMLVSCodeToolStrip.Click += new System.EventHandler(this.ModifyXMLVSCodeToolStrip_Click);
            // 
            // ModifyXMLNPPPToolStrip
            // 
            this.ModifyXMLNPPPToolStrip.Name = "ModifyXMLNPPPToolStrip";
            this.ModifyXMLNPPPToolStrip.Size = new System.Drawing.Size(173, 22);
            this.ModifyXMLNPPPToolStrip.Text = "Notepad ++";
            this.ModifyXMLNPPPToolStrip.Click += new System.EventHandler(this.ModifyXMLNPPPToolStrip_Click);
            // 
            // ModifyXMLNPToolStrip
            // 
            this.ModifyXMLNPToolStrip.Name = "ModifyXMLNPToolStrip";
            this.ModifyXMLNPToolStrip.Size = new System.Drawing.Size(173, 22);
            this.ModifyXMLNPToolStrip.Text = "Notepad";
            this.ModifyXMLNPToolStrip.Click += new System.EventHandler(this.ModifyXMLNPToolStrip_Click);
            // 
            // ModifyXMLDefaultToolStrip
            // 
            this.ModifyXMLDefaultToolStrip.Name = "ModifyXMLDefaultToolStrip";
            this.ModifyXMLDefaultToolStrip.Size = new System.Drawing.Size(173, 22);
            this.ModifyXMLDefaultToolStrip.Text = "Default";
            this.ModifyXMLDefaultToolStrip.Click += new System.EventHandler(this.ModifyXMLDefaultToolStrip_Click);
            // 
            // ExitToolStrip
            // 
            this.ExitToolStrip.Name = "ExitToolStrip";
            this.ExitToolStrip.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStrip.Text = "Exit";
            this.ExitToolStrip.Click += new System.EventHandler(this.ExitToolStrip_Click);
            // 
            // RunAsAdminToolStrip
            // 
            this.RunAsAdminToolStrip.Name = "RunAsAdminToolStrip";
            this.RunAsAdminToolStrip.Size = new System.Drawing.Size(95, 20);
            this.RunAsAdminToolStrip.Text = "Run As Admin";
            this.RunAsAdminToolStrip.Click += new System.EventHandler(this.RunAsAdminToolStrip_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 213);
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
        private System.Windows.Forms.ToolStripMenuItem ModifyXMLVSCodeToolStrip;
        private System.Windows.Forms.ToolStripMenuItem ModifyXMLNPPPToolStrip;
        private System.Windows.Forms.ToolStripMenuItem ModifyXMLNPToolStrip;
        private System.Windows.Forms.ToolStripMenuItem ModifyXMLDefaultToolStrip;
        private System.Windows.Forms.ToolStripMenuItem RunAsAdminToolStrip;
    }
}

