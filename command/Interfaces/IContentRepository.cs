using command.Models;

namespace command.Interfaces
{
    internal interface IContentRepository
    {
        void Create(Content content);
        void Delete(Content content);
    }
}
