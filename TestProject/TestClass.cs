using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestProject
{
    class TestClass
    {
        static void Main(string[] args)
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
            [ExpectedException(typeof(DivideByZeroException), "Div by 0")]
            public void TestDiv0()
            {
                int result = Program.Divider(10, 0);
                Assert.Fail();

            }
    }
    }
}
