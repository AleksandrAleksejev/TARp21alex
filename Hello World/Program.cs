using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your first name:") ;
            string firstname = Console.ReadLine();
            Console.WriteLine("Hello," + firstname + "!");


            Console.Read();
        }
    }
}
