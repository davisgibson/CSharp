using System;

namespace CSwork
{
    public class RockPaperScissors
    {
        public static void Main(String[] args)
        {

            Random random = new Random();
            bool x = true;
            while (x)
            {
                int choice = random.Next(0, 3) + 1;
                string hand2 = "";
                switch (choice)
                {
                    case 1:
                        hand2 = "rock";
                        break;
                    case 2:
                        hand2 = "paper";
                        break;
                    case 3:
                        hand2 = "scissors";
                        break;
                }

                Console.WriteLine("1...");
                Console.WriteLine("2...");
                Console.WriteLine("3...");
                String input = Console.ReadLine(); 
                input = input.ToLower();
                if (input!="rock" && input != "scissors" && input != "paper")
                {
                    Console.WriteLine("Invalid move!");
                    break;
                }
                Console.WriteLine("CPU chose " + hand2);

                bool won = didWin(input, hand2);
                if (won)
                {
                    Console.WriteLine("You won!");
                }
                else
                {
                    Console.WriteLine("You lost :(");
                }
            }

        }
        public static bool didWin(String hand1, String hand2)
        {
            bool ret = false;
            if (hand1 == "rock")
            {
                if (hand2 == "paper")
                {
                    ret = false;
                }
                else if (hand2 == "scissors")
                {
                    ret = true;
                }
                else
                {
                    ret = true;
                }
            }
            if(hand1 == "paper")
            {
                if(hand2 == "scissors")
                {
                    return false;
                }
                else if (hand2 == "rock")
                {
                    return true;
                }
                else
                {
                    return true;
                }
            }
            if (hand1 == "scissors")
            {
                if (hand2 == "paper")
                {
                    return true;
                }
                else if (hand2 == "rock")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }


            return ret;
        }
    }
}
