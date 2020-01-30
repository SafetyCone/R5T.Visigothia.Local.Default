using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Visigothia.Local.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="EnvironmentBasedUserProfileDirectoryPathProvider"/> implementation of <see cref="IUserProfileDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddEnvironmentBasedUserProfileDirectoryPathProvider(this IServiceCollection services)
        {
            services.AddSingleton<IUserProfileDirectoryPathProvider, EnvironmentBasedUserProfileDirectoryPathProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="EnvironmentBasedUserProfileDirectoryPathProvider"/> implementation of <see cref="IUserProfileDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IUserProfileDirectoryPathProvider> AddEnvironmentBasedUserProfileDirectoryPathProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IUserProfileDirectoryPathProvider>(() => services.AddEnvironmentBasedUserProfileDirectoryPathProvider());
            return serviceAction;
        }
    }
}
