using chainofresponsibility.Models;

namespace chainofresponsibility.Handlers
{
    internal class NullHandler : BaseHandler
    {
        public NullHandler(IHandler? next) : base(next) { }

        public override async Task<IEnumerable<Content>?> HandleAsync(int identifier)
        {
            return await Task.Run(() => new List<Content>());
        }
    }
}
