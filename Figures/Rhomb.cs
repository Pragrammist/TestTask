using Figures.Validation;

namespace Figures
{
    public class Rhomb : Figure
    {
        readonly RhombValidation _validator;
        readonly double _side;
        readonly double _angle1;
        readonly double _angle2;
        public Rhomb(double side, double angle1, double angle2)
        {
            _validator = GetValidator(angle1, angle2);
            Validate(side, angle1, angle2);


            _side = side;
            _angle1 = angle1;
            _angle2 = angle2;
        }
        protected void Validate(double side, double angle1, double angle2)
        {
            _validator.ZeroValuesValidation(side, angle1, angle2);
            _validator.AngleValueValidation(angle1, angle2);
            _validator.FigureExistsValidation();
        }

        public RhombValidation GetValidator(double angle1, double angle2) => new RhombValidation(angle1, angle2);
        public override double Square() => Math.Pow(_side, 2) * Math.Sin(_angle1); // side^2 * sing(angle)
        
    }
}
