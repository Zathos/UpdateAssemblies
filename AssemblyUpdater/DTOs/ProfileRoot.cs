using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyUpdater.DTOs
{
    public class ProfileRoot
    {
        public List<Profile> Profiles;

        public Profile GetProfileByName(string profileName)
        {
            return Profile.FirstOrDefault(x => x.Name == profileName);
        }

    }
}
