using System;

namespace BeerSong
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 99;

            for (int i = 1; i <= 99; i++)
            {
                //int amountofbot = count;
                Console.WriteLine($"{count} bottles of beer on the wall,{count} bottles of beer.");
                count = count - 1;
                Console.WriteLine($"Take one down and pass it around,{count} bottles of beer on the wall.");
                //count = newcount;
            }

        }
    }
}