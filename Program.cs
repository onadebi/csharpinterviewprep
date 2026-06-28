namespace Grouping;

using csharpinterviewprep.LinkeredLists;
using grouping.Arrays;

partial class Program
{


    public static void Main(string[] args)
    {

        #region StringSorter
        var words = "Elephant Ant Bear Zebra Cat Dog Alligator Ape Ostrich Slot";
        string[] objStrResult = StringSorter.SortWithLengthAsPriority(words);
        Array.ForEach<string>(objStrResult,e => Console.Write($"{e} ({e.Length})|"));
        Console.WriteLine(string.Concat("\n\t",string.Join("",System.Linq.Enumerable.Repeat("=",40))));

        string[] objStrResultDesc = StringSorter.SortWithLengthAsPriority(words,SortDirection.DESC);
        Array.ForEach<string>(objStrResultDesc,e => Console.Write($"{e} ({e.Length})|"));
        #endregion

        // #region LeetCode
        // //TODO: SumTwo
        // Console.WriteLine(LeetCode.TwoSum.GetSums(new int[] { 3, 2, 4 }, 6));
        // #endregion

        // //Comment out below unneeded region blocks when you need to test specific test cases
        // #region FizzBuzz
        // CSharp.FizzBuzzer.FizzBuzz.fizzBuzzed(15);
        // #endregion

        // #region SockMerchant
        // Program.sockMerchant(7);
        // #endregion

        // #region  Repeated String
        // RepeatingLetter.RepeatedString("ababa", 3);
        // #endregion

        // #region Least Path jumping clouds
        // LeastPath.JumpingClouds.CloudLeastPath(new List<int> { 0, 0, 1, 0, 0, 1, 0 });
        // #endregion

    }
    // public static void Main(string[] args)
    // {
    //     Console.WriteLine("Hellow");
    // }

    // Sock Merchant color pairing
    public static int sockMerchant(int n)
    {
        #region Linker
        MyList lister = new MyList();
        lister.Add("1");
        lister.Add("2");
        lister.Add("3");
        lister.Add("4");
        lister.Add("5");
        lister.Print();
        //lister.Add("New Item");
        #endregion


        List<int> ar = new List<int>() { 1, 2, 1, 2, 1, 3, 2, 5, 5, 5, 3, 2, 1 };
        var values = ar.GroupBy(q => q).Where(q => q.Count() >= 2).ToDictionary(m => m.Key, m => m.Count());
        List<int> countPairs = new List<int>();
        int countResult = 0;
        if (values.Any())
        {
            foreach (KeyValuePair<int, int> i in values)
            {
                Console.WriteLine(i);
                countResult += i.Value / 2;
            }
        }
        Console.WriteLine(countResult);
        return countResult;
    }

}