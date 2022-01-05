using System;

using R5T.T0021;

using R5T.D0111.D001.I001;


namespace System
{
    public static class IRelativeFilePathExtensions
    {
        public static string GitIgnoreTemplateText(this IRelativeFilePath _)
        {
            return RelativeFilePaths.GitIgnoreTemplateText;
        }
    }
}
