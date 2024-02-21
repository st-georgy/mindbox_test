namespace GeometryLibrary
{
    /// <summary>
    /// Base class for geometric figures.
    /// </summary>
    public abstract class FigureBase
    {
        /// <summary>
        /// Calculates area of the figure.
        /// </summary>
        /// <returns>Area of the figure.</returns>
        public abstract double CalculateArea();

        /// <summary>
        /// Checks whether the figure is valid.
        /// </summary>
        /// <returns>True if figure is valid.</returns>
        public abstract bool IsValid();
    }
}
