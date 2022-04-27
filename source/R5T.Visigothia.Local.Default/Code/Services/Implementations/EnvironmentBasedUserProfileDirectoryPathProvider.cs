using System;using R5T.T0064;


namespace R5T.Visigothia.Local.Default
{[ServiceImplementationMarker]
    /// <summary>
    /// Uses the <see cref="Environment.GetFolderPath(Environment.SpecialFolder)"/> with <see cref="Environment.SpecialFolder.UserProfile"/> parameter to get the user-profile directory path.
    /// </summary>
    public class EnvironmentBasedUserProfileDirectoryPathProvider : IUserProfileDirectoryPathProvider,IServiceImplementation
    {
        public string GetUserProfileDirectoryPath()
        {
            var userProfileDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            return userProfileDirectoryPath;
        }
    }
}
