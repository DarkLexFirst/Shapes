namespace Shapes.Validation
{
    internal sealed class Guard
    {
        public static void MoreThenZero(double input, string valueName)
        {
            if (input <= 0) throw new ArgumentOutOfRangeException($"The value of [{valueName}] must be greater then Zero, but equal to [{input}]");
        }

        public static void MoreThen(double input, double moreThen, string valueName)
        {
            if (input <= moreThen) throw new ArgumentOutOfRangeException($"The value of [{valueName}] must be greater then [{moreThen}], but equal to [{input}]");
        }
    }
}
