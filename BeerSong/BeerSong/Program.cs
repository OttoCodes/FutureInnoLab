using System;

namespace BeerSong
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfBottles = 99;
            Beersong(numOfBottles);
           
       }



        static void Beersong(int num)
        {
            for (int i = 1; i <= 99; i++)
            {
                string s = "s ";
                if (num == 1)
                {
                    s = " ";
                }

                Console.WriteLine($"{num} bottle{s}of beer on the wall,{num} bottle{s}of beer.");
                num = num - 1;

                if (num == 1)
                {
                    s = " ";
                }
                if (num == 0)
                {
                    s = "s ";
                }
                Console.WriteLine($"Take one down and pass it around,{num} bottle{s}of beer on the wall.");
                
            }
        }
    }

}