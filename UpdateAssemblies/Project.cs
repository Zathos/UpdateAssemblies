using System.Collections.Generic;

namespace UpdateAssemblies
{
    /// <summary>
    /// 
    /// </summary>
    public class Project
    {
        /// <summary> The path </summary>
        public string Path;

        /// <summary> The project name </summary>
        public string ProjectDir;
    }


    /// <summary>
    /// 
    /// </summary>
    public class ProjectData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectData"/> class.
        /// </summary>
        public ProjectData()
        {
            Projects = new List<Project>();
        }

        /// <summary>
        /// Gets or sets the project.
        /// </summary>
        /// <value>
        /// The project.
        /// </value>
        public List<Project> Projects { get; set; }
    }
}