using Figures.Exceptions;
using Figures.Validation;

namespace Figures
{
    public class Circle : Figure
    {
        readonly CircleValidation _circleValidation;


        readonly double _radius;

        public Circle(double radius)
        {
            _circleValidation = GetValidator();
            CheckZero(radius);
            _radius = radius;
            
        }
        public override double Square()
        => 2 * Math.PI * Math.Pow(_radius, 2); // 2pr^2

        private void CheckZero(double radius)
        {
            _circleValidation.ZeroValuesValidation(radius);
        }
        private CircleValidation GetValidator() => new CircleValidation();

    }

}