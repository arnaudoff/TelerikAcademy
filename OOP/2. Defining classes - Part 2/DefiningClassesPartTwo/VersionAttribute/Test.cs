namespace VersionAttribute
{
    using System;
    using System.Reflection;

    [VersionAttribute("6.66")]
    public class Test
    {
        static void Main()
        {
            var classAttributesList = typeof(Test).GetCustomAttributes<VersionAttribute>();

            foreach (var attribute in classAttributesList)
            {
                Console.WriteLine("Version: {0}", attribute.Version);
            }
        }
    }
}
