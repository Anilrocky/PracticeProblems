using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class PrimeRange
    {
        public void Range(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                int count = 0;
                for (int j = 2; j <=i/2; j++)
                {
                    if (i%j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0 && i!= 1)
                    Console.WriteLine("{0} is Prime", i);
            }
        }
    }
}
