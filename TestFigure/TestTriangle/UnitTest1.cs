using NUnit.Framework;
using System;

namespace TestTriangle
{
    public class TestTriangle
    {

        [Test, TestCaseSource("triangleDate")]
        public void TestArea(double x, double y, double z)
        {
            var area = GeometricFigures.Triangle.GetArea(x, y, z);
            var trueArea = Math.Sqrt((x + y + z)/2 * ((x + y + z)/2 - x) * ((x + y + z)/2 - y) * ((x + y + z)/2 - z));
            Assert.IsTrue(trueArea == area, $"Ёквивалент{trueArea}, пришло {area}");
        }

        [Test, TestCaseSource("triangleDate")]
        public void TestLength(double x, double y, double z)
        {
            var length = GeometricFigures.Triangle.GetLength(x, y, z);
            Assert.IsTrue((x + y + z)/2 == length, $"Ёквивалент {(x + y + z)/2}, пришло {length}");
        }

        static object[] triangleDate =
        {

            new object[] {5,5, 4},
            new object[] {16, 16, 3},
            new object[] {17,17, 4},
            new object[] {5,7, 20},
            new object[] {7,2, 15}
        };

    }
}