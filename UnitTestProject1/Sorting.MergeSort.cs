using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
 

namespace UnitTestProject1
{
    [TestClass]
    public class MergesortTests
    {
        [TestMethod]
        public void When_Then()
        {
            int[] ar = new int[] { 6, 5, 4, 3, 2, 1 };

            Code.Sorting.MergeSort(ar);
            Assert.IsTrue(ar.SequenceEqual(new int[] { 1, 2, 3, 4, 5, 6 }));

        }
    }
}
