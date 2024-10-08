namespace MazeSolver.Domain.Entities.Maze;

using System.Collections.Concurrent;
using System.Collections.Generic;
using Abstractions;
using ValueObjects;

public sealed partial class MazeMatrix : IAggregateRoot<long>
{
    private readonly MazeMatrixMementoCaretaker _mazeMatrixMementoCaretaker = new();

    private readonly ConcurrentStack<object> _events = [];

    public MazeMatrix()
    {
        _mazeMatrixMementoCaretaker.SaveState(this);
    }

    public IReadOnlyList<object> Events => [.. _events];

    public long Height => MatrixData.Height;

    public long Width => MatrixData.Weight;

    public Matrix<int> MatrixData { get; private set; }

    public long Id { get; init; }

    object IEntity.Id => Id;

    public void SetMatrixData(Matrix<int> matrixData)
    {
        MatrixData = matrixData;

        _mazeMatrixMementoCaretaker.SaveState(this);
    }
}