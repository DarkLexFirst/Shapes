namespace Shapes.Tests
{
    [TestClass]
    public sealed class TriangleTests
    {
        [DataTestMethod]
        [DataRow(0, 0, 0)]
        [DataRow(1, 1, 0)] 
        [DataRow(1, 0, 1)] 
        [DataRow(0, 1, 1)]
        [DataRow(1, -1, 0)]
        [DataRow(0, 0, 1)]
        [DataRow(0, -1, 0)]
        [DataRow(-1, 123, 123)] 
        [DataRow(0, -123, 123)]
        [DataRow(double.MinValue, 123, 123)]
        public void WrongInput(double a, double b, double c)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(a, b, c),
                $"Expected exception does no thrown with args [a = {a}, b = {b}, c = {c}]");
        }

        [DataTestMethod]
        [DataRow(10, 4, 5)]
        [DataRow(1, 1, 5)]
        [DataRow(5, 25, 8)]
        public void DoesNotTriangleInput(double a, double b, double c)
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(a, b, c),
                $"[a = {a}, b = {b}, c = {c}] is a triangle, but should not");
        }

        [DataTestMethod]
        [DataRow(1, 1, 1, false)]
        [DataRow(4, 4, 1, false)]
        [DataRow(4 / 7d, 1, 4 / 7d, false)]
        [DataRow(4, 3, 6, false)]
        [DataRow(3, 5, 4, true)]
        [DataRow(3, 4, 5, true)]
        [DataRow(5, 3, 4, true)]
        [DataRow(13, 5, 12, true)]
        [DataRow(41, 40, 9, true)]
        public void CheckIsRightState(double a, double b, double c, bool expectedIsRight)
        {
            Assert.AreEqual(expectedIsRight, new Triangle(a, b, c).IsRight, 
                $"[a = {a}, b = {b}, c = {c}] {nameof(Triangle.IsRight)} does not equals [{expectedIsRight}]");
        }

        [DataTestMethod]
        [DataRow(5, 12, 8, false)]
        [DataRow(3, 3, 5, false)]
        [DataRow(double.MaxValue, double.MaxValue / 2, double.MaxValue, false)]
        [DataRow(1, 1, 1, true)]
        [DataRow(8, 8, 8, true)]
        [DataRow(8 / 7d, 8 / 7d, 8 / 7d, true)]
        [DataRow(1 / 7d, 1 / 7d, 1 / 7d, true)]
        [DataRow(double.MaxValue, double.MaxValue, double.MaxValue, true)]
        public void CheckIsEquilateralState(double a, double b, double c, bool expectedIsEquilateral)
        {
            Assert.AreEqual(expectedIsEquilateral, new Triangle(a, b, c).IsEquilateral, 
                $"[a = {a}, b = {b}, c = {c}] {nameof(Triangle.IsEquilateral)} does not equals [{expectedIsEquilateral}]");
        }

        [DataTestMethod]
        [DataRow(6, 5, 7, false)]
        [DataRow(4, 3, 5, false)]
        [DataRow(double.MaxValue, double.MaxValue / 2, double.MaxValue, true)]
        [DataRow(1, 1, 1, true)]
        [DataRow(1 / 23d, 2 / 23d, 2 / 23d, true)]
        [DataRow(2, 2, 3, true)]
        [DataRow(8, 8, 8, true)]
        [DataRow(8 / 7d, 8 / 7d, 8 / 7d, true)]
        [DataRow(8, 5, 8, true)]
        [DataRow(double.MaxValue, double.MaxValue, double.MaxValue, true)]
        [DataRow(double.MaxValue / 7, double.MaxValue / 7, double.MaxValue / 7, true)]
        public void CheckIsIsoscelesState(double a, double b, double c, bool expectedIsIsosceles)
        {
            Assert.AreEqual(expectedIsIsosceles, new Triangle(a, b, c).IsIsosceles, 
                $"[a = {a}, b = {b}, c = {c}] {nameof(Triangle.IsIsosceles)} does not equals [{expectedIsIsosceles}]");
        }

        [DataTestMethod]
        [DataRow(1, 1, 1, 3)]
        [DataRow(53, 27, 34, 114)]
        [DataRow(40 / 3d, 40 / 3d, 40 / 3d, 40)]
        public void CheckPerimeter(double a, double b, double c, double expectedPerimeter)
        {
            Assert.AreEqual(expectedPerimeter, new Triangle(a, b, c).Perimeter, 
                $"[a = {a}, b = {b}, c = {c}] {nameof(Triangle.Perimeter)} does not equals [{expectedPerimeter}]");
        }

        [DataTestMethod]
        [DataRow(5, 3, 4, 6)]
        [DataRow(17, 10, 9, 36)]
        [DataRow(29, 6, 25, 60)]
        [DataRow(53, 51, 4, 90)]
        public void CheckSquare(double a, double b, double c, double expectedSquare)
        {
            Assert.AreEqual(expectedSquare, new Triangle(a, b, c).Square,
                $"[a = {a}, b = {b}, c = {c}] {nameof(Triangle.Square)} does not equals [{expectedSquare}]");
        }
    }
}