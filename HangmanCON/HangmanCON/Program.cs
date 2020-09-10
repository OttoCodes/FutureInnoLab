using System;

namespace HangmanCON
{
    class Program
    {

         static void Main(string[] args)
        {
            
            Random rnd = new Random();

            //Topics
            string[] anime = { "happy day","sad day", "naruto", "bleach", "dragonball" };
            string[] games = { "minecraft", "paladins", "fornite","god of war" };
            string[] musicArtisit = { "adele", "joji", "drake", "linkin park" };
            string[] movies = { "avengers", "mulan", "joker", "the lord of the rings" };
            string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            
            //Controls the first do/while loops
            bool start = false;
            
            //Stores the topic - genre choice
            int topicNum = 0;
            
            //Stores the topic chosen by the random generator 
            string choiceTopic = "";
            
            //Stores the correct letters guessed by the user 
            char[] word = new char[100];
            
            //Controls the win condition of the game
            bool win = false;
            
            //Controls the version of the hanging structure used to hang the man
            int hangIndex = 0;
            
            //Stores the letters inputed by the user
            string usedletters = "";
           

            Console.WriteLine("Welcome to Hangman!!!");
            Console.WriteLine(" ");

            do
            {
                Console.WriteLine("Please choose from our topics that you want to play:");
                Console.WriteLine("1.Anime");
                Console.WriteLine("2.Games");
                Console.WriteLine("3.Music Artists");
                Console.WriteLine("4.Movies");
                Console.Write("What is your choice? ");
                string topic = Console.ReadLine();


                if (topic == "1" || topic == "2" || topic == "3" || topic == "4")
                {
                    topicNum = int.Parse(topic);
                    start = true;
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Error with input!!!");
                    Console.WriteLine(" ");
                }
            } while (!start);
            

            switch (topicNum)
            {
                case 1:
                    int animeIndex = rnd.Next(anime.Length);
                    choiceTopic = anime[animeIndex];
                    for (int i = 0; i < choiceTopic.Length; i++)
                    {
                        word[i] = '-';
                    }
                    
                    
                    break;

                case 2:
                    int gamesIndex = rnd.Next(games.Length);
                    choiceTopic = games[gamesIndex];
                    for (int i = 0; i < choiceTopic.Length; i++)
                    {
                        word[i] = '-';
                    }

                    break;

                case 3:
                    int musicIndex = rnd.Next(musicArtisit.Length);
                    choiceTopic = musicArtisit[musicIndex];
                    for (int i = 0; i < choiceTopic.Length; i++)
                    {
                        word[i] = '-';
                    }

                    break;

                case 4:
                    int movieIndex = rnd.Next(movies.Length);
                    choiceTopic = movies[movieIndex];
                    for (int i = 0; i < choiceTopic.Length; i++)
                    {
                        word[i] = '-';
                    }

                    break;


                default:
                    break;
            }


            for (int i = 0; i < choiceTopic.Length; i++)
            {
                if (choiceTopic[i] == ' ')
                {
                    word[i] = ' ';
                   
                }
            }


            Console.WriteLine(" ");



            foreach (char item in word)
            {
                Console.Write($"{item}"); 
            }

            Console.WriteLine(" ");




            do
            {
                Console.WriteLine(" ");
                updateHang(hangIndex);
                Console.WriteLine(" ");
                Console.WriteLine(" ");




                for (int i = 0; i <alphabet.Length; i++)
                {
                    Console.Write($"{alphabet[i]}, ");
                }
                Console.WriteLine(" ");
                Console.Write("Choose a letter : ");
                string letter = Console.ReadLine();
                Console.WriteLine(" ");




                

               
                for (int i = 0; i < alphabet.Length; i++)
                {

                    if (letter == " ")
                    {
                        Console.WriteLine(" ");
                        Console.Write("You typed nothing! Try again :");
                        Console.WriteLine(" ");
                        letter = Console.ReadLine();
                        i = 0;
                    }
                    if (letter.Length > 1)
                    {
                        Console.WriteLine(" ");
                        Console.Write("Only type one letter at a time! Try again :");
                        Console.WriteLine(" ");
                        letter = Console.ReadLine();
                        i = 0;
                    }
                    else if  (usedletters.Contains(letter))
                    {
                        Console.WriteLine(" ");
                        Console.Write("Letter already used!! please pick another one :");
                        Console.WriteLine(" ");
                        letter = Console.ReadLine();
                        i = 0;

                    }
                    else if (letter == alphabet[i])
                    {
                        
                        alphabet[i] = " ";
                        
                        break;

                    }

                   
                    
                }

                usedletters = usedletters + letter;
                Console.WriteLine(" ");
                Console.WriteLine($"The letters used are = {usedletters}");
                Console.WriteLine(" ");

                //Converts the letter inputed by the user into a char array
                char[] letterC = letter.ToCharArray();
                
                //Controls when the hangIndex is incremented
                bool error = true;

                //Stores how many correct letters the user guessed
                int wincounter = 0;










                for (int i = 0; i < choiceTopic.Length; i++)
                {
                    
                   
                        if(letterC[0] == choiceTopic[i])
                    {
                        word[i] = choiceTopic[i];
                        
                        error = false;
                      
                        
                    }
                    if (word[i] == choiceTopic[i])
                    {
                        wincounter++;
                    }

                    if (wincounter == choiceTopic.Length )
                    {
                        win = true;
                    }
                       
                    
                }
                Console.WriteLine(" ");
                Console.Write("The word/word's so far :");
                
                foreach (char item in word)
                {
                    Console.Write(item);
                }

                


                if (error)
                {

                    hangIndex++;

                }

                if (win)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("YOU WIN!!!!!");
                    Console.WriteLine(" ");
                    break;
                }

                if (hangIndex == 6)
                {
                    Console.WriteLine(" ");
                    updateHang(hangIndex);
                    Console.WriteLine(" ");
                    Console.WriteLine($"The word/word's was  = {choiceTopic} ");
                    Console.WriteLine(" ");
                    Console.WriteLine("GAME OVER");
                    Console.WriteLine(" ");
                    break;
                }





            } while (start);



        }

        

