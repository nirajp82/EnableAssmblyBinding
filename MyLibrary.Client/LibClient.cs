using System;
using System.Collections.Generic;
using UtilLib;

namespace MyLibrary.Client
{
    public class LibClient
    {
        public static List<string> Greet(string name) 
        {
            List<string> result = new List<string>();
            result.Add(MyLibrary.MyClass.Greet("Raj"));
            result.Add(new MyLibrary.MyClass().Greet2("Raj"));
            result.Add(AssemblyExt.GetAssemblyInfo(typeof(MyLibrary.MyClass)));
            return result;
        }
    }
}
