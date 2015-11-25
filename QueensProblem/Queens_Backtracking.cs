using System;
using System.Collections.Generic;

namespace Challenge.QueensProblem
{
    public class Queens_Backtracking : IQueenSolution
    {
        private int _numberOfQueens;
        private int[] _columnOfQueensByRow;

        private List<int[]> solutions;
        private int result;

        public int SolveQueenProblem(int n)
        {
            result = 0;
            _numberOfQueens = n;
            _columnOfQueensByRow = new int[_numberOfQueens];
            solutions = new List<int[]>();

            Solve(0);

            return result;
        }

        public void PrintSolution()
        {
            foreach (var solution in solutions)
            {
                for (int i = 0; i < _numberOfQueens; i++)
                {
                    for(int j = 0 ; j < _numberOfQueens; j++)
                    {
                        if (solution[i] == j)
                        {
                            Console.Write(" * ");
                        }
                        else
                        {
                            Console.Write(" - ");
                        }
                    }

                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        private void Solve(int rowIndex)
        {
            if (rowIndex == _numberOfQueens)
            {
                // We found a solution
                /*
                int[] copy = new int[_numberOfQueens];
                _columnOfQueensByRow.CopyTo(copy, 0);
                solutions.Add(copy);
                */
                ++result;
                return;
            }

            for (int columnIndex = 0; columnIndex < _numberOfQueens; columnIndex++)
            {
                if (ValideNewQueenPosition(_columnOfQueensByRow, rowIndex, columnIndex))
                {
                    _columnOfQueensByRow[rowIndex] = columnIndex;
                    Solve(rowIndex + 1);
                }
            }
        }

        public static bool ValideNewQueenPosition(int[] board, int row, int column)
        {
            for (int i = 0; i < row; i++)
            {
                // Check if queen on same column
                if (board[i] == column)
                {
                    return false;
                }

                // Check for \ diagonal
                if (board[i] == column - (row - i))
                {
                    return false;
                }

                // Check for / diagonal
                if (board[i] == column + (row - i))
                {
                    return false;
                }

            }

            return true;
        }
    }
}