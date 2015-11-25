using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Tests
{
    [TestClass()]
    public class QueensProblemTests
    {
        [TestMethod()]
        public void ValideNewQueenPositionTest()
        {
            int[] board = new int[] { 1, 3, 0 };

            // Valid move
            Assert.IsTrue(QueensProblem.Queens_Backtracking.ValideNewQueenPosition(board, 3, 2));

            // | Problem
            Assert.IsFalse(QueensProblem.Queens_Backtracking.ValideNewQueenPosition(board, 3, 0));

            // / Problem
            Assert.IsFalse(QueensProblem.Queens_Backtracking.ValideNewQueenPosition(board, 3, 1));

            // \ Problem
            Assert.IsFalse(QueensProblem.Queens_Backtracking.ValideNewQueenPosition(board, 3, 3));
        }
    }
}