using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy;

using R5T.D0065;
using R5T.T0063;


namespace R5T.D0111.D001.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DefaultGitIgnoreTemplateFilePathProvider"/> implementation of <see cref="IGitIgnoreTemplateFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultGitIgnoreTemplateFilePathProvider(this IServiceCollection services,
            IServiceAction<IExecutableDirectoryPathProvider> executableDirectoryPathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .Run(executableDirectoryPathProviderAction)
                .Run(stringlyTypedPathOperatorAction)
                .AddSingleton<IGitIgnoreTemplateFilePathProvider, DefaultGitIgnoreTemplateFilePathProvider>();

            return services;
        }
    }
}