using System;

namespace CSwork
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (1 == 1)
            {
                Console.WriteLine("Which function would you like to run?");
                string func = Console.ReadLine();
                if (func == "hello")
                {
                    hello();
                }
                else if (func == "add")
                {
                    addition();
                }
                else if (func == "catDog")
                {
                    catDog();
                }
                else if (func == "odd")
                {
                    oddEvent();
                }
                else if (func == "inches")
                {
                    inches();
                }
                else if (func == "echo")
                {
                    echo();
                }
                else if (func == "kg")
                {
                    kg();
                }
                else if (func == "guess")
                {
                    guess();
                }
                else if (func == "date")
                {
                    getDate();
                }
                else if (func == "age")
                {
                    age();
                }
                else
                {
                    break;
                }
            }

        }
        public static void hello()
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Bye " + name);
        }
        public static void addition()
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = 0;
            int num2 = 0;
            string in1 = Console.ReadLine();
            try
            {
                num1 = Convert.ToInt32(in1);
            }
            catch
            {
                Console.WriteLine("Not an Int!");
            }
            Console.WriteLine("Enter the second number: ");
            string in2 = Console.ReadLine();
            try
            {
                num2 = Convert.ToInt32(in2);
            }
            catch
            {
                Console.WriteLine("Not an Int!");
            }

            int sum = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + sum);
        }
        public static void catDog()
        {
            Console.WriteLine("Do you like Dogs or Cats?");
            string choice = Console.ReadLine();
            if (choice == "Dog" || choice == "Dogs")
            {
                Console.WriteLine("Bark!");
            }
            else if (choice == "Cat" || choice == "Cats")
            {
                Console.WriteLine("Meow!");
            }



                
        }
        public static void oddEvent()
        {
            Console.WriteLine("Enter a number.");
            int input = 0;
            string str = Console.ReadLine();
            try
            {
                input = Convert.ToInt32(str);
            }
            catch
            {
                Console.WriteLine("Error: Not a valid int!");
            }
            if (input % 2 == 1)
            {
                Console.WriteLine(input + " is odd.");
            }
            else if (input % 2 == 0)
            {
                Console.WriteLine(input + " is even.");
            }
        }
        public static void inches()
        {
            Console.WriteLine("Enter an amount in feet: ");
            string feet = Console.ReadLine();
            int inches = 0;
            try
            {
                inches = Convert.ToInt32(feet) * 12;
            }
            catch
            {
                Console.WriteLine("Error: Not an Int!");
            }
            Console.WriteLine(feet + " feet = " + inches + " inches.");
        }
        public static void echo()
        {
            Console.WriteLine("Woah, did you hear that echo? Try it out!");
            string ech = Console.ReadLine();
            Console.WriteLine(ech.ToUpper());
            Console.WriteLine(ech.ToLower());
            Console.WriteLine(ech.ToLower());
        }
        public static void kg()
        {
            Console.WriteLine("Enter an amount in pounds: ");
            string input = Console.ReadLine();
            int pounds = 0;
            try
            {
                pounds = Convert.ToInt32(input);
            }
            catch
            {
                Console.WriteLine("Error: Not an int!");
            }
            double kig = pounds * 0.453592;
            Console.WriteLine(pounds + " pounds = " + kig + "kg.");
        }
        public static void guess()
        {
            Console.WriteLine("Make your guess: ");
            String guess = Console.ReadLine();
            if(guess == "csharp")
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }


        }

        public static void getDate()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine("Today is: " + today);
        }

        public static void age()
        {
            Console.WriteLine("What year were you born?");

            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are " +(DateTime.Today.Year - year) + "years old");
        }
    }
}
