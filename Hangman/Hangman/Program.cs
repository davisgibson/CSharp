using System;
using System.Collections.Generic;

namespace Hangman
{
    class MainClass
    {

        static List<String> guessed = new List<String>();
        static List<char> secret;
        static string word;
        static int lives;
        public static void Main(string[] args)
        {

            while (1 == 1)
            {
                lives = 5;
                Console.WriteLine("What's the word?");
                word = Console.ReadLine();
                convertToSecret();
                playGame();
                Console.WriteLine("Would you like to play again?( y / n )");
                string again = Console.ReadLine();
                if(again != "y")
                {
                    break;
                }
            }
        }
        public static string convertToSecret()
        {
            secret = "";
            string ret = "";
            for(int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    secret += " ";
                }
                else
                {
                    secret += "_";
                }
            }
            return ret;
        }
        public static void printGame()
        {
            Console.WriteLine(secret);
            Console.WriteLine("Lives: " + lives);
        }
        //only run after the program is sure the guess is in the word and hasnt been guessed yet;
        public static void reveal(char t)
        {
            int ind = word.IndexOf(t);
            secret = secret.Substring(0, ind) + t + secret.Substring(ind + 1);
        }
        public static void playGame()
        {
            while (secret.Contains("_") && lives > 0)
            {
                printGame();
                Console.WriteLine("What's your guess?");
                String guess = Console.ReadLine();
                if(guess.Length == 1)
                {
                    if (guessed.Contains(guess))
                    {
                        Console.WriteLine("You already guessed that!");
                        continue;
                    }
                    else
                    {
                        if(word.IndexOf(guess) > -1)
                        {
                            reveal(Convert.ToChar(guess));
                        }
                        else
                        {
                            Console.WriteLine("Wrong! Try again.");
                            lives--;
                        }
                    }
                }
                else
                {
                    if(word == guess)
                    {
                        secret = word;
                        break;
                    }
                }
            }
            if (lives > 0 && !word.Contains("_")) 
            {
                Console.WriteLine("You win! The word was " + word);
            }
            else if(lives == 0)
            {
                Console.WriteLine("You ran out of guesses. The word was " + word);
            }
        }
    }
}
