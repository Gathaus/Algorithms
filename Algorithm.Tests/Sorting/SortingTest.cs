using Algorithm.Sorting;

namespace Algorithm.Tests.Sorting;

public class SortingTest
{
    private readonly ISortAlgorithm _sortAlgorithm;

    public SortingTest()
    {
        _sortAlgorithm = new MergeSort();
    }

    [Fact]
    public void Sort_IntegerArray_ReturnsSortedArray()
    {
        // Arrange
        int[] unsortedArray = {5, 2, 9, 1, 5};
        int[] expectedSortedArray = {1, 2, 5, 5, 9};

        // Act
        int[] sortedArray = _sortAlgorithm.Sort(unsortedArray);

        // Assert
        Assert.Equal(expectedSortedArray, sortedArray);
    }

    [Fact]
    public void Sort_StringArray_ReturnsSortedArray()
    {
        // Arrange
        string[] unsortedArray = {"banana", "apple", "cherry", "date", "fig"};
        string[] expectedSortedArray = {"apple", "banana", "cherry", "date", "fig"};

        // Act
        string[] sortedArray = _sortAlgorithm.Sort(unsortedArray);

        // Assert
        Assert.Equal(expectedSortedArray, sortedArray);
    }

    [Fact]
    public void Sort_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();
        int[] expectedSortedArray = Array.Empty<int>();

        // Act
        int[] sortedArray = _sortAlgorithm.Sort(emptyArray);

        // Assert
        Assert.Equal(expectedSortedArray, sortedArray);
    }

    [Fact]
    public void Sort_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] singleElementArray = {42};
        int[] expectedSortedArray = {42};

        // Act
        int[] sortedArray = _sortAlgorithm.Sort(singleElementArray);

        // Assert
        Assert.Equal(expectedSortedArray, sortedArray);
    }

    [Fact]
    public void Sort_LargeArray_ReturnsSortedArray()
    {
        // Arrange
        int[] unsortedArray = new int[1000];
        for (int i = 0; i < unsortedArray.Length; i++)
        {
            unsortedArray[i] = unsortedArray.Length - i;
        }

        int[] expectedSortedArray = new int[1000];
        for (int i = 0; i < expectedSortedArray.Length; i++)
        {
            expectedSortedArray[i] = i + 1;
        }

        // Act
        int[] sortedArray = _sortAlgorithm.Sort(unsortedArray);

        // Assert
        Assert.Equal(expectedSortedArray, sortedArray);
    }

    [Fact]
    public void Sort_DescendingArray_ReturnsAscendingArray()
    {
        // Arrange
        int[] descendingArray = {9, 8, 7, 6, 5, 4, 3, 2, 1};
        int[] expectedSortedArray = {1, 2, 3, 4, 5, 6, 7, 8, 9};

        // Act
        int[] sortedArray = _sortAlgorithm.Sort(descendingArray);

        // Assert
        Assert.Equal(expectedSortedArray, sortedArray);
    }

    [Fact]
    public void Sort_DuplicateValues_ReturnsSortedArray()
    {
        // Arrange
        int[] unsortedArray = {5, 2, 9, 1, 5, 2, 9};
        int[] expectedSortedArray = {1, 2, 2, 5, 5, 9, 9};

        // Act
        int[] sortedArray = _sortAlgorithm.Sort(unsortedArray);

        // Assert
        Assert.Equal(expectedSortedArray, sortedArray);
    }
}