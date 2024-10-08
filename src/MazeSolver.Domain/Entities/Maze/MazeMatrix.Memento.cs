namespace MazeSolver.Domain.Entities.Maze;

using Abstractions;
using ValueObjects;
using System.Collections.Concurrent;
using static MazeMatrix;
using static Abstractions.IMemento;

public sealed partial class MazeMatrix : IOriginator<MazeMatrixMemento>
{
    public sealed record MazeMatrixMemento(Matrix<int> MatrixData) : IMemento;

    private sealed record MazeMatrixMementoCaretaker : ICaretaker<MazeMatrixMemento>
    {
        private readonly ConcurrentStack<MazeMatrixMemento> _history = [];

        public void SaveState(IOriginator<MazeMatrixMemento> originator)
            => _history.Push(originator.CreateMemento());

        public bool Undo(IOriginator<MazeMatrixMemento> originator)
        {
            if (_history.TryPop(out var memento))
            {
                originator.RestoreState(memento);

                return true;
            }

            return false;
        }
    }

    public MazeMatrixMemento CreateMemento()
        => new(MatrixData);

    public void RestoreState(MazeMatrixMemento memento)
        => SetMatrixData(memento.MatrixData);
}