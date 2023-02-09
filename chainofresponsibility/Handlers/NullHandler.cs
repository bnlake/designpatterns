using chainofresponsibility.Models;

namespace chainofresponsibility.Handlers
{
    internal class NullHandler : BaseHandler
    {
        public NullHandler(IHandler? next) : base(next) { }

        public override IEnumerable<Content> Handle(int identifier)
        {
            return new List<Content>();
        }
    }
}
