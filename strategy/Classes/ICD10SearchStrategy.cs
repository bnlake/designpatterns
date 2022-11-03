namespace strategy.Classes
{
    internal class ICD10SearchStrategy : ISearchStrategy
    {
        public Content? Execute(IList<Content> dataset, string predicate)
        {
            Console.WriteLine("Searching by ICD10");
            return dataset.FirstOrDefault(x => x.ICD10.Contains(predicate));
        }
    }
}
