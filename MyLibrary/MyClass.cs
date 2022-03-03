using System;

namespace MyLibrary
{
    public class MyClass
    {
        public static string Greet(string name) => $"Hello {name} from Standard Library. Static Method";
        public string Greet2(string name) => $"Hello {name} from Standard Library. Instance Method";
    }
}
