namespace Shapes
{
    public interface IFlatShape
    {
        /// <summary>
        /// Returns square of shape.
        /// </summary>
        double Square { get; }

        /// <summary>
        /// Returns perimeter of shape.
        /// </summary>
        double Perimeter { get; }
    }
}