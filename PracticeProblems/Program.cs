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
                Console.WriteLine("Choose an option to perform \n1.Line Comparison \n2.Exit");
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
                        flag = false;
                        break;
                }
            }           
        }
    }
}