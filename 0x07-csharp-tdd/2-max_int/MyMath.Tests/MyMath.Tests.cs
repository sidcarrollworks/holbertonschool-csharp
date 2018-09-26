using NUnit.Framework;
using MyMath;
using System;
using System.Collections.Generic;

/*
    Namespace for tests
 */
namespace Tests
{
    /// <summary>
    /// tests class
    /// </summary>
    [TextFixture]
    public class Tests
    {

        /// <summary>
        /// Checks if find max
        /// </summary>
        [Test]
        public void Test1()
        {
            List<int> nums = new List<int>();
            int max = 0;
            nums.Add(3);
            nums.Add(4);

            max = MyMath.Operations.Max(nums);
            Console.WriteLine(max);

            if (max == 4) Assert.Pass();

        }
    }
}