using command.Interfaces;
using command.Models;

namespace command.Persistance
{
    /// <summary>
    /// This class simulates an in-memory database.
    /// This lesson is not about the repository pattern, therefore
    /// we are implementing a very rudimentary repository
    /// </summary>
    internal class ContentRepository : IContentRepository
    {
        private readonly IList<Content> contents = new List<Content>();

        public ContentRepository()
        {
            contents.Add(new Content { Id = 1, Name = "Sore throat treatment", Body = "Here's a piece of content to help with sore throat" });
            contents.Add(new Content { Id = 2, Name = "Migraine treatment", Body = "Content that teaches you how to treat migraines" });
            contents.Add(new Content { Id = 3, Name = "Treating sleep apnea", Body = "Can't sleep? Try reading a book. That usually knocks me out" });
        }
        public void Create(Content content)
        {
            if (content is null) return;
            contents.Add(content);
        }

        public Content? GetContent(int id)
        {
            return contents.FirstOrDefault(c => c.Id.Equals(id));
        }

        public void Delete(Content content)
        {
            contents.Remove(content);
        }
    }
}
