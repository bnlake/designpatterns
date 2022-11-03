namespace strategy.Classes
{
    internal class SearchController
    {
        public IList<Content> Data { get; set; }
        public ISearchStrategy Strategy { get; set; }

        public SearchController(IList<Content> data, ISearchStrategy? strategy = null)
        {
            this.Data = data;
            this.Strategy = strategy ?? new NullSearchStrategy();
        }

        public void SetStrategy(ISearchStrategy? strategy)
        {
            this.Strategy = strategy ?? new NullSearchStrategy();
        }

        public Content? Search(string predicate)
        {
            return this.Strategy.Execute(this.Data, predicate);
        }
    }
}
