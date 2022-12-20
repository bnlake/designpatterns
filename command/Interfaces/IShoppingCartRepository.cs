using command.Models;

namespace command.Interfaces
{
    internal interface IShoppingCartRepository
    {
        void AddContent(Content content);
        void RemoveContent(Content content);
    }
}
