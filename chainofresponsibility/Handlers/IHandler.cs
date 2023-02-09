using chainofresponsibility.Models;

namespace chainofresponsibility.Handlers
{
    internal interface IHandler
    {
        void SetNext(IHandler h);
        Task<IEnumerable<Content>?> HandleAsync(int identifier);
    }
}
