using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestAnagram
    {
        [TestMethod]
        public void WhenAnagramSamelen_ThenShouldBeTrue()
        {
            var s1 = "abc";
            var s2 = "cba";

            AnagramAssert(s1, s2);

            s1 = "тест";
            s2 = "естт";

            AnagramAssert(s1, s2);

            s1 = "aabb";
            s2 = "bbaa";

            AnagramAssert(s1, s2);

            s1 = "aa";
            s2 = "aa";

            AnagramAssert(s1, s2);

            s1 = "й";
            s2 = "й";

            AnagramAssert(s1, s2);

            s1 = "фб";
            s2 = "бф";

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
        public void IsAnagramTest_Negative3()
        {
            var s1 = "тестт";
            var s2 = "сеетт";

            AnagramAssert(s1, s2);
        }

        private void AnagramAssert(string s1, string s2) => Assert.IsTrue(Code.Anagram.IsAnagram(s1, s2));
    }
}
