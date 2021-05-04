using NUnit.Framework;

namespace TestRectangle
{
    public class TestRectangle
    {

        [Test, TestCaseSource("rectangleDate")]
        public void TestArea(double x, double y)
        {
            var area = GeometricFigures.Rectangle.GetArea(x, y);
            Assert.IsTrue(x*y == area, $"Ёквивалент{x*y}, пришло {area}");
        }

        [Test, TestCaseSource("rectangleDate")]
        public void TestLength(double x, double y)
        {
            var length = GeometricFigures.Rectangle.GetLength(x, y);
            Assert.IsTrue((x+y)*2 == length, $"Ёквивалент {(x + y) * 2 }, пришло {length}");
        }

        static object[] rectangleDate =
        {

            new object[] {15,15},
            new object[] {16, 16},
            new object[] {17,17},
            new object[] {5,7},
            new object[] {7,2}
        };

    }
}