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
            //gets user input
            Console.Write("enter your input: ");
            temp = Console.ReadLine();
            Console.WriteLine("your input was: " + temp);
            //checks input and calls static method 
            if (temp.Equals("cat"))
            {
                catPrint();
            }
            else {
                Other(temp);
            }
            
        }
        //cat method prints cats just a test
        static void catPrint() {
            Console.WriteLine("CATS");
        }

        //other method gets passed users input to randomly jumble
        static void Other(String temp) {
            char[] array = temp.ToCharArray();
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            Console.WriteLine(new string(array));
        }
    }

}
