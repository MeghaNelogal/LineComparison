using System;
namespace LineComparison
{
    class Program
    {
        static void Main(String[] args)
        {
            LineLength computation = new LineLength(30, 65, 87, 100);
            double line1 = computation.CalculateLength();
            LineLength line = new LineLength(35, 74, 82, 110);
            double line2 = line.CalculateLength();
            if (line1.CompareTo(line2) == 0)
            {
                Console.WriteLine("Length of both lines are equal");
            }
            if (line1.CompareTo(line2) > 0)
            {
                Console.WriteLine("Line 1 is greater");
            }
            else
            {
                Console.WriteLine("Line 2 is greater");
            }

        }
    }
}