namespace GeometryLibrary.Figures
{
    /// <summary>
    /// Represents a triangle (geometric figure)
    /// </summary>
    public class Triangle : FigureBase
    {
        /// <summary>
        /// Length of side A of the triangle.
        /// </summary>
        public double SideA { get; }

        /// <summary>
        /// Length of side B of the triangle.
        /// </summary>
        public double SideB { get; }

        /// <summary>
        /// Length of side C of the triangle.
        /// </summary>
        public double SideC { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class with the specified side lengths.
        /// </summary>
        /// <param name="sideA">Length of side A of the triangle.</param>
        /// <param name="sideB">Length of side B of the triangle.</param>
        /// <param name="sideC">Length of side C of the triangle.</param>
        /// <exception cref="ArgumentException">Thrown when the side lengths do not form a valid triangle, or when any of sides is not greated than zero.</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsValid())
                throw new ArgumentException("Impossible to create triangle. Triangle sides do not form a valid triangle.");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <inheritdoc/>
        public override double CalculateArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(semiPerimeter
                * (semiPerimeter - SideA)
                * (semiPerimeter - SideB)
                * (semiPerimeter - SideC));
        }

        /// <inheritdoc/>
        public override bool IsValid()
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0) return false;

            if (SideA >= SideB + SideC
                || SideB >= SideA + SideC
                || SideC >= SideA + SideB)
                return false;

            return true;
        }

        /// <summary>
        /// Determines whether triangle is a right-angled triangle.
        /// </summary>
        /// <returns>True if triangle is right-angled.</returns>
        public bool IsRightAngled()
        {
            double[] sides = [SideA, SideB, SideC];
            Array.Sort(sides);

            return sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1];
        }
    }
}