namespace MazeSolver.Domain.Entities.Maze.ValueObjects;

using System.Numerics;

public record struct Matrix<TNumeric>(TNumeric[,] MatrixData)
    where TNumeric : INumber<TNumeric>
{
    public long Height { get; } = MatrixData.GetLength(0);

    public long Weight { get; } = MatrixData.GetLength(1);


    public readonly TNumeric this[int row, int col]
    {
        get => MatrixData[row, col];
        set => MatrixData[row, col] = value!;
    }

    public static implicit operator TNumeric[,](Matrix<TNumeric> matrix)
        => matrix.MatrixData;

    public static implicit operator Matrix<TNumeric>(TNumeric[,] matrixData)
        => new(matrixData);
}