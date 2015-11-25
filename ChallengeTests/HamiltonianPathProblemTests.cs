using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils;

namespace Challenge.Tests
{
    [TestClass()]
    public class HamiltonianPathProblemTests
    {
        [TestMethod()]
        public void IsValidTest()
        {
            // Cycle exist
            var graphe = new Graphe(4);
            graphe.AddConnection(0,1);
            graphe.AddConnection(1, 2);
            graphe.AddConnection(2, 3);
            graphe.AddConnection(3, 0);

            var hamiltonCycle = new HamiltonianCycleProblem.Hamiltonian_Backtracking(graphe);
            Assert.IsTrue(hamiltonCycle.Solve());

            // Cycle not exist
            var graphe2 = new Graphe(4);
            graphe.AddConnection(0, 1);
            graphe.AddConnection(1, 2);
            graphe.AddConnection(2, 3);

            var hamiltonCycle2 = new HamiltonianCycleProblem.Hamiltonian_Backtracking(graphe2);
            Assert.IsFalse(hamiltonCycle2.Solve());
        }
    }
}