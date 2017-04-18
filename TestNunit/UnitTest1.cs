using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using JenkinsTP;

namespace TestNunit
{
    [TestClass]
    public class UnitTest1
    {
        [Test]
        public void TestAdd()
        {
            int result = Program.Add(10, 2);
            NUnit.Framework.Assert.AreEqual(12, result);

        }

        [Test]
        public void TestDiv()
        {
            int result = Program.Divider(10, 2);
            NUnit.Framework.Assert.AreEqual(5, result);

        }

        [Test]
        public void TestDiv0()
        {
            NUnit.Framework.Assert.Throws<DivideByZeroException>(() => JenkinsTP.Program.Divider(10, 0));

        }

    }
}
