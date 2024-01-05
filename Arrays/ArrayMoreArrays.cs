using Xunit;

namespace csharpinterviewprep.Arrays;

public class ArrayMoreArrays
{
    [Theory]
    [InlineData(0)]
    public void MatrixChecker(int dummy)
    {

        Assert.IsType<int>(dummy);
        // Declare and initialize a List<List<int>>
        List<List<int>> twoDList = new List<List<int>>();

        // Create and add rows (inner lists) to the 2D list
        twoDList.Add(new List<int> { 1, 2, 3 });
        twoDList.Add(new List<int> { 4, 5 });
        twoDList.Add(new List<int> { 6, 7, 8, 9 });

        // Access and modify elements
        int element = twoDList[0][1]; // Accessing second element of the first row
        Console.WriteLine($"Element at [0][1]: {element}");

        twoDList[1][0] = 10; // Modifying the first element of the second row

        // Display the entire 2D list
        Console.WriteLine("2D List:");
        foreach (List<int> row in twoDList)
        {
            foreach (int num in row)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }

}