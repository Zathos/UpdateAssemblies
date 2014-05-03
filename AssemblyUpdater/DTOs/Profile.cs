using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyUpdater.DTOs
{
    public class Profile
    {
        public int Id;
        public string Name;
        public string SourcePath;
        public string DestinationPath;
        public List<string> FileNames;
    }
}
