
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

        [TestMethod]
        public void TestFormat()
        {
            DateTime date = DateTime.Now;

            Assert.AreEqual(
                string.Format("The current time is {0:HH:mm}", date), 
                "The current time is " + date.ToString("HH:mm"));

            Assert.AreEqual(
                string.Format("the number is {0:N2}", 23.4514),
                "the number is 23.45");
        }
    }
}
