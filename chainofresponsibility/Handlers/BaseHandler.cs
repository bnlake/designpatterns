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

        public abstract IEnumerable<Content> Handle(int identifier);

        public void SetNext(IHandler h)
        {
            this.next = h;
        }
    }
}
