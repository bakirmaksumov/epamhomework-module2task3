using System;
using MyLibrary;

namespace HelloAppConsoleWithLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Здравствуйте введите свое имя:");
            string name = Console.ReadLine();
            var lib = new OutputInfo(); 
            Console.WriteLine(lib.inputInfo(name));
            Console.ReadLine();
        }
    }
}
