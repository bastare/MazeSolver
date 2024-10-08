namespace MazeSolver.Domain.Entities.Maze.ValueObjects.Builders.Strategies;

using System.Numerics;
using Abstractions;

public sealed class DfsGenerator<TNumeric> : IMatrixGenerator<TNumeric>
    where TNumeric : INumber<TNumeric>
{
    public Matrix<TNumeric> Generate(int height, int width)
    {
        var filledMatrix_ = CreateAndFillMatrixBy(TNumeric.One);

        return filledMatrix_;

        Matrix<TNumeric> CreateAndFillMatrixBy(TNumeric placeholder)
        {
            var createdMatrix_ = new TNumeric[height, width];

            for (var colIndex_ = 0; colIndex_ < height; colIndex_++)
                for (var rowIndex_ = 0; rowIndex_ < width; rowIndex_++)
                    createdMatrix_[colIndex_, rowIndex_] = placeholder;

            return createdMatrix_;
        }
    }
}