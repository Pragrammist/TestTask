using Figures.Exceptions;

namespace Figures
{
    public class Circle : Figure
    {
        readonly double _radius;

        public Circle(double radius)
        {
            CheckZero(radius);
            _radius = radius;
        }
        public override double Square()
        => 2 * Math.PI * Math.Pow(_radius, 2); // 2pr^2

        private void CheckZero(double radius)
        {
            if (radius <= 0) throw new ZeroValueException();
        }

    }

}