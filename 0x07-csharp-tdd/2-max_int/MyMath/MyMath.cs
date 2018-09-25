using System;
using System.Collections.Generic;
using System.Linq;


namespace MyMath
{
    public class Operations
    {
        public static int Max(List<int> nums) {
            if (nums.Any()) {
                int max = nums.Max();
                return max;
            }
            return 0;
        }
    }
}
