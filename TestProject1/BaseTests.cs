using Lab7TeamCity;

namespace TestProject1
{
    public class BaseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestOnlySolution()
        {

            double a = 1;
            double b = -4;
            double c = 4;
            List<double> roots = Program.SolveQuadraticEquation(a, b, c);
            List<double> expected_roots = new List<double> { 2 };
            Assert.AreEqual(0, 0); // to check that we are ready to test

            Assert.AreEqual(roots.Count, expected_roots.Count);

            Assert.AreEqual(roots.First(), expected_roots.First());

        }
        [Test]
        public void TestNoSolution()
        {

            double a = 1;
            double b = 1;
            double c = 4;
            List<double> roots = Program.SolveQuadraticEquation(a, b, c);
            List<double> expected_roots = new List<double> { };
            Assert.AreEqual(0, 0); // to check that we are ready to test

            Assert.AreEqual(roots.Count, expected_roots.Count);

        }
        [Test]
        public void TestTwoSolutions()
        {
            double a = 1;
            double b = 10;
            double c = -39;
            List<double> roots = Program.SolveQuadraticEquation(a, b, c);
            List<double> expected_roots = new List<double> { 3, -13 };
            Assert.AreEqual(0, 0); // to check that we are ready to test

            Assert.AreEqual(roots.Count, expected_roots.Count);
            double sum = 0;
            double prod = 1;
            foreach (var root in roots)
            {
                sum += root;
                prod *= root;
            }
            Assert.AreEqual(sum, -10);
            Assert.AreEqual(prod, -39);

        }
        [Test]
        public void TestAIsNull()
        {

            double a = 0;
            double b = -4;
            double c = 4;
            List<double> roots = Program.SolveQuadraticEquation(a, b, c);
            List<double> expected_roots = new List<double> { 1 };
            Assert.AreEqual(0, 0); // to check that we are ready to test

            Assert.AreEqual(roots.Count, expected_roots.Count);

            Assert.AreEqual(roots.First(), expected_roots.First());

        }

        [Test]
        public void TestAllNull()
        {

            double a = 0;
            double b = 0;
            double c = 0;
            List<double> roots = Program.SolveQuadraticEquation(a, b, c);
            List<double> expected_roots = new List<double> { };
            Assert.AreEqual(0, 0); // to check that we are ready to test

            Assert.AreEqual(roots.Count, expected_roots.Count);

        }

        [Test]
        public void TestBIsNull()
        {
            double a = 1;
            double b = 0;
            double c = -25;
            List<double> roots = Program.SolveQuadraticEquation(a, b, c);
            List<double> expected_roots = new List<double> { 5, -5 };
            Assert.AreEqual(0, 0); // to check that we are ready to test

            Assert.AreEqual(roots.Count, expected_roots.Count);
            double sum = 0;
            double prod = 1;
            foreach (var root in roots)
            {
                sum += root;
                prod *= root;
            }
            Assert.AreEqual(sum, 0);
            Assert.AreEqual(prod, -25);

        }
        [Test]
        public void TestBigNumbers()
        {

            double a = 10000000000;
            double b = -40000000000;
            double c = 40000000000;
            List<double> roots = Program.SolveQuadraticEquation(a, b, c);
            List<double> expected_roots = new List<double> { 2 };
            Assert.AreEqual(0, 0); // to check that we are ready to test

            Assert.AreEqual(roots.Count, expected_roots.Count);

            Assert.AreEqual(roots.First(), expected_roots.First());

        }
        [Test]
        public void TestWithoutAB()
        {

            double a = 0;
            double b = 0;
            double c = 777;
            List<double> roots = Program.SolveQuadraticEquation(a, b, c);
            List<double> expected_roots = new List<double> { };
            Assert.AreEqual(0, 0); // to check that we are ready to test

            Assert.AreEqual(roots.Count, expected_roots.Count);

        }

        [Test]
        public void TestTwoBadSolutions()
        {
            double a = 1;
            double b = 3;
            double c = -3;
            List<double> roots = Program.SolveQuadraticEquation(a, b, c);
            List<double> expected_roots = new List<double> { -3.7913, 0.79129 };
            Assert.AreEqual(0, 0); // to check that we are ready to test

            Assert.AreEqual(roots.Count, expected_roots.Count);
            double sum = 0;
            double prod = 1;
            foreach (var root in roots)
            {
                sum += root;
                prod *= root;
            }
            double eps = 0.01;
            Assert.AreEqual(sum, -3.7913 + 0.79129, eps);
            Assert.AreEqual(prod, -3.7913 * 0.79129, eps);

        }
    }
}