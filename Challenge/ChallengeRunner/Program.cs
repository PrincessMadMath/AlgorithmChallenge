using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Challenge;
using Challenge.QueensProblem;

namespace ChallengeRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Queens_Backtracking();
            QueenPerformanceTest.Test(solution);
            Console.ReadLine();
        }
    }
}
