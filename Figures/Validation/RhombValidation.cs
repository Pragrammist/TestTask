namespace Figures.Validation
{
    public class RhombValidation : BaseValidation
    {
        double _angle1; 
        double _angle2;

        public RhombValidation(double angle1, double angle2)
        {
            _angle1 = angle1;
            _angle2 = angle2;
        }

        public override void FigureExistsValidation()
        {
            var isValid = IsExists(_angle1, _angle2);

            if(!isValid)
               base.FigureExistsValidation();
        }

        protected bool IsExists(double angle1, double angle2)
        {
            var res = Math.Round(angle1,1) + Math.Round(angle2, 1) == 180; 
            // above uses angle1 + angle1 = 180 theorem for rombs. 

            // round to program can correctly equals two values 

            // it need to move round in classes, create for them other arhitecture branch if it will be in use in future
            

            return res;
        }
    }
}
