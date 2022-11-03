namespace strategy.Classes
{
    internal class TitleSearchStrategy : ISearchStrategy
    {
        public Content? Execute(IList<Content> dataset, string predicate)
        {
            Console.WriteLine("Searching by Content Title");
            return dataset.FirstOrDefault(x => x.Title.Contains(predicate));
        }
    }
}
