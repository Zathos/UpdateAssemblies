using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssemblyUpdater
{
    public partial class AssemblyUpdaterForm : Form
    {
        public AssemblyUpdaterForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editProfile = new EditProfileForm();
            editProfile.ShowDialog();
        }
    }
}
