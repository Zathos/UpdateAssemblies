using System;
using System.IO;
using System.Windows.Forms;
using AssemblyUpdater.DTOs;

namespace AssemblyUpdater
{
    public partial class AssemblyUpdaterForm : Form
    {
        public AssemblyUpdaterForm(ProcessModel processModel)
        {
            _processModel = processModel;

            InitializeComponent();

            ProfilesDropDownList.Items.AddRange(_processModel.GetProfilesAsComboBoxItems());
            SetDropDownToFirstItemInList();
        }

        private void SetDropDownToFirstItemInList()
        {
            if (ProfilesDropDownList.Items.Count > 0)
            {
                ProfilesDropDownList.Text = ProfilesDropDownList.Items[0].ToString();
            }
        }

        private void ShowEditProfileForm(Profile profile)
        {
            var editProfile = new EditProfileForm(_processModel, profile);
            editProfile.ShowDialog();

            ProfilesDropDownList.Items.Clear();
            ProfilesDropDownList.Items.AddRange(_processModel.GetProfilesAsComboBoxItems());
            ProfilesDropDownList.Text = profile.Name;
        }

        private void AddToolStripMenuItemClick(object sender, EventArgs e)
        {
            Profile profile = _processModel.GetNewProfile();
            ShowEditProfileForm(profile);
        }

        private void CloseToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        private void EditProfileButtonClick(object sender, EventArgs e)
        {
            Profile profile = _processModel.GetProfileByName(_selectedProfileName);
            if (profile == null)
            {
                MessageBox.Show("Please select a profile.");
                return;
            }

            ShowEditProfileForm(profile);
        }

        private void ProfilesDropDownListSelectedValueChanged(object sender, EventArgs e)
        {
            _selectedProfileName = ProfilesDropDownList.Text;
            UpdateProfileDetailsDisplay();
        }

        private void UpdateProfileDetailsDisplay()
        {
            var profile = _processModel.GetProfileByName(_selectedProfileName);
            if (profile != null)
            {
                ProfileSorcePathLabel.Text = profile.SourcePath;
                DestinationPathLabel.Text = profile.DestinationPath;

                if (profile.FileNames.Count == 0)
                {
                    FileListLabel.Text = "No files in this profile";
                }
                else
                {
                    FileListLabel.Text = string.Empty;
                    foreach (string fileName in profile.FileNames)
                    {
                        FileListLabel.Text += string.Format("{0}\n", fileName);
                    }   
                }
            }
            else
            {

                ProfileSorcePathLabel.Text = "Profile not found.";
                DestinationPathLabel.Text = string.Empty;
                FileListLabel.Text = string.Empty;
            }
        }

        private readonly ProcessModel _processModel;
        private string _selectedProfileName;

        private void RemoveProfileButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedProfileName))
            {
                return;
            }

            var message = string.Format("Are you sure you want to delete profile: {0}", _selectedProfileName);
            DialogResult userConfirmation = MessageBox.Show(message, "User Confirmation", MessageBoxButtons.YesNo);

            if (userConfirmation == DialogResult.Yes)
            {
                _processModel.RemoveProfile(_selectedProfileName);
                ProfilesDropDownList.Items.Remove(_selectedProfileName);
                SetDropDownToFirstItemInList();
            }

            _selectedProfileName = ProfilesDropDownList.Text;
        }

        private void ExecuteButtonClick(object sender, EventArgs e)
        {
            var profile = _processModel.GetProfileByName(_selectedProfileName);

            foreach (string fileName in profile.FileNames)
            {
                var fullSourcePath = string.Format("{0}\\{1}", profile.SourcePath, fileName);
                var fullDestinationPath = string.Format("{0}\\{1}", profile.DestinationPath, fileName);

                File.Copy(fullSourcePath, fullDestinationPath);
            }
        }
    }
}