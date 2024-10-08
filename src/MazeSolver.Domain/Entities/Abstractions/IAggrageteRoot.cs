namespace MazeSolver.Domain.Entities.Abstractions;

public interface IAggregateRoot<TKey> : IEntity<TKey>
     where TKey : IEquatable<TKey>
{ }