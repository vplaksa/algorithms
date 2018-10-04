using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Linq.Expressions;

namespace UnitTestProject1
{
    [TestClass]
    public class TestMerge
    {
        [TestMethod]
        public void WhenBothSorted_ThenMerge()
        {
            int[] a = new int[] { 2, 4, 6 };
            int[] b = new int[] { 1, 3, 5 };

            var re = Code.Sorting.Merge(a, b);

            Assert.IsTrue(re.SequenceEqual(new int[] { 1,2,3,4,5,6 }));
        }

        [TestMethod]
        public void WhenFirstEmpty_ThenMerge()
        {
            int[] a = new int[] { };
            int[] b = new int[] { 1, 3, 5 };

            var re = Code.Sorting.Merge(a, b);

            Assert.IsTrue(re.SequenceEqual(new int[] { 1,3,5}));
        }


        [TestMethod]
        public void WhenSecondEmpty_ThenMerge()
        {
            int[] a = new int[] { 1, 3, 5 };
            int[] b = new int[] { };

            var re = Code.Sorting.Merge(a, b);

            Assert.IsTrue(re.SequenceEqual(new int[] { 1, 3, 5 }));
        }

        [TestMethod]
        public void WhenBothEmpty_ThenMergeReturnEmpty()
        {
            int[] a = new int[] { };
            int[] b = new int[] { };

            var re = Code.Sorting.Merge(a, b);

            Assert.IsTrue(re.SequenceEqual(new int[] {  }));
        }

        [TestMethod]
        public void WhenFirstNull_ThenMerge()
        {
            int[] a = null;
            int[] b = new int[] { 1, 3, 5 };

            var re = Code.Sorting.Merge(a, b);

            Assert.IsTrue(re.SequenceEqual(new int[] { 1, 3, 5 }));
        }

        [TestMethod]
        public void WhenSecondNull_ThenMerge()
        {
            int[] a = new int[] { 1, 3, 5 };
            int[] b = null;

            var re = Code.Sorting.Merge(a, b);

            Assert.IsTrue(re.SequenceEqual(new int[] { 1, 3, 5 }));
        }

        [TestMethod]
        public void WhenBothNull_ThenMergeReturnEmpty()
        {
            int[] a = null;
            int[] b = null;

            var re = Code.Sorting.Merge(a, b);

            Assert.IsTrue(re.SequenceEqual(new int[] { }));
        }
    }
}
