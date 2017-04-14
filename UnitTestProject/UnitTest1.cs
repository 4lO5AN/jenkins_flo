using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsTP;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            int result = Program.Add(10, 2);
            Assert.AreEqual(12, result);
            
        }

        [TestMethod]
        public void TestDiv()
        {
            int result = Program.Divider(10, 2);
            Assert.AreEqual(5, result);

        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException), "Div by 0")]
        public void TestDiv0()
        {
            int result = Program.Divider(10, 0);
            Assert.Fail();

        }

    }
}
