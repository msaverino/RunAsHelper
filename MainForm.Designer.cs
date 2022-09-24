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
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ApplicationListBox
            // 
            this.ApplicationListBox.FormattingEnabled = true;
            this.ApplicationListBox.Location = new System.Drawing.Point(12, 12);
            this.ApplicationListBox.Name = "ApplicationListBox";
            this.ApplicationListBox.Size = new System.Drawing.Size(201, 121);
            this.ApplicationListBox.TabIndex = 0;
            this.ApplicationListBox.SelectedIndexChanged += new System.EventHandler(this.ApplicationListBox_SelectedIndexChanged);
            // 
            // ButtonExecute
            // 
            this.ButtonExecute.Location = new System.Drawing.Point(12, 139);
            this.ButtonExecute.Name = "ButtonExecute";
            this.ButtonExecute.Size = new System.Drawing.Size(198, 37);
            this.ButtonExecute.TabIndex = 2;
            this.ButtonExecute.Text = "Execute";
            this.ButtonExecute.UseVisualStyleBackColor = true;
            this.ButtonExecute.Click += new System.EventHandler(this.ButtonExecute_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(12, 182);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(96, 23);
            this.ButtonExit.TabIndex = 3;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(114, 182);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(96, 23);
            this.ButtonRefresh.TabIndex = 4;
            this.ButtonRefresh.Text = "Refresh";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 215);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonExecute);
            this.Controls.Add(this.ApplicationListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Run As Helper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ApplicationListBox;
        private System.Windows.Forms.Button ButtonExecute;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonRefresh;
    }
}

