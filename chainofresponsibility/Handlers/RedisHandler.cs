using chainofresponsibility.Models;

namespace chainofresponsibility.Handlers
{
    internal class RedisHandler : BaseHandler
    {
        private IDictionary<int, IEnumerable<Content>> dataset;

        public RedisHandler(IHandler? next = null) : base(next)
        {
            // Imitate the existance of a Redis cache
            // A cache likely is empty on initialization
            this.dataset = new Dictionary<int, IEnumerable<Content>>();
        }

        public override async Task<IEnumerable<Content>?> HandleAsync(int identifier)
        {
            // WARNING!! THIS IS NOT A PRODUCTION READY EXAMPLE. 
            // THIS WILL NOT HANDLE REFRESHING THE CACHE ON SUBSEQUENT MATCHES

            await Task.Delay(200); // Simulate faster cache access

            IEnumerable<Content>? result;
            dataset.TryGetValue(identifier, out result);

            // Return the result on a match
            if (result is not null) return result;

            // Return null if there are no more handlers in the chain
            if (next is null) return null;

            // Send the request to the next handler
            result = await next.HandleAsync(identifier);

            // Add other handlers results to the cache
            if (result != null)
            {
                dataset.Add(identifier, result);
                return result;
            }
            else return result;
        }
    }
}
