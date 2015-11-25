using System;
using System.Diagnostics;

namespace Challenge.QueensProblem
{
    public static class QueenPerformanceTest
    {
        public static void Test(IQueenSolution solution)
        {
            TestHelper(solution, 3);
            TestHelper(solution, 4);
            TestHelper(solution, 6);
            TestHelper(solution, 8);
            TestHelper(solution, 10);
            TestHelper(solution, 12);
            TestHelper(solution, 14);
        }

        private static void TestHelper(IQueenSolution solution, int n)
        {
            Stopwatch wath = new Stopwatch();
            wath.Start();
            int result = solution.SolveQueenProblem(n);
            wath.Stop();
            
            Console.WriteLine("{0} queens| Result : {1}, Time : {2}ms", n, result, wath.ElapsedMilliseconds);
        }
    }
}
