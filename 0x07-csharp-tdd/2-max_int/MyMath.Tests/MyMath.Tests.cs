using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            List<int> nums = new List<int>();
            int max = 0;
            nums.Add(3);
            nums.Add(4);

            max = MyMath.Operations.Max(nums);

            if (max == 4) Assert.Pass();

        }
    }
}