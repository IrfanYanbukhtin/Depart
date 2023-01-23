using System;

namespace _23._1._23Console.Apllication
{
    internal class Student : Person
    {
        internal Group Group { get; set; }
        internal DateTime EntryDate { get; set; }
        internal int Course { get; set; }
        internal string[] Subject { get; set; } = new string[10];
    }
}
