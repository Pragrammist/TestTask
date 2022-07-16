namespace Figures.Validation
{
    public class TriangleValidation : BaseValidation
    {
        double _a;
        double _b;
        double _c;
        public TriangleValidation(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public override void FigureExistsValidation()
        {
            var isValid = FigureIsExists(_a, _b, _c);

            if(!isValid)
               base.FigureExistsValidation();
        }
        private bool FigureIsExists(double a, double b, double c)
        {
            var sides = new double[] { a, b, c };
            var biggestValue = sides.Max();
            var sumLessValues = SumLessValues(biggestValue, sides);
            var isExists = sumLessValues > biggestValue;
            return isExists;
        }
        private double SumLessValues(double biggestValue, double[] sides)
        {
            int biggestIndex = 0;
            for (int i = 0; i < sides.Length; i++)
            {
                if (sides[i] == biggestValue)
                {
                    biggestIndex = i;
                }
            }

            var lessElements = sides.Where((s, i) => i != biggestIndex);
            return lessElements.Sum();
        }
    }
}
