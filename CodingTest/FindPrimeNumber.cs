using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
   public  class FindPrimeNumber
    {
        public static List<int> PrimeNumber(int n, out int total)
        {
            //Return total number of prime number in the integer list 1, 2, ..., n
            int count = 0;
            List<int> primes=new List<int>();
            for(int i=2;i<=n;i++)
            {
                int flag = 0;
                for(int j=2;j<i;j++)
                {
                    //if flag>0 then i is not prime number.
                    if (i % j == 0)
                    {
                        flag++;
                        break;
                    }
                }
                if (flag == 0)
                {
                    count++;
                    primes.Add(i);
                }
                    
            }
            total = count;
            return primes;
        }
    }
}
