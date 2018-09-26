using NUnit.Framework;
using Text;

/*
namespace for tests */
namespace Tests
{
    /// <summary>
    /// holds all tests for text.unique
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// tests blank string
        /// </summary>
        [Test]
        public void Test1()
        {
            int res = Text.Str.UniqueChar("");
            if (res == -1) Assert.Pass();
        }

        /// <summary>
        /// tests no unique
        /// </summary>
        [Test]
        public void Test2() {
            int res = Text.Str.UniqueChar("aaa");
            if (res == -1) Assert.Pass();
        }

        /// <summary>
        /// tests on unique
        /// </summary>
        [Test]
        public void Test3() {
            int res = Text.Str.UniqueChar("aab");
            if (res == 2) Assert.Pass();
        }
    }
}