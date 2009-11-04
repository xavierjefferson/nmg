using NMG.Core.Domain;

namespace NMG.Core
{
    public class ApplicationPreferences
    {
        public string FolderPath { get; set; }
        public string TableName { get; set; }
        public string NameSpace { get; set; }
        public string AssemblyName { get; set; }
        public string Sequence { get; set; }
        public bool IsFluent { get; set; }
        public string Prefix { get; set; }

        public Language Language { get; set; }
        public ServerType ServerType { get; set; }
        public FieldNamingConvention FieldNamingConvention { get; set; }
        public FieldGenerationConvention FieldGenerationConvention { get; set; }

        public ApplicationPreferences()
        {
            FieldNamingConvention = FieldNamingConvention.SameAsDatabase;
            Prefix = string.Empty;
        }

        public ApplicationPreferences(FieldNamingConvention fieldNamingConvention, string prefix)
        {
            FieldNamingConvention = fieldNamingConvention;
            Prefix = prefix;
        }
    }
}