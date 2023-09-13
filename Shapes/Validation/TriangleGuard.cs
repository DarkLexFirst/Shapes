namespace Shapes.Validation
{
    internal sealed class TriangleGuard
    {
        public static void IsTriangle(double a, double b, double c)
        {
            if (a >= b + c
                || b >= a + c
                || c >= a + b)
            {
                throw new ArgumentException($"The triangle with sides [a = {a}, b = {b}, c = {c}] can't exist");
            }
        }
    }
}
