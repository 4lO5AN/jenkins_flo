using System;
using NUnit.Framework;
using JenkinsTP;

[assembly: CLSCompliant(true)]
namespace TestNunit
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestAdd()
        {
            int result = Program.Add(10, 2);
            Assert.AreEqual(12, result);

        }

        [Test]
        public void TestDiv()
        {
            int result = Program.Divider(10, 2);
            Assert.AreEqual(5, result);

        }

        [Test]
        public void TestDiv0()
        {
            Assert.Throws<DivideByZeroException>(() => JenkinsTP.Program.Divider(10, 0));

        }

    }
}
