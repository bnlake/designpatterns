using chainofresponsibility.Models;

namespace chainofresponsibility.Handlers
{
    internal class SQLDBHandler : BaseHandler
    {
        private IDictionary<int, IEnumerable<Content>> dataset;
        private readonly Content sample1 = new Content() { Title = "Acute Bronchitis", Blurb = "An overview of acute bronchitis" };
        private readonly Content sample2 = new Content() { Title = "Fever", Blurb = "Home treatment for fever symptoms" };
        private readonly Content sample3 = new Content() { Title = "Stress", Blurb = "Coping with stress in a ruthless work environment" };

        public SQLDBHandler(IHandler? next = null) : base(next)
        {
            // Imitate the existance of a SQL DB
            this.dataset = new Dictionary<int, IEnumerable<Content>>();

            // Add favorites for a few "users". The integer represents the users unique identifier
            this.dataset.Add(0, new List<Content> { sample1 });
            this.dataset.Add(1, new List<Content> { sample3, sample2 });
            this.dataset.Add(2, new List<Content> { sample3 });
        }

        public override async Task<IEnumerable<Content>?> HandleAsync(int identifier)
        {
            await Task.Delay(1200); // Simulate slow DB request

            IEnumerable<Content>? result;
            dataset.TryGetValue(identifier, out result);

            // Return the result on a match
            if (result is not null) return result;

            // Return null if there are no more handlers in the chain
            if (next is null) return null;

            // Send the request to the next handler
            return await next.HandleAsync(identifier);
        }
    }
}
