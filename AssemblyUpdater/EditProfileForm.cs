using System;
using System.Linq;
using System.Windows.Forms;
using AssemblyUpdater.DTOs;

namespace AssemblyUpdater
{
    public partial class EditProfileForm : Form
    {
        public EditProfileForm(ProcessModel processModel, Profile profile)
        {
            _processModel = processModel;
            _profile = profile;
            InitializeComponent();
        }

        private void CheckForPendingChangesOnClose()
        {
            if (_pendingChanges)
            {
                MessageBox.Show("Do you want to save changes to profile before closing?", "Save Pending Changes", MessageBoxButtons.YesNo);
            }
        }

        private string GetPath()
        {
            return folderBrowserDialog.ShowDialog() == DialogResult.OK ? folderBrowserDialog.SelectedPath : null;
        }

        private void SaveProfile(Profile profile)
        {
            _processModel.SaveProfiles(profile);
            _pendingChanges = false;
        }

        private void CloseToolStripMenuItemClick(object sender, EventArgs e)
        {
            CheckForPendingChangesOnClose();
        }

        private void DestinationBrowserButtonClick(object sender, EventArgs e)
        {
            var path = GetPath();
            if (path != null)
            {
                DestinationTextBox.Text = path;
            }
        }

        private void DestinationTextBoxTextChanged(object sender, EventArgs e)
        {
            _pendingChanges = true;
            _profile.DestinationPath = DestinationTextBox.Text;
        }

        private void EditProfileFormClosing(object sender, FormClosingEventArgs e)
        {
            CheckForPendingChangesOnClose();
        }

        private void FileSelectionButtonClick(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _pendingChanges = true;
                _profile.FileNames = openFileDialog.SafeFileNames.ToList();

                FileListLabel.Text = string.Empty;
                foreach (string fileName in openFileDialog.SafeFileNames)
                {
                    FileListLabel.Text += string.Format("{0}\n", fileName);
                }
            }
        }

        private void NameTextBoxTextChanged(object sender, EventArgs e)
        {
            _pendingChanges = true;
            _profile.Name = NameTextBox.Text;
        }

        private void SaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            SaveProfile(_profile);
        }

        private void SourceBrowserButtonClick(object sender, EventArgs e)
        {
            var path = GetPath();
            if (path != null)
            {
                SourceTextBox.Text = path;
            }
        }

        private void SourceTextBoxTextChanged(object sender, EventArgs e)
        {
            _pendingChanges = true;
            _profile.SourcePath = SourceTextBox.Text;
        }

        private readonly ProcessModel _processModel;

        private readonly Profile _profile;
        private bool _pendingChanges;
    }
}