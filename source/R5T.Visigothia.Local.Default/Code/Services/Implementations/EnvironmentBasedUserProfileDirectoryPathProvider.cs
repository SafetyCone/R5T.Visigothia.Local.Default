using System;


namespace R5T.Visigothia.Local.Default
{
    /// <summary>
    /// Uses the <see cref="Environment.GetFolderPath(Environment.SpecialFolder)"/> with <see cref="Environment.SpecialFolder.UserProfile"/> parameter to get the user-profile directory path.
    /// </summary>
    public class EnvironmentBasedUserProfileDirectoryPathProvider : IUserProfileDirectoryPathProvider
    {
        public string GetUserProfileDirectoryPath()
        {
            var userProfileDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            return userProfileDirectoryPath;
        }
    }
}
