namespace UnitTests.Domain.Entities.ValueObjects;

using MazeSolver.Domain.Entities.Maze.ValueObjects;

[TestFixture]
public sealed class MatrixTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        // Arrange
        var generatedMatrix =
            new Matrix<int>(
                MatrixData: new[,]{
                    { 0, 1, 0, 0, 0 },
                    { 0, 1, 0, 1, 0 },
                    { 0, 0, 0, 1, 0 },
                    { 1, 1, 0, 1, 1 },
                    { 0, 0, 0, 0, 0 }
                });

        (int, int)[] shortestPathMatrix = [(0, 0), (1, 0), (2, 0), (2, 1), (2, 2), (3, 2), (4, 2), (4, 3), (4, 4)];

        // Act

        // Assert

        Assert.Pass();
    }
}