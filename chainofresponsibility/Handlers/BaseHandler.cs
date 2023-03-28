using chainofresponsibility.Models;

namespace chainofresponsibility.Handlers
{
    internal abstract class BaseHandler : IHandler
    {
        protected IHandler? next;

        public BaseHandler(IHandler? next = null)
        {
            this.next = next;
        }

        public abstract Task<IEnumerable<Content>?> HandleAsync(int identifier);

        public IHandler SetNext(IHandler h)
        {
            this.next = h;
            return this;
        }
    }
}
