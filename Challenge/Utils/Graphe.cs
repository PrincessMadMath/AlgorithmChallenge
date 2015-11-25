using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace Utils
{
    public class Graphe
    {
        public int Size;
        private bool[,] _adjencyMatrix;

        public Graphe(int size)
        {
            _adjencyMatrix = new bool[size,size];
            Size = size;
        }

        public void AddConnection(int i, int j)
        {
            if (i < 0 || i >= Size || j < 0 || j >= Size)
            {
                throw new ArgumentException("Not valid index");
            }

            _adjencyMatrix[i, j] = true;
            _adjencyMatrix[j, i] = true;
        }

        public bool IsConnected(int i, int j)
        {
            if (i < 0 || i >= Size || j < 0 || j >= Size)
            {
                throw new ArgumentException("Not valid index");
            }

            return _adjencyMatrix[i, j];
        }

        public List<int> GetAllNodes()
        {
            return Enumerable.Range(0, Size).ToList();
        }
    }
}