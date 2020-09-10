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
            

            for (int i = word.Length - 1; i >= 0 ; i--)
            {
                
                invword = invword + word[i];
                
            }
            Console.WriteLine($"{word} inverted to {invword}");
            Console.WriteLine("Is this text a palindrome? ");
            if (invword == word)
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
