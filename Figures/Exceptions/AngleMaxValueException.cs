namespace Figures.Exceptions
{
    public class AngleMaxValueException : Exception
    {
        public AngleMaxValueException() : base("Figure cannot have angle value bigger than 180")
        {

        }
    }
}
