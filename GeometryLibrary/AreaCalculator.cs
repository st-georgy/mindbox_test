namespace GeometryLibrary
{
    public static class AreaCalculator
    {
        public static double CalculateArea<T>(T figure) where T : FigureBase
        {
            return figure.CalculateArea();
        }
    }
}