using chainofresponsibility.Models;

namespace chainofresponsibility.Handlers
{
    internal class BaseHandler : IHandler
    {
        protected IHandler? next;

        public BaseHandler(IHandler? next)
        {
            this.next = next;
        }

        public IEnumerable<Content> Handle(int identifier)
        {
            // Imitate the Null pattern as our Base Class
            return new List<Content>();
        }

        public void SetNext(IHandler h)
        {
            this.next = h;
        }
    }
}
