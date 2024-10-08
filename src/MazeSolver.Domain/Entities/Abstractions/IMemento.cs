namespace MazeSolver.Domain.Entities.Abstractions;

public interface IMemento
{
    public interface IOriginator<TMemento>
        where TMemento : IMemento
    {
        TMemento CreateMemento();

        void RestoreState(TMemento memento);
    }

    public interface ICaretaker<TMemento>
        where TMemento : IMemento
    {
        void SaveState(IOriginator<TMemento> originator);

        bool Undo(IOriginator<TMemento> originator);
    }
}
