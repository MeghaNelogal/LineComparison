using System;
namespace LineComparison
{
    class Program
    {
        static void Main(String[] args)
        {
            LineLength computation = new LineLength(30, 72, 81, 105);
            computation.CalculateLength();
        }
    }
}
