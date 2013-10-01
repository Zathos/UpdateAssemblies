using System;
using System.Collections.Generic;
using System.Linq;
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

            _projectList = _fileRepository.LoadProject();
            foreach (string projectDir in _projectList)
            {
                SelectProject.Items.Add(projectDir);
            }
            SelectProject.Items.Add("New");
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


            var projectName = SelectProject.Text;

            //TODO if selectedProject is "New" - create a new entry (double check its not in the list)

            //make sure we have a path
            var pathText = PathTextBox.Text;
            var projectDir = ParseProjectDirFromFullPath(pathText);
            _fileRepository.AddProject(pathText, projectDir);

            _fileRepository.CopyAssemblies(pathText, projectName);

            //if (VerifyInputs(pathText, projectName)) return;

            //if (SelectProject.SelectedItem as string == null)
            //{
            //    if (_projectList.Any(s => s.CompareTo(_projectList) == 0))
            //    {
            //        return;
            //    }
            //    _fileRepository.AddProject(projectName);
            //}
            //_fileRepository.CopyAssemblies(pathText, projectName);
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

        private readonly FileRepository _fileRepository;
        private readonly List<string> _projectList;
    }
}