using AOPConPostsharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOPConPostsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.Read();
        }

        [TimeTraceAspect("uno")]
        private static void Method1()
        {
            System.Threading.Thread.Sleep(1000);
        }

        [TimeTraceAspect]
        private static void Method2()
        {
            System.Threading.Thread.Sleep(2000);
        }
    }
}
