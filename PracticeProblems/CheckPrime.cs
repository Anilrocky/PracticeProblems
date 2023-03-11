using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class CheckPrime
    {
        public void PrimeOrNot(int num)
        {
            bool Is_Prime = true;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Is_Prime = false;
                    break;
                }
                else
                {
                    Is_Prime = true;
                }
            }
            if (Is_Prime == true)
                Console.WriteLine("{0} is Prime Number", num);
            else
                Console.WriteLine("{0} is not Prime Number", num);
        }
    }
}
