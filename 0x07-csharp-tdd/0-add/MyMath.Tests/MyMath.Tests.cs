using NUnit.Framework;
using MyMath;

/*
    Test Namespace
*/
namespace Tests
{
    /// <summary>
    /// class that holds tests
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Tests
        /// </summary>
        [Test]
        public void Test1()
        {
            int res = MyMath.Operations.Add(1, 1);
            if (res == 2) Assert.Pass();
        }
    }
}