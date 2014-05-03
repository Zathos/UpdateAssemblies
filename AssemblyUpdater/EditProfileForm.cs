using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssemblyUpdater.DTOs;

namespace AssemblyUpdater
{
    public partial class EditProfileForm : Form
    {
        public EditProfileForm(Profile profile)
        {
            _profile = profile;
        }

        private Profile _profile;

        public EditProfileForm()
        {
            InitializeComponent();

            _profile = new Profile();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckForPendingChangesOnClose();
        }

        private void EditProfileForm_Load(object sender, EventArgs e)
        {
            CheckForPendingChangesOnClose();
        }

        private void CheckForPendingChangesOnClose()
        {
            if (_pendingChanges)
            {
                MessageBox.Show("Do you want to save changes to profile before closing?", "Save Pending Chagnes", MessageBoxButtons.YesNo);
            }
        }

        private void SaveProfile()
        {

        }

        private bool _pendingChanges;

        private void EditProfileForm_Closing(object sender, FormClosingEventArgs e)
        {
            CheckForPendingChangesOnClose();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveProfile();
        }
    }
}
