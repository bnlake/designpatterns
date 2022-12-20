namespace command.Interfaces
{
    internal interface ICommand
    {
        void Execute();
        bool CanExecute();
        void Undo();
    }
}
