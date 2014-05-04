using System.Security.AccessControl;

namespace AssemblyUpdater
{
    partial class AssemblyUpdaterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssemblyUpdaterForm));
            this.ProfilesDropDownList = new System.Windows.Forms.ComboBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.EditProfileButton = new System.Windows.Forms.Button();
            this.RemoveProfileButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProfileSorcePathLabel = new System.Windows.Forms.Label();
            this.DestinationPathLabel = new System.Windows.Forms.Label();
            this.FileListLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProfilesDropDownList
            // 
            this.ProfilesDropDownList.FormattingEnabled = true;
            this.ProfilesDropDownList.Location = new System.Drawing.Point(12, 27);
            this.ProfilesDropDownList.Name = "ProfilesDropDownList";
            this.ProfilesDropDownList.Size = new System.Drawing.Size(237, 21);
            this.ProfilesDropDownList.TabIndex = 0;
            this.ProfilesDropDownList.SelectedValueChanged += new System.EventHandler(this.ProfilesDropDownListSelectedValueChanged);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(12, 54);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(75, 23);
            this.ExecuteButton.TabIndex = 1;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButtonClick);
            // 
            // EditProfileButton
            // 
            this.EditProfileButton.Location = new System.Drawing.Point(93, 54);
            this.EditProfileButton.Name = "EditProfileButton";
            this.EditProfileButton.Size = new System.Drawing.Size(75, 23);
            this.EditProfileButton.TabIndex = 2;
            this.EditProfileButton.Text = "Edit";
            this.EditProfileButton.UseVisualStyleBackColor = true;
            this.EditProfileButton.Click += new System.EventHandler(this.EditProfileButtonClick);
            // 
            // RemoveProfileButton
            // 
            this.RemoveProfileButton.Location = new System.Drawing.Point(174, 54);
            this.RemoveProfileButton.Name = "RemoveProfileButton";
            this.RemoveProfileButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveProfileButton.TabIndex = 3;
            this.RemoveProfileButton.Text = "Remove";
            this.RemoveProfileButton.UseVisualStyleBackColor = true;
            this.RemoveProfileButton.Click += new System.EventHandler(this.RemoveProfileButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sorce Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Destination Path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "File List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Profile Details";
            // 
            // ProfileSorcePathLabel
            // 
            this.ProfileSorcePathLabel.AutoSize = true;
            this.ProfileSorcePathLabel.Location = new System.Drawing.Point(98, 115);
            this.ProfileSorcePathLabel.Name = "ProfileSorcePathLabel";
            this.ProfileSorcePathLabel.Size = new System.Drawing.Size(95, 13);
            this.ProfileSorcePathLabel.TabIndex = 8;
            this.ProfileSorcePathLabel.Text = "No profile selected";
            // 
            // DestinationPathLabel
            // 
            this.DestinationPathLabel.AutoSize = true;
            this.DestinationPathLabel.Location = new System.Drawing.Point(98, 137);
            this.DestinationPathLabel.Name = "DestinationPathLabel";
            this.DestinationPathLabel.Size = new System.Drawing.Size(95, 13);
            this.DestinationPathLabel.TabIndex = 9;
            this.DestinationPathLabel.Text = "No profile selected";
            // 
            // FileListLabel
            // 
            this.FileListLabel.AutoSize = true;
            this.FileListLabel.Location = new System.Drawing.Point(98, 159);
            this.FileListLabel.Name = "FileListLabel";
            this.FileListLabel.Size = new System.Drawing.Size(95, 13);
            this.FileListLabel.TabIndex = 10;
            this.FileListLabel.Text = "No profile selected";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.profileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(259, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItemClick);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "&Profile";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem.Text = "&Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItemClick);
            // 
            // AssemblyUpdaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 237);
            this.Controls.Add(this.FileListLabel);
            this.Controls.Add(this.DestinationPathLabel);
            this.Controls.Add(this.ProfileSorcePathLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemoveProfileButton);
            this.Controls.Add(this.EditProfileButton);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.ProfilesDropDownList);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AssemblyUpdaterForm";
            this.Text = "Assembly Updater";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProfilesDropDownList;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Button EditProfileButton;
        private System.Windows.Forms.Button RemoveProfileButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProfileSorcePathLabel;
        private System.Windows.Forms.Label DestinationPathLabel;
        private System.Windows.Forms.Label FileListLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    }
}

