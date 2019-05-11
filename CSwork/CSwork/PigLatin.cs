using System;
namespace CSwork
{
    public class PigLatin
    {
        public static void main(String[] args)
        {
            Console.WriteLine("Welcome to pig latin!");
            bool x = true;
            while (x)
            {
                Console.WriteLine("What word would you like to translate?");
                String word = Console.ReadLine();
                Console.WriteLine(translate(word));
                Console.WriteLine("Would you like to do another? (y/n)");
                String choice = Console.ReadLine();
                if (choice.Equals("n")){
                    x = false;
                }
            }
            
        }
        public static String translate(String word)
        {
            String firstChar = word.Substring(0, 1);
            String lastChar = word.Substring(word.Length - 1);
            String vowels = "aeiouAEIOU";
            String consonants = "bcdfghjklmnpqrstvxzBCDFGHJKLMNPQRSTVXZ";
            Char[] vows = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            if (vowels.Contains(firstChar) && vowels.Contains(lastChar))
            {
                word = word + "yay";
            }
            else if(vowels.Contains(firstChar) && consonants.Contains(lastChar))
            {
                word = word + "ay";
            }
            else if (word.IndexOfAny(vows) < 0)
            {
                word = word + "ay";
            }
            else if(word.IndexOfAny(vows) > -1 && consonants.Contains(firstChar))
            {
                int indexOfFirstVowel = word.IndexOfAny(vows);
                word = word.Substring(indexOfFirstVowel) + word.Substring(0, indexOfFirstVowel) + "ay";
                
            }
            return word;
        }
    }
}
