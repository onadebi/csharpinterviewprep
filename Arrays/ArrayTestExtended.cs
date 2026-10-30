using System;
using Xunit;

namespace grouping.Arrays;

public partial class ArrayThings
{

    #region Helper Functions
    /// <summary>
    ///  Returns the position and value of a target value in a sorted array using binary search.   
    /// </summary>
    /// <param name="array">Type: <see cref="int[]"/></param>
    /// <param name="target">Type: <see cref="int"/></param>
    /// <returns>
    /// Type: <see cref="ValueTuple{int position, int objValue}"/>
    /// </returns>
    public static (int position, int objValue) BinarySearchPositionCount(int[] array, int target)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty.");
        }
        int position = 0, objValue = target;

        int low_index = 0, max_index = array.Length;
        for (int i = low_index; i < max_index; i++)
        {
            int mid_point = (array.Length / 2) + 1;
            if (target == array[mid_point])
            {
                position = mid_point;
                break;
            }
            if (target <= array[mid_point])
            {
                low_index = mid_point / 2;
                max_index = mid_point;
            }
            else
            {
                low_index = mid_point;
                max_index = mid_point * 2;
            }
        }

        return (position, objValue);
    }
    #endregion

}

public class ProgramMain
{

    [Theory]
    [InlineData(new int[]{ 1, 2, 3, 4, 6, 7, 10 })]
    public static void Main(int[] obs)
    {
        var result = ArrayThings.BinarySearchPositionCount(obs, 7);
        Console.WriteLine($"{result.position} - {result.objValue}");
    }
}