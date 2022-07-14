namespace Figures.Exceptions
{
    public class FigureNotExistsException : Exception
    {
        public FigureNotExistsException() : base("Figure does not exists") { }
    }
}
