using System;

namespace TextInverser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text and I'll invert it for you:");
            string word = Console.ReadLine();
            string invword = null;
            inverter(word, invword);
            
            

        }




        static void inverter(string a, string b)
        {

            for (int i = a.Length - 1; i >= 0; i--)
            {

                b = b + a[i];

            }
            Console.WriteLine($"{a} inverted to {b}");
            Console.WriteLine("Is this text a palindrome? ");
            palidrome(a, b);
        }

        static void palidrome(string c, string d)
        {
            if (d == c)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
