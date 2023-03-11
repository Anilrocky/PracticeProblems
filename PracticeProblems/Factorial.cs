using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class Factorial
    {
        public void FactorialOfNum(int  num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;                
            }
            Console.WriteLine("Factorial of " + num + " is: " + fact);
        }
    }
}
