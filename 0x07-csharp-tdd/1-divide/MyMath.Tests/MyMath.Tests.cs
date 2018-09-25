using NUnit.Framework;
using MyMath;
using System.Linq;
using System;

/*
    Test namespace
*/
namespace Tests
{
    /// <summary>
    /// tests
    /// </summary>
    public class Tests
    {

        /// <summary>
        /// first test
        /// </summary>
        [Test]
        public void Test1()
        {
            int[,] matrix = {{4, 4}, {4, 4}};
            int[,] div = {{2, 2}, {2, 2}};
            int num = 2;
            var res = MyMath.Matrix.Divide(matrix, num);

            bool isEqual = Enumerable.SequenceEqual(res.Cast<int>(), div.Cast<int>());

            if (isEqual) Assert.Pass();
        }
    }
}