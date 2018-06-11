
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleTestApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestChecked()
        {
            int maxValue = int.MaxValue;

            Assert.AreEqual(unchecked(maxValue + 1), int.MinValue);

            Assert.ThrowsException<OverflowException>(() =>
            {
                int overValue = checked(maxValue + 1);
            });
        }
    }
}
