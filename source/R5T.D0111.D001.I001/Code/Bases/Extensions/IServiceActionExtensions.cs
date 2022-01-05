using System;

using R5T.Lombardy;

using R5T.D0065;
using R5T.T0062;
using R5T.T0063;


namespace R5T.D0111.D001.I001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DefaultGitIgnoreTemplateFilePathProvider"/> implementation of <see cref="IGitIgnoreTemplateFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IGitIgnoreTemplateFilePathProvider> AddDefaultGitIgnoreTemplateFilePathProviderAction(this IServiceAction _,
            IServiceAction<IExecutableDirectoryPathProvider> executableDirectoryPathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = _.New<IGitIgnoreTemplateFilePathProvider>(services => services.AddDefaultGitIgnoreTemplateFilePathProvider(
                executableDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction));

            return serviceAction;
        }
    }
}
