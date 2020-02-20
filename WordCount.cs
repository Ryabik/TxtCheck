using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextCheck
{
    public class WordCount
    {
        public static int vowelsWord(string input)
        {
            //Regex vowelChars = new Regex("[aeiouy]");
            string[] temp = input.ToLower().Split(' ', ',', '.', '!', '?', ':', ';', '-');
            int countOfWords = 0;
            bool isVowelWord = false;
            foreach (string word in temp)
            {
                foreach (var symbol in word)
                {

                    if (symbol.Equals ('a') ||
                        symbol.Equals('e') || 
                        symbol.Equals('i') || 
                        symbol.Equals('o') || 
                        symbol.Equals('u') || 
                        symbol.Equals('y'))
                    {
                        
                        isVowelWord = true;
                    }
                    else
                    {
                        isVowelWord = false;
                        break;
                    }
                    
                }
                if (isVowelWord)
                {
                    countOfWords++;
                    isVowelWord = false;
                }
                
            }
            return countOfWords;
        }
    }
}
