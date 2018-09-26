using System;
using System.Collections.Generic;
using System.Linq;

/* MyMath namespace
 */
namespace MyMath
{
    /// <summary>
    /// operations class
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// check max in list of nums
        /// </summary>
        /// <param name="nums">ist of numbers</param>
        /// <returns>return the max otheerwise return 0</returns>
        public static int Max(List<int> nums) {
            if (nums.Any()) {
                int max = nums.Max();
                return max;
            }
            return 0;
        }
    }
}
