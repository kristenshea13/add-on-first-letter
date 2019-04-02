using System;

namespace add_on_first_letter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Write a C# program to create a new string from a given string (length 1 or more ) 
            //with the first character added at the front and back. Go to the editor
            //Sample Output:
            //Input a string : The quick brown fox jumps over the lazy dog.
            //TThe quick brown fox jumps over the lazy dog.T

            Console.Write("Write out a string: ");
            string x = Console.ReadLine();


            if (x.Length >= 1)
            {
                var z = x.Substring(0, 1);

                Console.WriteLine($"{z}{x}{z}");

            }
            Console.ReadLine();
        }
    }
}