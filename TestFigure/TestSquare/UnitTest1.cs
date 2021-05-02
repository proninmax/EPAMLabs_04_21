using NUnit.Framework;

namespace TestSquare
{
    public class TestSquare
    {

        [Test, TestCaseSource("squareDate")]
        public void TestArea(double x)
        {
            var area = GeometricFigures.Square.GetArea(x);
            Assert.IsTrue(x*x == area, $"����������{x*x}, ������ {area}");
        }

        [Test, TestCaseSource("squareDate")]
        public void TestLength(double x)
        {
            var length = GeometricFigures.Square.GetLength(x);
            Assert.IsTrue(x*4 == length, $"���������� {x*4}, ������ {length}");
        }

        static object[] squareDate =
        {

            new object[] {6},
            new object[] {18},
            new object[] {19},
            new object[] {3},
            new object[] {4}
        };

    }
}