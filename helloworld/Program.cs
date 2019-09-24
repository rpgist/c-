//James Hawkins 
//random c# program to ezperiment with different c# things as well as visual studio
using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 7;
            while (i > 0)
            {
                Console.WriteLine("Hello World!");
                i--;
            }
            string temp;
            Console.Write("enter your input: ");
            temp = Console.ReadLine();
            Console.WriteLine("your input was: " + temp);
            if (temp.Equals("cat"))
            {
                catPrint();
            }
            
        }
        static void catPrint() {
            Console.WriteLine("CATS");
        }
    }

}
