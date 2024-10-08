namespace MazeSolver.Domain.Entities.Maze.ValueObjects.Builders.Abstractions;

using System.Numerics;

public interface IMatrixGenerator<TNumeric>
    where TNumeric : INumber<TNumeric>
{
    Matrix<TNumeric> Generate(int height, int width);
}