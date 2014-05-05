using AssemblyUpdater.DTOs;

namespace AssemblyUpdater
{
    public interface IProfileRepository
    {
        ProfileRoot LoadProfiles();
        void SaveProfiles(ProfileRoot profileRoot);
    }
}