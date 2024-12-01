namespace Demo.Application.Common.Exceptions;

public class ValidationException : BaseException
{
    public ValidationException(IDictionary<string,string[]> failuers) : base("One or more validation failures have occurred.",failuers)
    {
        
    }
}