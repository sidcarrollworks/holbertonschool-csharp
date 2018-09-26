using System;
using System.Linq;
using System.Text.RegularExpressions;

/* 
    Text namespace
*/
namespace Text
{
    /// <summary>
    /// Str class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// checks if stirng is palindrome
        /// </summary>
        /// <param name="s">string to check</param>
        /// <returns>true if palindrome or 0 if not</returns>
        public static bool IsPalindrome(string s) {
            s = s.ToLower();
            string res = Regex.Replace(s, @"\p{P} ", "");
            string cpy = String.Copy(res);

            for (int i = 0; i < res.Length; i++) {
                if (cpy[i] != res[i]) return false;
            }

            return true;
        }
    }
}
