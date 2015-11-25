using NUnit.Framework;

namespace Challenge.Test
{
    [TestFixture]
    public class QueenTest
    {
        [Test]
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