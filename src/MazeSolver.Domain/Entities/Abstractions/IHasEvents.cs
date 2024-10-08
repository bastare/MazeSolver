namespace MazeSolver.Domain.Entities.Abstractions;

public interface IHasEvents<out TEvent>
{
    public IReadOnlyList<TEvent> Events { get; }
}