        static void updateHang(int x)
        {
            if (x == 0)
            {
                Console.WriteLine("                              ");
                Console.WriteLine("                              ");
                Console.WriteLine("             =================");
                Console.WriteLine("             ||            |||");
                Console.WriteLine("             ||            |||");
                Console.WriteLine("             ||            |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("        ===============================");

            }
            if (x == 1)
            {
                Console.WriteLine("                              ");
                Console.WriteLine("                              ");
                Console.WriteLine("             =================");
                Console.WriteLine("             ||            |||");
                Console.WriteLine("             ||            |||");
                Console.WriteLine("             ||            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("            o  o           |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("        ===============================");
            }
            if (x == 2)
            {
                Console.WriteLine("                              ");
                Console.WriteLine("                              ");
                Console.WriteLine("             =================");
                Console.WriteLine("             ||            |||");
                Console.WriteLine("             ||            |||");
                Console.WriteLine("             ||            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("            o  o           |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("        ===============================");
            }
            if (x == 3)
            {
                Console.WriteLine("                              ");
                Console.WriteLine("                              ");
                Console.WriteLine("             =================");
                Console.WriteLine("             ||            |||");
                Console.WriteLine("             ||            |||");
                Console.WriteLine("             ||            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("            o  o           |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("               o           |||");
                Console.WriteLine("                o          |||");
                Console.WriteLine("                 o         |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("        ===============================");
            }

            if (x == 4)
            {
                Console.WriteLine("                              ");
                Console.WriteLine("                              ");
                Console.WriteLine("             =================");
                Console.WriteLine("             ||            |||");
                Console.WriteLine("             ||            |||");
                Console.WriteLine("             ||            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("            o  o           |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("            o  o           |||");
                Console.WriteLine("           o    o          |||");
                Console.WriteLine("          o      o         |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("        ===============================");
            }
            if (x == 5)
            {
                Console.WriteLine("                              ");
                Console.WriteLine("                              ");
                Console.WriteLine("             =================");
                Console.WriteLine("             ||            |||");
                Console.WriteLine("             ||            |||");
                Console.WriteLine("             ||            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("            o  o           |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("             ooooooo       |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("            o  o           |||");
                Console.WriteLine("           o    o          |||");
                Console.WriteLine("          o      o         |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("        ===============================");
            }
            if (x == 6)
            {
                Console.WriteLine("                              ");
                Console.WriteLine("                              ");
                Console.WriteLine("             =================");
                Console.WriteLine("             ||            |||");
                Console.WriteLine("             ||            |||");
                Console.WriteLine("             ||            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("            o  o           |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("        oooooooooooo       |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("             oo            |||");
                Console.WriteLine("            o  o           |||");
                Console.WriteLine("           o    o          |||");
                Console.WriteLine("          o      o         |||");
                Console.WriteLine("                           |||");
                Console.WriteLine("        ===============================");
            }


        }
        

 




    }


}