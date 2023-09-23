using System;
using Algorithm.String;
using Algorithm.String.RotateMatrix;
using Xunit;

public class RotateMatrixTests
{
    [Fact]
    public void TestRotateMatrix_SingleElement()
    {
        int[][] matrix =
        {
            new int[] {1}
        };

        int[][] result = RotateMatrix.RunWithInPlace(matrix);

        Assert.Equal(1, result[0][0]);
    }

    [Fact]
    public void TestRotateMatrix_2x2Matrix()
    {
        int[][] matrix =
        {
            new int[] {1, 2},
            new int[] {3, 4}
        };

        int[][] result = RotateMatrix.RunWithInPlace(matrix);

        Assert.Equal(3, result[0][0]);
        Assert.Equal(1, result[0][1]);
        Assert.Equal(4, result[1][0]);
        Assert.Equal(2, result[1][1]);
    }

    [Fact]
    public void TestRotateMatrix_3x3Matrix()
    {
        int[][] matrix =
        {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
        };

        int[][] result = RotateMatrix.RunWithInPlace(matrix);

        int[][] expected =
        {
            new int[] {7, 4, 1},
            new int[] {8, 5, 2},
            new int[] {9, 6, 3}
        };

        for (int i = 0; i < result.Length; i++)
        {
            for (int j = 0; j < result[i].Length; j++)
            {
                Assert.Equal(expected[i][j], result[i][j]);
            }
        }
    }

}