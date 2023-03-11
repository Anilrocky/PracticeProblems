using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class ArithmeticOperations
    {
        public void PerformOperations(int a, int b)
        {
            Console.WriteLine("Choose option to perform \n1.Addition \n2.Substraction \n3.Multiplication \n4.Division \n5.Modular");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Additon is: "+(a+b));
                    break;
                case 2:
                    Console.WriteLine("Substraction is: " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Multiplication is: " + (a * b));
                    break;
                case 4:
                    Console.WriteLine("Division is: " + (a / b));
                    break;
                case 5:
                    Console.WriteLine("Modular is: " + (a % b));
                    break;
            }
        }
    }
}
