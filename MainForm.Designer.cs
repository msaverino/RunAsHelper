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
            this.SuspendLayout();
            // 
            // ApplicationListBox
            // 
            this.ApplicationListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplicationListBox.FormattingEnabled = true;
            this.ApplicationListBox.Location = new System.Drawing.Point(12, 12);
            this.ApplicationListBox.Name = "ApplicationListBox";
            this.ApplicationListBox.Size = new System.Drawing.Size(205, 134);
            this.ApplicationListBox.TabIndex = 0;
            this.ApplicationListBox.SelectedIndexChanged += new System.EventHandler(this.ApplicationListBox_SelectedIndexChanged);
            // 
            // ButtonExecute
            // 
            this.ButtonExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExecute.Location = new System.Drawing.Point(12, 152);
            this.ButtonExecute.Name = "ButtonExecute";
            this.ButtonExecute.Size = new System.Drawing.Size(205, 23);
            this.ButtonExecute.TabIndex = 2;
            this.ButtonExecute.Text = "Execute";
            this.ButtonExecute.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 190);
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
    }
}

