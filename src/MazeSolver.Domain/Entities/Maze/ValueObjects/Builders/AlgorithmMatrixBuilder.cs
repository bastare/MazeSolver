namespace MazeSolver.Domain.Entities.Maze.ValueObjects.Builders;

using System.Numerics;
using Rules;
using Abstractions;

public sealed class AlgorithmMatrixBuilder<TNumeric>
    where TNumeric : INumber<TNumeric>
{
    private TNumeric[,]? _matrixData;

    private int _height = MatrixRules.MinHeight;

    private int _width = MatrixRules.MinWidth;

    public AlgorithmMatrixBuilder<TNumeric> SetSize(int height, int width)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(height, MatrixRules.MinHeight);
        ArgumentOutOfRangeException.ThrowIfLessThan(width, MatrixRules.MinWidth);

        _height = height;
        _width = width;

        return this;
    }

    public AlgorithmMatrixBuilder<TNumeric> GenerateMatrixData(IMatrixGenerator<TNumeric> generator)
    {
        _matrixData = generator.Generate(_height, _width);

        return this;
    }

    public Matrix<TNumeric> Build()
        => _matrixData is not null
            ? new(_matrixData)
            : new();
}