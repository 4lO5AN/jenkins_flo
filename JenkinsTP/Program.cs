using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: CLSCompliant(true)]

namespace JenkinsTP
{
    public static class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }
  
        static void Main()
        {
        }
    }
}
