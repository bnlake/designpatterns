using command.Interfaces;

namespace command.Commands
{
    internal class AddToCartCommand : ICommand
    {
        /**
         * Commands should be aware of any data it requires in order
         * to execute, verify, or undo its capabilities at any point in time.
         * Using dependency injection via constructor ensures the command
         * has what it needs without dependencies at runtime
         */
        private readonly Content Content;
        private readonly IShoppingCartRepository ShoppingCartRepository;
        private readonly IContentRepository ContentRepository;

        public AddToCartCommand(IShoppingCartRepository shoppingCartRepository, IContentRepository contentRepository, Content content)
        {
            Content = content;
            ShoppingCartRepository = shoppingCartRepository;
            ContentRepository = contentRepository;
        }
        public bool CanExecute()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
