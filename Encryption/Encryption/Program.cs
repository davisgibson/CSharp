using System;
using System.Collections;
using System.Collections.Generic;

namespace Encryption
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Encryption!");
            while (1 == 1)
            {
                Console.WriteLine("Enter 'e' for encryption and 'd' for decription.");
                string choice = Console.ReadLine();
                choice.ToLower();
                if(choice != "e" && choice != "d")
                {
                    Console.WriteLine("Invalid Input! Bye Bye!");
                    break;
                }
                else if(choice == "e")
                {
                    Console.WriteLine("Enter the message you would like to encrypt.");
                    string phrase = Console.ReadLine();
                    Console.WriteLine("Enter the offset: ");
                    int off = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(encrypt(phrase, off));
                }
                else
                {
                    Console.WriteLine("Enter the message you would like to decrypt: ");
                    string phrase = Console.ReadLine();
                    Console.WriteLine("Enter the offset: ");
                    int off = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(decrypt(phrase, off));
                }

            }


        }
        public static string encrypt(string p, int offset)
        {
            string ret = "";
            string alph = "abcdefghijklmnopqrstuvwxyz ";
            Char[] chars = p.ToCharArray();

            for(int i = 0; i < chars.Length; i++)
            {
                int index = alph.IndexOf(chars[i]);

                index = index + offset;
                if (index >= alph.Length)
                {
                    index = index - alph.Length;
                }

                string add = alph.Substring(index, 1);
                ret = ret + add;
            }
            return ret;
        }
        public static string decrypt(string p, int offset)
        {
            string ret = "";
            string alph = "abcdefghijklmnopqrstuvwxyz ";
            Char[] chars = p.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                int index = alph.IndexOf(chars[i]);

                index = index - offset;
                if (index < 0)
                {
                    index = index + alph.Length;
                }

                string add = alph.Substring(index, 1);
                ret = ret + add;
            }
            return ret;
        }
    }
}
