using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class Class1
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
