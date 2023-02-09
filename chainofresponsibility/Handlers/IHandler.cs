namespace chainofresponsibility.Handlers
{
    internal interface IHandler
    {
        void SetNext(IHandler h);
    }
}
