using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeletgateEventConsoleApplication1
{
    class Program
    {
        delegate int Converter(int x);
        public delegate void Printer(int percentComplete);
        
        static void Main(string[] args)
        {
            Converter t = Square; // Create delegate instance 
            int result = t(3);    // Invoke delegate 
            Console.WriteLine(result); // 9
            System.Threading.Thread.Sleep(2000);

            X x = new X();
            Printer p = x.methodA;
            p(1);
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine(p.Target == x); // True
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine(p.Method); // Void methodA(Int32)
            System.Threading.Thread.Sleep(2000);
        }

        static int Square(int x) { return x * x; }
    }

    class X
    {
        public void methodA(int percentComplete)
        {
            Console.WriteLine(percentComplete);
        }
    }
}
