using System;

namespace grouping.Arrays;


public enum SortDirection
{
    ASC,
    DESC
}
public static class StringSorter
{

    public static string[] SortWithLengthAsPriority(string s, SortDirection direction = SortDirection.ASC)
    {
        if (s == null || string.IsNullOrWhiteSpace(s)) { return Array.Empty<string>(); }
        string[] arr = s.Split(" ");
        Array.Sort(arr, (a, b) =>
        {
            if (a.Length != b.Length)
            {
                return b.Length.CompareTo(a.Length);
            }
            return direction == SortDirection.ASC ?
             string.Compare(a, b, StringComparison.Ordinal) :
             string.Compare(b, a, StringComparison.Ordinal);
        });
        return arr;
    }
}