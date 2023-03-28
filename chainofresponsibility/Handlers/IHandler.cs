using chainofresponsibility.Models;

namespace chainofresponsibility.Handlers
{
    internal interface IHandler
    {
        IHandler SetNext(IHandler h);
        Task<IEnumerable<Content>?> HandleAsync(int identifier);
    }
}
