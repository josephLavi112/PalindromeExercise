using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class Wordsmith
    {
        public bool IsAPalindrome(string word)
        {
            string wordLowered = word.ToLower();
            string backwards = "";

            for (int i = wordLowered.Length - 1; i >= 0; i--)
            {
                backwards += wordLowered[i];
            }
            if (wordLowered == backwards)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
