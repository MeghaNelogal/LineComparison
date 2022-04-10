using System;
namespace LineComparison
{
    class Program
    {
        static void Main(String[] args)
        {
            LineLength computation = new LineLength(40, 70, 93, 120);
            double line1 = computation.CalculateLength();
            LineLength line = new LineLength(44, 68, 79, 118);
            double line2 = line.CalculateLength();
            if (line1.Equals(line2))
                Console.WriteLine("Length of both lines are equal");
            else

                Console.WriteLine("Length of both lines are not equal");

        }
    }
}