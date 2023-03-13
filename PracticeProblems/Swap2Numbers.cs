using System;
namespace PracticeProblems
{
    public class Swap2Numbers
    {
        public void SwapNum()
        {
            Console.WriteLine("Choose method to Execute \n1.Method1(using + and -) \n2.Method2(using * and /)");
            int method = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b value");
            int b = Convert.ToInt32(Console.ReadLine());
            switch (method)
            {
                case 1:                    
                    a = a + b;
                    b = a - b;
                    a = a - b;
                    Console.WriteLine("a value is: " + a);
                    Console.WriteLine("b value is: " + b);
                    break;
                case 2:
                    a = a * b;
                    b = a / b;
                    a = a / b;
                    Console.WriteLine("a value is: " + a);
                    Console.WriteLine("b value is: " + b);
                    break;
            }           
        }
    }
}
