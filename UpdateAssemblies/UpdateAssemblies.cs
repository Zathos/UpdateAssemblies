using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UpdateAssemblies
{
    /// <summary>
    /// 
    /// </summary>
    public partial class UpdateAssemblies : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssemblies"/> class.
        /// </summary>
        public UpdateAssemblies()
        {
            InitializeComponent();

            _fileRepository = new FileRepository();

            _projectList = _fileRepository.GetProjectNames();
            foreach (string projectDir in _projectList)
            {
                SelectProject.Items.Add(projectDir);
            }
        }

        private static string ParseProjectDirFromFullPath(string pathText)
        {
            var temp = pathText.Split('\\');
            return temp[temp.Length - 1];
        }

        private static bool VerifyInputs(string pathText, string projectName)
        {
            bool retVal = false;
            if (pathText == string.Empty)
            {
                MessageBox.Show("Please select a path.");
                retVal = true;
            }
            if (projectName == string.Empty)
            {
                MessageBox.Show("Please select a project.");
                retVal = true;
            }
            return retVal;
        }

        private void PickPathButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                PathTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void SelectProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = (ComboBox) sender;
            var itemText = comboBox.SelectedItem;

            Project project = _fileRepository.FindProjectByDirName(itemText);

            PathTextBox.Text = (project != null) ? project.Path : string.Empty;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var pathText = PathTextBox.Text;

            var project = _fileRepository.FindOrCreateProject(pathText);

            _fileRepository.CopyAssemblies(project);

            PathTextBox.Text = String.Empty;
        }

        private readonly FileRepository _fileRepository;
        private readonly IList<string> _projectList;
    }
}