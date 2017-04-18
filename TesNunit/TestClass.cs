using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using JenkinsTP;

namespace TesNunit
{
    class TestClass
    {
        static void Main(string[] args)
        {
        }

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
