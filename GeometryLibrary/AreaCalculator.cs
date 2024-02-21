namespace GeometryLibrary
{
    public static class AreaCalculator
    {
        /// <summary>
        /// Calculates area of a given geometric figure.
        /// </summary>
        /// <param name="figure">Geometric figure.</param>
        /// <returns>Area of the figure.</returns>
        public static double CalculateArea<T>(T figure) where T : FigureBase
        {
            return figure.CalculateArea();
        }
    }
}