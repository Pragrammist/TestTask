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
            if (_values.Any())
                throw new ZeroValueException();
        }
        public virtual void FigureExistsValidation()
        {
            throw new FigureNotExistsException();
        }
    }
}
