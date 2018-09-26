using NUnit.Framework;
using Text;

/*
    tests for is palindrome
*/
namespace Tests
{
    /// <summary>
    /// tets class
    /// </summary>
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// basic palindrome check
        /// </summary>
        [Test]
        public void Test1()
        {
            string car = "racecar";
            if (Text.Str.IsPalindrome(car)) Assert.Pass();
        }
        /// <summary>
        /// checks capitals
        /// </summary>
        [Test]
        public void Test2() {
            string Car = "Racecar";
            if (Text.Str.IsPalindrome(Car)) Assert.Pass();
        }
        /// <summary>
        /// check fro puncutation
        /// </summary>
        [Test]
        public void Test3() {
            string _car = "rac_e_car";
            if (Text.Str.IsPalindrome(_car)) Assert.Pass();
        }
        /// <summary>
        /// punctuation and capitals
        /// </summary>
        [Test]
        public void Test4() {
            string _caR = "_Ra_cec_ar";
            if (Text.Str.IsPalindrome(_caR)) Assert.Pass();
        }
    }
}