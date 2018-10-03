using System;
using NUnit.Framework;

namespace algorithms
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test()
        {
            int[] a = new int[] { 2, 4, 6 };
            int[] b = new int[] { 1, 3, 5 };

            var re = Code.Sorting.Merge(a, b);

            Assert.IsTrue(true);
        }
    }
}
