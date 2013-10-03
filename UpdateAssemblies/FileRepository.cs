using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace UpdateAssemblies
{
    /// <summary>
    /// 
    /// </summary>
    public class FileRepository
    {
        private const string OutputFile = ".\\myFileName.xml";

        /// <summary>
        /// Initializes a new instance of the <see cref="FileRepository"/> class.
        /// </summary>
        public FileRepository()
        {
            _projectDataInfos = new ProjectData();
        }

        /// <summary>
        /// Adds the project.
        /// </summary>
        /// <param name="fullPath">The full path.</param>
        public Project FindOrCreateProject(string fullPath)
        {
            var temp = fullPath.Split('\\');
            var lastDir = temp[temp.Length - 1];

            var project = _projectDataInfos.Projects.FirstOrDefault(x => x.Path.CompareTo(fullPath) == 0 && x.ProjectDir.CompareTo(lastDir) == 0);
            if (project == null)
            {
                project = new Project
                          {
                              Path = fullPath,
                              ProjectDir = lastDir
                          };

                _projectDataInfos.Projects.Add(project);

                var mySerializer = new XmlSerializer(typeof (ProjectData));
                var myWriter = new StreamWriter(OutputFile);

                mySerializer.Serialize(myWriter, _projectDataInfos);

                myWriter.Close();
            }
            return project;
        }

        /// <summary>
        /// Copies the assemblies.
        /// </summary>
        /// <param name="project">The project.</param>
        public void CopyAssemblies(Project project)
        {
            //TODO
        }

        /// <summary>
        /// Finds the name of the project by dir.
        /// </summary>
        /// <param name="projectDir">The project dir.</param>
        /// <returns></returns>
        public Project FindProjectByDirName(object projectDir)
        {
            return _projectDataInfos.Projects.FirstOrDefault(project => project.ProjectDir.CompareTo(projectDir) == 0);
        }

        /// <summary>
        /// Loads the project.
        /// </summary>
        /// <returns></returns>
        public IList<string> GetProjectNames()
        {
            if (!File.Exists(OutputFile))
            {
                return new List<string>();
            }

            var mySerializer = new XmlSerializer(typeof (ProjectData));
            var myFileStream = new FileStream(OutputFile, FileMode.Open);

            _projectDataInfos = (ProjectData) mySerializer.Deserialize(myFileStream);
            var outputList = new List<string>();

            foreach (Project project in _projectDataInfos.Projects)
            {
                outputList.Add(project.ProjectDir);
            }
            myFileStream.Close();

            return outputList;
        }

        private ProjectData _projectDataInfos;
    }
}