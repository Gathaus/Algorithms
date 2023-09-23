using Algorithm.String.ZeroMatrix;

namespace Algorithm.Tests.String;

using System;
using Xunit;
using System;
using Xunit;

public class ZeroMatrixTest 
{
    [Fact]
    public void WithEmpty() 
    {
        Assert.True(EqualsDeep(new int[][] { }, ZeroMatrix.RunWithInPlace(new int[][] { })));
    }

    [Fact]
    public void WithOneOne() 
    {
        Assert.True(EqualsDeep(new int[][] { new int[] { 1 } }, ZeroMatrix.RunWithInPlace(new int[][] { new int[] { 1 } })));
    }

    [Fact]
    public void WithOneOne_Zero() 
    {
        Assert.True(EqualsDeep(new int[][] { new int[] { 0 } }, ZeroMatrix.RunWithInPlace(new int[][] { new int[] { 0 } })));
    }

    [Fact]
    public void WithOneTwo() 
    {
        Assert.True(EqualsDeep(new int[][] { new int[] { 0, 0 } }, ZeroMatrix.RunWithInPlace(new int[][] { new int[] { 0, 0 } })));
    }

    [Fact]
    public void WithTwoTwo() 
    {
        Assert.True(EqualsDeep(
            new int[][] { 
                new int[] { 0, 0 }, 
                new int[] { 0, 1 }
            }, 
            ZeroMatrix.RunWithInPlace(new int[][] { 
                new int[] { 0, 1 }, 
                new int[] { 1, 1 }
            })
        ));
    }

    [Fact]
    public void WithThreeThree() 
    {
        Assert.True(EqualsDeep(
            new int[][] {
                new int[] { 1, 0, 3 },
                new int[] { 0, 0, 0 },
                new int[] { 7, 0, 9 }
            },
            ZeroMatrix.RunWithInPlace(
                new int[][] {
                    new int[] { 1, 2, 3 },
                    new int[] { 4, 0, 6 },
                    new int[] { 7, 8, 9 }
                }
            )
        ));
    }

    private bool EqualsDeep(int[][] first, int[][] second) 
    {
        if (first.Length != second.Length)
            return false;

        for (int i = 0; i < first.Length; i++) 
        {
            for (int j = 0; j < first[i].Length; j++) 
            {
                if (first[i][j] != second[i][j])
                    return false;
            }
        }
        return true;
    }
}