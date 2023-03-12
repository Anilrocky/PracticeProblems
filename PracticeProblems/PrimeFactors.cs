using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class PrimeFactors
    {
        public void FactorsOfNum(int num)
        {
            Console.Write("Prime factors: ");
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write(" " + i);                 
                }
            }
            Console.WriteLine();
        }
    }
}
