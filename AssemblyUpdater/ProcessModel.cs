using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyUpdater.DTOs;

namespace AssemblyUpdater
{
    public class ProcessModel
    {
        public ProfileRoot _profileRoot;

        private Profile GetNewProfile()
        {
            var profile = new Profile();
            profile.Id = _profileRoot.Profiles.Count;
            return profile;
        }

        void LoadProfiles()
        {

        }

        void SaveProfiles()
        {

        }
    }
}
