using System;
using System.Threading.Tasks;

using R5T.Lombardy;

using R5T.D0065;
using R5T.T0064;


namespace R5T.D0111.D001.I001
{
    [ServiceImplementationMarker]
    public class DefaultGitIgnoreTemplateFilePathProvider : IGitIgnoreTemplateFilePathProvider, IServiceImplementation
    {
        private IExecutableDirectoryPathProvider ExecutableDirectoryPathProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public DefaultGitIgnoreTemplateFilePathProvider(
            IExecutableDirectoryPathProvider executableDirectoryPathProvider,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.ExecutableDirectoryPathProvider = executableDirectoryPathProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public async Task<string> GetGitIgnoreTemplateFilePath()
        {
            var executableDirectoryPath = await this.ExecutableDirectoryPathProvider.GetExecutableDirectoryPath();

            var defaultGitIgnoreTemplateFilePath = this.StringlyTypedPathOperator.Combine(
                executableDirectoryPath,
                Instances.RelativeFilePath.GitIgnoreTemplateText());

            return defaultGitIgnoreTemplateFilePath;
        }
    }
}