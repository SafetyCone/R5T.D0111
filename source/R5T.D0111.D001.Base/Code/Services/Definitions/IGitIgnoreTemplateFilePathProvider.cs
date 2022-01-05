using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0111.D001
{
    [ServiceDefinitionMarker]
    public interface IGitIgnoreTemplateFilePathProvider : IServiceDefinition
    {
        Task<string> GetGitIgnoreTemplateFilePath();
    }
}