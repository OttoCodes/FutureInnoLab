using System;
using Topics;
using Update;


namespace HangmanCON
{
    class Program
    {

        static void Main(string[] args)
        {

            Random rnd = new Random();

            string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            //Controls the first do/while loops
            bool start = true;

            //Stores the topic - genre choice
            int topicNum = 0;

            //Stores the topic chosen by the random generator 
            string choiceTopic = string.Empty;

            //Stores the correct letters guessed by the user 
            char[] word = new char[100];

            //Controls the win condition of the game
            bool win = false;

            //Controls the version of the hanging structure used to hang the man
            int hangIndex = 0;

            //Stores the letters inputed by the user
            string usedletters = string.Empty;

            topicNum = TopicChoice.UserChoice();
            choiceTopic = TopicChoice.ChoiceTopic(topicNum, word);

            do
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                UpdateScreen.UpdateHang(hangIndex);
                UpdateScreen.ScreenUpdate(alphabet, word, usedletters);


                string letter = UpdateScreen.PlayerInput(alphabet, usedletters);

                usedletters = usedletters + letter;


                //Converts the letter inputed by the user into a char array
                char[] letterC = letter.ToCharArray();

                //Controls when the hangIndex is incremented
                bool error = true;

                //Stores how many correct letters the user guessed
                int wincounter = 0;


                for (int i = 0; i < choiceTopic.Length; i++)
                {

                    if (letterC[0] == choiceTopic[i])
                    {
                        word[i] = choiceTopic[i];

                        error = false;
                    }
                    if (word[i] == choiceTopic[i])
                    {
                        wincounter++;
                    }

                    if (wincounter == choiceTopic.Length)
                    {
                        win = true;
                    }
                }

                if (error)
                {
                    hangIndex++;
                }

                if (UpdateScreen.EndGame(win, choiceTopic, hangIndex))
                {
                    break;
                }

            } while (start);
        }
    }

    
}