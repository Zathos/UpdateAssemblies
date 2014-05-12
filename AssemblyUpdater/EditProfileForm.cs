using System;
using System.Collections.Generic;
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

            _updatedProfile = new Profile{FileNames = new List<string>()};

            NameTextBox.Text = _profile.Name;
            SourceTextBox.Text = _profile.SourcePath;
            DestinationTextBox.Text = _profile.DestinationPath;
            
            if (_profile.FileNames.Count == 0)
            {
                FileListLabel.Text = "No files in this profile";
            }
            else
            {
                FileListLabel.Text = string.Empty;
                foreach (string fileName in _profile.FileNames)
                {
                    FileListLabel.Text += string.Format("{0}\n", fileName);

                    _updatedProfile.FileNames.Add(fileName);
                }
            }
            _pendingChanges = false;
        }

        private string GetPath()
        {
            return folderBrowserDialog.ShowDialog() == DialogResult.OK ? folderBrowserDialog.SelectedPath : null;
        }

        private void SaveProfile()
        {
            _profile.Name = _updatedProfile.Name;
            _profile.SourcePath = _updatedProfile.SourcePath;
            _profile.DestinationPath = _updatedProfile.DestinationPath;
            _profile.FileNames = _updatedProfile.FileNames.Select(x => x).ToList();

            _processModel.SaveProfiles(_profile);
            _pendingChanges = false;
        }

        private void CloseToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
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
            _updatedProfile.DestinationPath = DestinationTextBox.Text;
        }

        private void EditProfileFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_pendingChanges)
            {
                return;
            }

            var saveChanges = MessageBox.Show("Do you want to save changes to profile before closing?", "Save Pending Changes", MessageBoxButtons.YesNo);
            if (saveChanges == DialogResult.Yes)
            {
                SaveProfile();
            }
        }

        private void FileSelectionButtonClick(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = true;
            openFileDialog.InitialDirectory = _updatedProfile.SourcePath;
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _pendingChanges = true;
            _updatedProfile.FileNames = openFileDialog.SafeFileNames.ToList();

            FileListLabel.Text = string.Empty;
            foreach (string fileName in openFileDialog.SafeFileNames)
            {
                FileListLabel.Text += string.Format("{0}\n", fileName);
            }
        }

        private void NameTextBoxTextChanged(object sender, EventArgs e)
        {
            _pendingChanges = true;
            _updatedProfile.Name = NameTextBox.Text;
        }

        private void SaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            SaveProfile();
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
            _updatedProfile.SourcePath = SourceTextBox.Text;
        }

        private readonly ProcessModel _processModel;
        private readonly Profile _profile;
        private readonly Profile _updatedProfile;
        private bool _pendingChanges;

        private void SourceOpenLabelClick(object sender, EventArgs e)
        {
            var process = new System.Diagnostics.Process
            {
                StartInfo =
                {
                    UseShellExecute = true,
                    FileName = SourceTextBox.Text,
                    Arguments = @" "
                }
            };

            process.Start();
        }

        private void DestinationOpenLabelClick(object sender, EventArgs e)
        {

            var process = new System.Diagnostics.Process
            {
                StartInfo =
                {
                    UseShellExecute = true,
                    FileName = DestinationTextBox.Text,
                    Arguments = @" "
                }
            };

            process.Start();
        }
    }
}