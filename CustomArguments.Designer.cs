namespace RunAsHelper
{
    partial class CustomArguments
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
            this.Arguments = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Arguments
            // 
            this.Arguments.Location = new System.Drawing.Point(12, 12);
            this.Arguments.Name = "Arguments";
            this.Arguments.Size = new System.Drawing.Size(346, 20);
            this.Arguments.TabIndex = 1;
            this.Arguments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Arguments_KeyDown);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(364, 10);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CustomArguments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 42);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.Arguments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustomArguments";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Custom Arguments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Arguments;
        private System.Windows.Forms.Button SubmitButton;
    }
}