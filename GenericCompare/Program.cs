using System;

namespace GenericCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckNumbers n1 = new CheckNumbers();            
            CheckNumbers n2 = new CheckNumbers();            
            CheckString s1 = new CheckString();            
            CheckString s2 = new CheckString();
            

            Console.WriteLine(n1.Compare(1, 2));
            Console.WriteLine(n2.Compare(-2,-2));
            Console.WriteLine(s1.Compare("Hej", "Hello"));
            Console.WriteLine(s2.Compare("Hello", "Hello"));
            Console.ReadKey();


        }
    }
}
