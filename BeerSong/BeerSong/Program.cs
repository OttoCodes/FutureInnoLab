using System;

namespace BeerSong
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 99;
            Beersong(count);
           
       }



        static void Beersong(int num)
        {
            for (int i = 1; i <= 99; i++)
            {
                //int amountofbot = count;
                Console.WriteLine($"{num} bottles of beer on the wall,{num} bottles of beer.");
                num = num - 1;
                Console.WriteLine($"Take one down and pass it around,{num} bottles of beer on the wall.");
                //count = newcount;
            }
        }
    }

}