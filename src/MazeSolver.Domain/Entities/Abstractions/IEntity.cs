namespace MazeSolver.Domain.Entities.Abstractions;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public interface IEntity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    object Id { get; }
}

public interface IEntity<TKey> : IEntity
   where TKey : IEquatable<TKey>
{
    new TKey Id { get; init; }
}