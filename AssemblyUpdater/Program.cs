using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssemblyUpdater
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //TODO create a file Io repository and pass into AssemblyUpdaterForm


            var profileRepository = new ProfileXmlRepository();
            var processModel = new ProcessModel();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AssemblyUpdaterForm());
        }
    }
}
