using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    public class Fibonacci_Number
    {
        public int FibonacciNumber(int n)
        {
            int i, j;
            if (n < 0) return -1;
            if (n == 0) return 0;
            if (n == 1) return 1;
            i = FibonacciNumber(n - 2);
            j = FibonacciNumber(n - 1);
            return (i + j);
        }
    }
}
