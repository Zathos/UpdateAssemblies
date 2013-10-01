namespace UpdateAssemblies
{
    partial class UpdateAssemblies
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
            this.PickPathButton = new System.Windows.Forms.Button();
            this.SelectProject = new System.Windows.Forms.ComboBox();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // PickPathButton
            // 
            this.PickPathButton.Location = new System.Drawing.Point(12, 65);
            this.PickPathButton.Name = "PickPathButton";
            this.PickPathButton.Size = new System.Drawing.Size(75, 23);
            this.PickPathButton.TabIndex = 0;
            this.PickPathButton.Text = "Path";
            this.PickPathButton.UseVisualStyleBackColor = true;
            this.PickPathButton.Click += new System.EventHandler(this.PickPathButton_Click);
            // 
            // SelectProject
            // 
            this.SelectProject.FormattingEnabled = true;
            this.SelectProject.Location = new System.Drawing.Point(12, 12);
            this.SelectProject.Name = "SelectProject";
            this.SelectProject.Size = new System.Drawing.Size(260, 21);
            this.SelectProject.TabIndex = 1;
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(12, 39);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(260, 20);
            this.PathTextBox.TabIndex = 2;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(12, 94);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 127);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.SelectProject);
            this.Controls.Add(this.PickPathButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PickPathButton;
        private System.Windows.Forms.ComboBox SelectProject;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

