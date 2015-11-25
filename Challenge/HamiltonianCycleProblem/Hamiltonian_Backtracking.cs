using System;
using System.Collections.Generic;
using System.Linq;
using Utils;

namespace Challenge.HamiltonianCycleProblem
{
    public class Hamiltonian_Backtracking
    {
        private int[] possibleSolutions; 
        private List<int[]> solutions = new List<int[]>();
        private Graphe _graphe;

        public Hamiltonian_Backtracking(Graphe graphe)
        {
            _graphe = graphe;
            possibleSolutions = new int[graphe.Size];
        }

        public bool Solve()
        {
            possibleSolutions[0] = 0;
            Solve(1);

            return solutions.Any();
        }

        private void Solve(int position)
        {
            if (position == _graphe.Size)
            {
                // Cycle si dernier élément connecté au premier
                if (_graphe.IsConnected(possibleSolutions[0], possibleSolutions[position - 1]))
                {
                    var copy = new int[_graphe.Size];
                    possibleSolutions.CopyTo(copy, 0);
                    solutions.Add(copy);
                    return;
                }
            }
            else
            {
                foreach (int i in _graphe.GetAllNodes())
                {
                    if (IsValidHelper(position, i))
                    {
                        possibleSolutions[position] = i;
                        Solve(position + 1);
                    }
                }
            }
        }

        private bool IsValidHelper(int position, int value)
        {
            return IsValid(_graphe, possibleSolutions, position, value);
        }


        public static bool IsValid(Graphe graphe ,int[] partialSolution, int position, int value)
        {
            if (position > 0)
            {
                // Is connected
                if (!graphe.IsConnected(partialSolution[position - 1], value))
                {
                    return false;
                }

                // Already exist
                for (int i = 0; i < position; i++)
                {
                    if (partialSolution[i] == value)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void PrintSolution()
        {
            foreach (var solution in possibleSolutions)
            {
                foreach (var node in solutions)
                {
                    Console.Write(node);
                    Console.Write("-");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}