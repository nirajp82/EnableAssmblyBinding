using System;

namespace UtilLib
{
    public class AssemblyExt
    {
        public static string GetAssemblyInfo(Type type)
        {
            return $"AssemblyQualifiedName: {type.AssemblyQualifiedName}- Location:{type.Assembly.Location}";
        }
    }
}
