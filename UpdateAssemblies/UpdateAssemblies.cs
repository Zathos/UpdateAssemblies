using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UpdateAssemblies
{
    public partial class UpdateAssemblies : Form
    {
        public UpdateAssemblies()
        {
            InitializeComponent();
        }

        private void PickPathButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                PathTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //TODO use the path and SelectProject
        }

        private void SelectProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBoxItem item = new ComboBoxItem();

            //SelectProject.Items.Add();
        }
    }
}
