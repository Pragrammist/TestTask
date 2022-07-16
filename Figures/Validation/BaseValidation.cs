using Figures.Exceptions;
using System.Linq;


namespace Figures.Validation
{
    public class BaseValidation
    {
        
        protected BaseValidation()
        {

        }

        public void ZeroValuesValidation(params double[] _values)
        {
            if (_values.Any(v => v <= 0))
                throw new ZeroValueException();
        }
        public void AngleValueValidation(params double[] _angles)
        {
            if (_angles.Any(a => a >= 180))
                throw new AngleMaxValueException();
        }
        public virtual void FigureExistsValidation()
        {
            throw new FigureNotExistsException();
        }
    }
}
