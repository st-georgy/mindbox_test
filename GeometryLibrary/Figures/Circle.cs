namespace GeometryLibrary.Figures
{
    /// <summary>
    /// Represents a circle (geometric figure)
    /// </summary>
    public class Circle : FigureBase
    {
        /// <summary>
        /// Radius of the circle
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class with the specified radius.
        /// </summary>
        /// <param name="radius">Radius of the circle.</param>
        /// <exception cref="ArgumentException">Thrown when the radius is not greater than zero.</exception>
        public Circle(double radius)
        {
            Radius = radius;

            if (!IsValid())
                throw new ArgumentException("Impossible to create circle. Radius must be greater than zero.");
        }

        /// <inheritdoc/>
        public override double CalculateArea()
            => Math.Round(Math.PI * Radius * Radius, 2);

        /// <inheritdoc/>
        public override bool IsValid()
            => Radius > 0;
    }
}