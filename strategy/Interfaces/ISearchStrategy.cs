namespace strategy.Classes
{
    internal interface ISearchStrategy
    {
        Content? Execute(IList<Content> dataset, string predicate);
    }
}
