using System;

/*
    text namespace
*/
namespace Text
{
    /// <summary>
    /// str class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// check to see how many words are in string
        /// </summary>
        /// <param name="s">input string</param>
        /// <returns>number of words</returns>
        public static int CamelCase(string s) {
            if (s == "") return 0;

            int num = 0;

            foreach (char x in s) {
                if (char.IsUpper(x)) num++;
            }

            return num + 1;
        }

    }
}
