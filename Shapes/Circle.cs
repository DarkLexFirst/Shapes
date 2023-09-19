using Shapes.Validation;

namespace Shapes
{
    public sealed class Circle : IFlatShape
    {
        private readonly Lazy<double> _square;
        private readonly Lazy<double> _perimeter;

        /// <exception cref="ArgumentOutOfRangeException" />
        public Circle(double radius)
        {
            Guard.MoreThenZero(radius, nameof(radius));

            Radius = radius;

            _square = new Lazy<double>(GetSquare);
            _perimeter = new Lazy<double>(GetPerimeter);
        }

        /// <summary>
        /// Radius of the circle.
        /// </summary>
        public double Radius { get; }

        public double Square => _square.Value;

        public double Perimeter => _perimeter.Value;

        private double GetSquare()
        {
            return Radius * Radius * Math.PI;
        }

        private double GetPerimeter()
        {
            return 2 * Radius * Math.PI;
        }
    }
}
