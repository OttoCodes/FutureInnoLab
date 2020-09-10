using Microsoft.VisualBasic.CompilerServices;
using System;


namespace ConvertNum
{
    class Program
    {
        //Only works for numbers below 10000

        static void Main(string[] args)
        {
            
                  
                Console.WriteLine("Enter number to convert it to words:");
                string stringNum = Console.ReadLine();
                int number = Int32.Parse(stringNum);
          
            
            
            
            string newNumber = ConvertToWord(number);
            Console.WriteLine(newNumber);
        }
       
        public static string ConvertToWord(int num)
        {
            string[] wordsofnumbers = {"zero","one","two","three","four","five","six","seven","eight","nine","ten",
                                   "eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"};

            string[] wordsoftens = {"twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty"};

            string[] wordsofmore= { "hundred", "thousand" };
            

            string numberInWord = null;

            for (int i = 0; i < 11; i++)
            {
                if (num == 0)
                {
                    numberInWord = wordsofnumbers[0];
                    return numberInWord;

                }
                if (num < 1000)
                {
                    if (i > 0)
                    {
                        numberInWord = numberInWord + ' ' + wordsofnumbers[i] + ' ' + wordsofmore[1];
                    }
                    
                    for (int x = 0; x < 10; x++)
                    {
                        if (num < 100)
                        {
                            if (x > 0)
                            {
                                numberInWord = numberInWord + ' ' + wordsofnumbers[x] + ' ' + wordsofmore[0];
                                if ((num < 20) && (num > 10))
                                {
                                    numberInWord = numberInWord + ' ' + "and" + ' ' + wordsofnumbers[num];
                                    return numberInWord;
                                }
                            }
                            for (int z = 0; z < 10; z++)
                            {
                                
                                   
                                    
                                    if (num < 10)
                                    {
                                    if ((z > 0 ) && (num == 0))
                                    {
                                        numberInWord = numberInWord + ' ' + "and" + ' ' + wordsoftens[z - 2];
                                        return numberInWord;
                                    }
                                    else if ((z == 0) && (num != 0))
                                    {
                                        numberInWord = numberInWord + ' ' + "and" + ' ' + wordsofnumbers[num];
                                        
                                        return numberInWord;
                                    }
                                    else if ((z > 0) && (num != 0))
                                    {
                                        numberInWord = numberInWord + ' ' + "and" + ' ' + wordsoftens[z - 2] + ' ' + wordsofnumbers[num];
                                       
                                        return numberInWord;
                                    }

                                   
                                        else if (num == 0)
                                        {
                                            return numberInWord;
                                        }

                                       
                                        
                                    }

                                

                                num = num - 10;
                            }
                        }
                        num = num - 100;
                    }
                }
                num = num - 1000;
            }




            return numberInWord;
            
        }


    }
}
