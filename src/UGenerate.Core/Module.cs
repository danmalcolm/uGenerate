namespace UGenerate.Core
{
    public class Module
    {
        public Module(string aliasPrefix, string @namespace, string directoryPath)
        {
            AliasPrefix = aliasPrefix;
            Namespace = @namespace;
            DirectoryPath = directoryPath;
        }

        public string AliasPrefix { get; private set; }

        public string Namespace { get; private set; }

        public string DirectoryPath { get; private set; }
    }
}