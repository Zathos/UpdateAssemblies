using System;
using System.Windows.Forms;

namespace AssemblyUpdater
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            var profileRepository = new ProfileXmlRepository();
            var processModel = new ProcessModel(profileRepository);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new AssemblyUpdaterForm(processModel));
        }
    }
}