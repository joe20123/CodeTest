using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool ok = IsUniqueChar("AmzonTestig");

            //Fibonacci number
            //Fibonacci_Number f = new Fibonacci_Number();
            //int result =f.FibonacciNumber(10);
            //Console.WriteLine(result);
            //Console.ReadLine();

            //get all subsets
            //List<int> set = new List<int> { 10, 20, 30 };
            //List<List<int>> allset = new List<List<int>>();
            //allset = AllSubsetOfASet.getSubSets(set);
            //Console.ReadLine();
            int total;
            var n = FindPrimeNumber.PrimeNumber(100,out total);
            Console.WriteLine("total number of prime number is {0}", total);
            
            foreach(var i in n)
            {
                Console.WriteLine("\t{0}", i);
            }
            Console.ReadKey();
            
        }

        public static bool IsUniqueChar(string str)
        {
            bool[] char_set = new bool[256];
            char[] charvalue = str.ToCharArray();
            for (int i=0;i<str.Length-1 ;i++)
            {
                int value = Convert.ToInt32(charvalue[i]);
                if (char_set[value]) return false;
                char_set[value] = true;
               
            }
            return true;
        }

        public static bool isUniqueChar2(string str)
        {
            bool[] charset = new bool[256];
            char[] charvalues = str.ToCharArray();
            for (int i = 0; i < str.Length-1; i++)
            {
                int value = Convert.ToInt32(charvalues[i]);
                if (charset[value]) return false;
                charset[value] = true;

            }
            return true;
        }

        public static bool isUniqueChar3(string str)
        {
            bool[] charset = new bool[256];
            char[] charsetvalue = str.ToCharArray();
            for (int i=0; i < str.Length - 1; i++)
            {
                if (charset[charsetvalue[i]]) return false;
                charset[charsetvalue[i]] = true;
            }
            return true;
        }



        //return head node
        Node deleteNode(Node head, int d)
        {
            Node n = head;
            if (n.data == d)
            {
                return n.next;
            }
            while (n.next != null)
            {
                if (n.next.data == d)
                {
                    n.next = n.next.next;
                    return head;
                }
            }
            return head;
        }
    }
}
