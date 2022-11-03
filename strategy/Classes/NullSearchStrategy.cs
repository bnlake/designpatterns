namespace strategy.Classes
{
    internal class NullSearchStrategy : ISearchStrategy
    {
        public Content? Execute(IList<Content> dataset, string predicate)
        {
            Console.WriteLine("No search strategy was chosen");
            return null;
        }
    }
}
