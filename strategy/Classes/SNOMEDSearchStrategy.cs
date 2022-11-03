namespace strategy.Classes
{
    internal class SNOMEDSearchStrategy : ISearchStrategy
    {
        public Content? Execute(IList<Content> dataset, string predicate)
        {
            Console.WriteLine("Searching by SNOMED");
            return dataset.FirstOrDefault(x => x.SNOMED.Contains(predicate));
        }
    }
}
