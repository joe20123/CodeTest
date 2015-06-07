using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    public interface INewInterface
    {
        void DoSomthing();
    }

    public static class ExtensionMethodUsingMixin
    {
        public static void FirstExtensionMethod(this INewInterface target)
        {
            Console.WriteLine("First Extension Method is called.");
        }
    }
}
