namespace Shapes.Tests
{
    [TestClass]
    public sealed class CircleTests
    {
        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        [DataRow(double.MinValue)]
        public void WrongInput(double radius)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(radius), 
                $"Expected exception does no thrown with args [radius = {radius}]");
        }

        [DataTestMethod]
        [DataRow(1, 2 * Math.PI)]
        [DataRow(5, 5 * 2 * Math.PI)]
        [DataRow(71, 71 * 2 * Math.PI)]
        [DataRow(8 / 7d, 8 / 7d * 2 * Math.PI)]
        [DataRow(1 / 7d, 1 / 7d * 2 * Math.PI)]
        public void CheckPerimeter(double radius, double expectedPerimeter)
        {
            Assert.AreEqual(expectedPerimeter, new Circle(radius).Perimeter,
                $"[radius = {radius}] {nameof(Triangle.Perimeter)} does not equals [{expectedPerimeter}]");
        }

        [DataTestMethod]
        [DataRow(1, Math.PI)]
        [DataRow(5, 5 * 5 * Math.PI)]
        [DataRow(71, 71 * 71 * Math.PI)]
        [DataRow(8 / 7d, 8 / 7d * 8 / 7d * Math.PI)]
        [DataRow(1 / 7d, 1 / 7d * 1 / 7d * Math.PI)]
        public void CheckSquare(double radius, double expectedSquare)
        {
            Assert.AreEqual(expectedSquare, new Circle(radius).Square,
                $"[radius = {radius}] {nameof(Triangle.Square)} does not equals [{expectedSquare}]");
        }
    }
}
