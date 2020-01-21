using System;
using System.Collections.Generic;


namespace Palindrome_dojo
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> palindroms = new List<string> {"pop", "maoam", "ada", "ère", "elle" };
            string palindromString = "pop maoam ada ère elle";
            PalindromTableFromString(palindromString);

            Dictionary<string, bool> dico = PalindromTableFromString(palindromString); 
            /*Dictionary<string, bool> palindromsOrNot = PalindromTable(palindroms);*/
            foreach (string key  in dico.Keys)
            {
                Console.WriteLine("Key {0} - Value : {1}", key, dico[key]);
            }

         }

        public static bool IsPalindrome(string word)
        {
            for(int i = 0; i < word.Length / 2; i++)
            {
                if(word[i] != word[(word.Length - 1 )- i ])
                {
                    return false;
                }
            }
            return true;

        }

        public static Dictionary<string, bool> PalindromTable (List<string> palindroms)
        {
            Dictionary<string, bool> dico = new Dictionary<string, bool>();
            
            
            for (int i = 0; i< palindroms.Count; i++)
            {
                string currentPalindrom = palindroms[i];
                dico[currentPalindrom] = IsPalindrome(currentPalindrom);
            }
            return dico;
        }

        public static Dictionary<string, bool> PalindromTableFromString(string palindroms)
        {
           
            List<string> listOfPalindroms = new List<string>(palindroms.Split(" "));
            Dictionary<string, bool> newDico = PalindromTable(listOfPalindroms);
            return newDico;

        }



    }

}
