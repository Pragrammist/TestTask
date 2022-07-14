using System.Linq;
using Figures.Exceptions;
namespace Figures
{
    public class Triangle : Figure, IRectangular
    {
        readonly double _a;
        readonly double _b;
        readonly double _c;
        public Triangle(double a, double b, double c)
        {
            CheckZero(a, b , c);
            FigureIsExists(a, b, c);
            _a = a;
            _b = b;
            _c = c;
            


        }
        public override double Square()
        {
            double square;
            var p = (_a + _b + _c) / 2;
            square = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c)); // formula

            return square;
        }
        public virtual bool IsRectangular()
        {
            var sqrA = Math.Pow(_a, 2);
            var sqrB = Math.Pow(_b, 2);
            var sqrC = Math.Pow(_c, 2);
            return sqrC == sqrA + sqrB;
        }
        private void CheckZero(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ZeroValueException();
        }
        private void FigureIsExists(double a, double b, double c)
        {
            var sides = new double[] { a, b, c };
            var biggestValue = sides.Max();
            var sumLessValues = SumLessValues(biggestValue, sides);
            var isExists = sumLessValues > biggestValue ;
            if (!isExists)
                throw new FigureNotExistsException();
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