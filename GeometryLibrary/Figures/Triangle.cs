namespace GeometryLibrary.Figures
{
    public class Triangle : FigureBase
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsValid())
                throw new ArgumentException("Impossible to create triangle. Triangle sides do not form a valid triangle.");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CalculateArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(semiPerimeter
                * (semiPerimeter - SideA)
                * (semiPerimeter - SideB)
                * (semiPerimeter - SideC));
        }

        public override bool IsValid()
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0) return false;

            if (SideA >= SideB + SideC
                || SideB >= SideA + SideC
                || SideC >= SideA + SideB)
                return false;

            return true;
        }

        public bool IsRightAngled()
        {
            double[] sides = [SideA, SideB, SideC];
            Array.Sort(sides);

            return sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1];
        }
    }
}