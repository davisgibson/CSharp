using System;
using System.Collections.Generic;
using System.Linq;
namespace ArrayLoopPractice
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Which function would you like to run?");
            Console.WriteLine("-change-");
            String choice = Console.ReadLine();
            if(choice == "change")
            {
                Console.WriteLine("What amount would you like to convert to change? (with a decimal)");
                String am = Console.ReadLine();
                float money = 0.0F;
                try
                {
                    money = float.Parse(am);
                }
                catch
                {
                    Console.WriteLine("Invalid input!");
                }
                List<float> change = getChange(money);
                change.ForEach(Console.WriteLine);

            }




        }
        //convert an amount of money into the smallest amount of bills/coins possible.
        public static List<float> getChange(float amount)
        {
            List<float> ret = new List<float>();

            while(amount >= 100)
            {
                ret.Add(100.0F);
                amount -= 100;
            }
            while(amount >= 20)
            {
                ret.Add(20.0F);
                amount -= 20;
            }
            while(amount >= 10)
            {
                ret.Add(10.0F);
                amount -= 10;
            }
            while(amount >= 5)
            {
                ret.Add(5.0F);
                amount -= 5;
            }
            while (amount >= 1)
            {
                ret.Add(1.0F);
                amount -= 1;
            }
            while(amount >= 0.25F)
            {
                ret.Add(0.25F);
                amount -= 0.25F;
            }
            while(amount >= 0.1F)
            {
                ret.Add(0.1F);
                amount -= 0.1F;
            }
            while (amount >= 0.05F)
            {
                ret.Add(0.05F);
                amount -= 0.05F;
            }
            while (amount >= 0.01F)
            {
                ret.Add(0.01F);
                amount -= 0.01F;
            }
            return ret;
        }


    }
}
