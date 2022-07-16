using Figures.Validation;
using Figures.Exceptions;
namespace Figures
{
    public class Triangle : Figure, IRectangular
    {
        readonly TriangleValidation _validator;
        readonly double _a;
        readonly double _b;
        readonly double _c;
        public Triangle(double a, double b, double c)
        {
            _validator = GetValidator(a, b, c);
            Validate(a, b, c);
            _a = a;
            _b = b;
            _c = c;
        }
        protected TriangleValidation GetValidator(double a, double b, double c) => new TriangleValidation(a, b, c);
        protected void Validate(double a, double b, double c)
        {
            _validator.ZeroValuesValidation(a, b, c);
            _validator.FigureExistsValidation();
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
    }
}