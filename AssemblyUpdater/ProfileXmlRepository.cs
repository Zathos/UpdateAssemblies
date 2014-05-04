using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using AssemblyUpdater.DTOs;

namespace AssemblyUpdater
{
    public class ProfileXmlRepository : IProfileRepository
    {
        private const string ProfilesXmlFileName = "Profiles.xml";

        public ProfileRoot LoadProfiles()
        {
            if (!File.Exists(ProfilesXmlFileName))
            {
                return new ProfileRoot{Profiles = new List<Profile>()};
            }

            var xmlSerializer = new XmlSerializer(typeof (ProfileRoot));
            using (TextReader reader = new StreamReader(ProfilesXmlFileName))
            {
                var profileRoot = (ProfileRoot) xmlSerializer.Deserialize(reader);
                reader.Close();
                return profileRoot;
            }
        }

        public void SaveProfiles(ProfileRoot profileRoot)
        {
            var xmlSerializer = new XmlSerializer(typeof (ProfileRoot));
            using (TextWriter writer = new StreamWriter(ProfilesXmlFileName))
            {
                xmlSerializer.Serialize(writer, profileRoot);
                writer.Close();
            }
        }
    }
}