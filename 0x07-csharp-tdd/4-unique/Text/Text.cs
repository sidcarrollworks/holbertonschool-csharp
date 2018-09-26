using System;

/*
text namespace */
namespace Text
{
    /// <summary>
    /// holds str functions
    /// </summary>
    public class Str
    {
        /// <summary>
        /// finds first non repeating character in string
        /// </summary>
        /// <param name="s"> string to check</param>
        /// <returns>index of first non repearint char</returns>
        public static int UniqueChar(string s) {
            if (s == "") return -1;

            char tmp = s[0];

            for (int i = 0; i < s.Length; i++) {
                if (s[i] == tmp) {
                    tmp = s[i];
                } else {
                    return i;
                }
            }
            return -1;
        }
    }
}
