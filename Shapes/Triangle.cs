using Shapes.Validation;

namespace Shapes
{
    public sealed class Triangle : IFlatShape
    {
        private readonly Lazy<double> _square;
        private readonly Lazy<double> _perimeter;
        private readonly Lazy<bool> _isRight;
        private readonly Lazy<bool> _isIsosceles;
        private readonly Lazy<bool> _isEquilateral;

        /// <summary>
        /// Initializes a new instence of the <see cref='Triangle'/> on the sides.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException" />
        /// <exception cref="ArgumentException" />
        public Triangle(double a, double b, double c)
        {
            Guard.MoreThenZero(a, nameof(a));
            Guard.MoreThenZero(b, nameof(b));
            Guard.MoreThenZero(c, nameof(c));
            TriangleGuard.IsTriangle(a, b, c);

            A = a;
            B = b;
            C = c;

            _square = new Lazy<double>(GetSquare);
            _perimeter = new Lazy<double>(GetPerimeter);
            _isRight = new Lazy<bool>(CheckIsRight);
            _isIsosceles = new Lazy<bool>(CheckIsIsosceles);
            _isEquilateral = new Lazy<bool>(CheckIsEquilateral);
        }

        /// <summary>
        /// Side of the triangle.
        /// </summary>
        public double A { get; }

        /// <summary>
        /// Side of the triangle.
        /// </summary>
        public double B { get; }

        /// <summary>
        /// Side of the triangle.
        /// </summary>
        public double C { get; }

        public double Square => _square.Value;

        public double Perimeter => _perimeter.Value;

        /// <summary>
        /// Returns <c>true</c> if the triangle is right, otherwise <c>false</c>.
        /// </summary>
        public bool IsRight => _isRight.Value;

        /// <summary>
        /// Returns <c>true</c> if the triangle is isosceles, otherwise <c>false</c>.
        /// </summary>
        public bool IsIsosceles => _isIsosceles.Value;

        /// <summary>
        /// Returns <c>true</c> if the triangle is equilateral, otherwise <c>false</c>.
        /// </summary>
        public bool IsEquilateral => _isEquilateral.Value;

        private double GetSquare()
        {
            var p = Perimeter / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        private double GetPerimeter()
        {
            return A + B + C;
        }

        private bool CheckIsRight()
        {
            double hypotenuse;
            double cathet1;
            double cathet2;

            if (A > B && A > C)
            {
                hypotenuse = A;
                cathet1 = B;
                cathet2 = C;
            }
            else if (B > A && B > C)
            {
                hypotenuse = B;
                cathet1 = A;
                cathet2 = C;
            }
            else if (C > A && C > B)
            {
                hypotenuse = C;
                cathet1 = A;
                cathet2 = B;
            }
            else
            {
                return false;
            }

            return cathet1 * cathet1 + cathet2 * cathet2 == hypotenuse * hypotenuse;
        }

        private bool CheckIsIsosceles()
        {
            return A == B || A == C || B == C;
        }

        private bool CheckIsEquilateral()
        {
            return A == B && A == C;
        }
    }
}
