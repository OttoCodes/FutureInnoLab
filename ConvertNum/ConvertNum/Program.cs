using Microsoft.VisualBasic.CompilerServices;
using System;


namespace ConvertNum
{
    class Program
    {
        //Only works for numbers below 19999999 million

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

            string[] wordsofmore= { "hundred", "thousand", "million", "billion"};
            string numberInWord = null;


            //for numbers above 20000 

            if (num >= 20000)
            {


                for (int i = 0; i < wordsofnumbers.Length; i++)
                {

                    
                    if (num < 1000000)
                    {

                        if (i > 0 && (num == 0))
                        {
                            numberInWord = numberInWord + ' ' + wordsofnumbers[i] + ' ' + wordsofmore[2];
                        }
                        else if (i > 0 && (num >= 0) && (num <= 99))
                        {
                            numberInWord = numberInWord + ' ' + wordsofnumbers[i] + ' ' + wordsofmore[2] + ' ' + "and" + ' ';
                        }
                        else  if (i > 0)
                        {
                            numberInWord = numberInWord + ' ' + wordsofnumbers[i] + ' ' + wordsofmore[2]   ;
                        }

                        for (int x = 0; x < 10; x++)
                        {
                            if (num < 100000)
                            {
                                if (x > 0 && num == 0)
                                {
                                    numberInWord = numberInWord + ' ' + wordsofnumbers[x] + ' ' + wordsofmore[0] + ' ' + wordsofmore[1];
                                                                     
                                  
                                }
                                else if (x > 0 && (num < 100000) && (num > 1000))
                                {
                                    numberInWord = numberInWord + ' ' + wordsofnumbers[x] + ' ' + wordsofmore[0] ;



                                }
                                else if (x > 0 && (num >= 100) && (num <= 999))
                                {
                                    numberInWord = numberInWord + ' ' + wordsofnumbers[x] + ' ' + wordsofmore[0] + ' ' + wordsofmore[1];

                                    

                                }
                                else if (x > 0 && (num >= 0) && (num <= 99))
                                {
                                    numberInWord = numberInWord + ' ' + wordsoftens[x] + ' ' + wordsofmore[0] + wordsofmore[1] + ' ' + "and" + ' ';
                                }
                                if (num < 20000)
                                {
                                    break;
                                }

                                for (int z = 0; z < 10; z++)
                                {
                                    if (z >= 2 && (num >= 100) && (num <= 999))
                                    {
                                        numberInWord = numberInWord + ' ' + wordsoftens[z - 2] + ' ' + wordsofmore[1] ;
                                    }
                                    if (z >= 2 && (num >= 0) && (num <= 99))
                                    {
                                        numberInWord = numberInWord + ' ' + wordsoftens[z - 2] + ' ' + wordsofmore[1] + ' ' + "and" + ' ';
                                    }
                                    else if (z >= 2 && num <10000)
                                    {
                                        numberInWord = numberInWord + ' ' + wordsoftens[z - 2] ;
                                    }

                                    if (num < 10000)
                                    {
                                        break;
                                    }





                                    num = num - 10000;
                                }
                            }
                            if (num <100000)
                            {
                                break;
                            }
                            num = num - 100000;
                        }
                    }
                    if (num <1000000)
                    {
                        break;
                    }
                    num = num - 1000000;
                }

            }
            
            
            
            
            //for numbers below 20000 




            for (int i = 0; i < wordsofnumbers.Length; i++)
            {
                if ((num == 0) && i == 0 && numberInWord == null)
                {
                    numberInWord = numberInWord + wordsofnumbers[0];
                    return numberInWord;

                }
                if ((num == 0) && i == 0 && numberInWord != null)
                {
                    
                    return numberInWord;
                }
                    if ((num < 20 )&&(num > 0) && i == 0)
                {
                    numberInWord = numberInWord + wordsofnumbers[num];
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
