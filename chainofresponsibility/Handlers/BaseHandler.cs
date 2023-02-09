using chainofresponsibility.Models;

namespace chainofresponsibility.Handlers
{
    internal abstract class BaseHandler : IHandler
    {
        protected IHandler? next;

        public BaseHandler(IHandler? next)
        {
            this.next = next;
        }

        public abstract Task<IEnumerable<Content>?> HandleAsync(int identifier);

        public void SetNext(IHandler h)
        {
            this.next = h;
        }
    }
}
