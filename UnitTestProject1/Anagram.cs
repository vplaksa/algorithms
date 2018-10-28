using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestAnagram
    {
        [TestMethod]
        public void IsAnagramTest()
        {
            var s1 = "abc";
            var s2 = "cba";

            AnagramAssert(s1, s2);
        }

        [TestMethod]
        public void IsAnagramTest_Negative()
        {
            var s1 = "abcc";
            var s2 = "cba";

            AnagramAssert(s1, s2);
        }

        [TestMethod]
        public void IsAnagramTest_Negative2()
        {
            var s1 = "тест";
            var s2 = "естт";

            AnagramAssert(s1, s2);
        }

        [TestMethod]
        public void IsAnagramTest_Negative3()
        {
            var s1 = "тестт";
            var s2 = "сеетт";

            AnagramAssert(s1, s2);
        }

        private void AnagramAssert(string s1, string s2) => Assert.IsTrue(Code.Anagram.IsAnagramBuffer(s1, s2));
    }
}
