namespace VersionAttribute
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | 
                    AttributeTargets.Interface | AttributeTargets.Enum | 
                    AttributeTargets.Method)]
    public class VersionAttribute : Attribute
    {
        public VersionAttribute(string version)
        {
            this.Version = version;
        }

        public string Version { get; private set; }
    }
}
