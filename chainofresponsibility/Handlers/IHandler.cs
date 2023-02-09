using chainofresponsibility.Models;

namespace chainofresponsibility.Handlers
{
    internal interface IHandler
    {
        void SetNext(IHandler h);
        IEnumerable<Content> Handle(int identifier);
    }
}
