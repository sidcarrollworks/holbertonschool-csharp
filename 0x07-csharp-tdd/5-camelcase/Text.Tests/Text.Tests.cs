using NUnit.Framework;
using Text;

/*
    Test Namespace
*/
namespace Tests
{
    /// <summary>
    /// test class
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// test for empty string
        /// </summary>
        [Test]
        public void Test1()
        {
            int res = Text.Str.CamelCase("");
            if (res == 0) Assert.Pass();
        }

        /// <summary>
        /// test one word
        /// </summary>
        [Test]
        public void Test2()
        {
            int res = Text.Str.CamelCase("bill");
            if (res == 1) Assert.Pass();
        }

        /// <summary>
        /// test 2 words
        /// </summary>
        [Test]
        public void Test3()
        {
            int res = Text.Str.CamelCase("billBob");
            if (res == 2) Assert.Pass();
        }

        /// <summary>
        /// test 2 words
        /// </summary>
        [Test]
        public void Test4()
        {
            int res = Text.Str.CamelCase("billBobjohn");
            if (res == 2) Assert.Pass();
        }
    }
}