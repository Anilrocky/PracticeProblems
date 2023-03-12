using System;
namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to practice problems");             
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose an option to perform \n1.Line Comparison \n2.Check Prime Number \n3.Prime Range \n4.Factorial of a number \n5.Arithmetic Operations" +
                    "\n6.Prime Factors \n7.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        LineComparison lineComparison1 = new LineComparison();
                        double line1 = lineComparison1.Length();
                        LineComparison lineComparison2 = new LineComparison();
                        double line2 = lineComparison2.Length();
                        lineComparison2.Equality(line1, line2);
                        lineComparison2.Compare(line1, line2);
                        break;
                    case 2:
                        CheckPrime checkPrime = new CheckPrime();
                        Console.WriteLine("Enter number");
                        int num = Convert.ToInt32(Console.ReadLine());
                        checkPrime.PrimeOrNot(num);
                        break;
                    case 3:                        
                        Console.WriteLine("Enter starting range");
                        int start = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter ending range");
                        int end = Convert.ToInt32(Console.ReadLine());
                        PrimeRange primeRange = new PrimeRange();
                        primeRange.Range(start, end);
                        break;
                    case 4:
                        Console.WriteLine("Enter any number");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Factorial factorial = new Factorial();
                        factorial.FactorialOfNum(n);
                        break;
                    case 5:
                        Console.WriteLine("Enter num1");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter num2");
                        int b = Convert.ToInt32(Console.ReadLine());
                        ArithmeticOperations arithmetic = new ArithmeticOperations();
                        arithmetic.PerformOperations(a, b);
                        break;
                    case 6:
                        Console.WriteLine("Enter number");
                        int c = Convert.ToInt32(Console.ReadLine());
                        PrimeFactors factors = new PrimeFactors();
                        factors.FactorsOfNum(c);
                        break;
                    case 7:
                        flag = false;
                        break;
                }
            }           
        }
    }
}