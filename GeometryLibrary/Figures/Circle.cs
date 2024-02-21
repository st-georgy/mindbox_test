namespace GeometryLibrary.Figures
{
    public class Circle : FigureBase
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (!IsValid())
                throw new ArgumentException("Impossible to create circle. Radius must be greater than zero.");

            Radius = radius;
        }

        public override double CalculateArea()
            => Math.Round(Math.PI * Radius * Radius, 2);

        public override bool IsValid()
            => Radius > 0;
    }
}