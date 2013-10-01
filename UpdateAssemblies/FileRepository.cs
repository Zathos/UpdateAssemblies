using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace UpdateAssemblies
{
    /// <summary>
    /// 
    /// </summary>
    public class FileRepository
    {
        public FileRepository()
        {
            _projectInfos = new List<ProjectInfo>();

            LoadProject();
        }

        /// <summary>
        /// Adds the project.
        /// </summary>
        /// <param name="fullPath">The full path.</param>
        public void AddProject(string fullPath, string projectDir)
        {
            var temp = fullPath.Split('\\');
            var lastDir = temp[temp.Length - 1];

            var project = new ProjectInfo
                          {
                              Path = fullPath,
                              ProjectDir = lastDir
                          };
            _projectInfos.Add(project);


            XmlSerializer mySerializer = new XmlSerializer(typeof (ProjectInfo));
            // To write to a file, create a StreamWriter object.
            StreamWriter myWriter = new StreamWriter(".\\myFileName.xml");
            mySerializer.Serialize(myWriter, _projectInfos[0]);
            myWriter.Close();
        }

        /// <summary>
        /// Copies the assemblies.
        /// </summary>
        /// <param name="pathText">The path text.</param>
        /// <param name="projectName">Name of the project.</param>
        public void CopyAssemblies(string pathText, string projectName)
        {
        }

        /// <summary>
        /// Loads the project.
        /// </summary>
        /// <returns></returns>
        public List<string> LoadProject()
        {
            XmlSerializer mySerializer = new XmlSerializer(typeof(ProjectInfo));
            // To read the file, create a FileStream.
            FileStream myFileStream = new FileStream(".\\myFileName.xml", FileMode.Open);
            // Call the Deserialize method and cast to the object type.
            var project = (ProjectInfo)mySerializer.Deserialize(myFileStream);
            _projectInfos.Add(project);
            myFileStream.Close();

            return new List<string>{project.ProjectDir};
        }

        private readonly IList<ProjectInfo> _projectInfos;
    }
}