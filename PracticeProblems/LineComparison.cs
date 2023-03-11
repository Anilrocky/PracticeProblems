using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class LineComparison
    {
        public double Length()
        {
            Console.WriteLine("Input x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(length);
            return length;
        }
        public void Equality(double line1, double line2)
        {
            if (line1.Equals(line2))
                Console.WriteLine("Lines are equal");
            else
                Console.WriteLine("Lines are not equal");
        }
        public void Compare(double line1, double line2)
        {
            if (line1.CompareTo(line2) > 0)
                Console.WriteLine("line1 is greater than line2");
            if (line1.CompareTo(line2) < 0)
                Console.WriteLine("line2 is greater than line1");
            if (line1.CompareTo(line2) == 0)
                Console.WriteLine("Both lines are equal");
        }
    }
}
