using Ex_Monthly_03_Project.Factories;
using Ex_Monthly_03_Project.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Monthly_03_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IObjectFactory factory = new ObjectFactory();
            TestClass t = new TestClass(factory);
            t.TestMethod();
            Console.ReadLine();
        }
    }
}
