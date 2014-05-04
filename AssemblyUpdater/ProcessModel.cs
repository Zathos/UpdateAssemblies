using System.Collections.Generic;
using System.Linq;
using AssemblyUpdater.DTOs;

namespace AssemblyUpdater
{
    public class ProcessModel
    {
        public ProcessModel(ProfileXmlRepository profileRepository)
        {
            _profileRepository = profileRepository;
            LoadProfiles();
        }

        public Profile GetNewProfile()
        {
            return new Profile
                       {
                           Id = _profileRoot.Profiles.Count,
                           FileNames = new List<string>(),
                       };
        }

        public Profile GetProfileByName(string profileName)
        {
            return _profileRoot.Profiles.FirstOrDefault(x => x.Name == profileName);
        }

        public object[] GetProfilesAsComboBoxItems()
        {
            return _profileRoot.Profiles.Select(x => x.Name).ToArray();
        }

        public void LoadProfiles()
        {
            _profileRoot = _profileRepository.LoadProfiles();
        }

        public void SaveProfiles(Profile profile)
        {
            if (GetProfileByName(profile.Name) == null)
            {
                _profileRoot.Profiles.Add(profile);
            }

            _profileRepository.SaveProfiles(_profileRoot);
        }

        private readonly ProfileXmlRepository _profileRepository;
        private ProfileRoot _profileRoot;

        public void RemoveProfile(string profileName)
        {
            var profile = GetProfileByName(profileName);
            _profileRoot.Profiles.Remove(profile);
            _profileRepository.SaveProfiles(_profileRoot);
        }
    }
}