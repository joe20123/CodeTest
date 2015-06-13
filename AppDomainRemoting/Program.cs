using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainRemoting
{
    class Program
    {
        static void Main(string[] args)
        {

            AppDomain newDomain = AppDomain.CreateDomain("New Domain");


            Foo foo = (Foo)newDomain.CreateInstanceAndUnwrap(
                typeof(Foo).Assembly.FullName,
                typeof(Foo).FullName);

            Console.WriteLine(foo.SayHello());

            AppDomain.Unload(newDomain);
            Console.ReadLine();
        }
    }

    public class Foo: MarshalByRefObject
    {

        public string SayHello()
        {
            return "hello from " + AppDomain.CurrentDomain.FriendlyName;
        }

        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}
