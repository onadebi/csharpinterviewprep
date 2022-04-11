// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
partial class Program
{

    public static void Main(string[] args)
    {
        //Comment out below unneeded region blocks when you need to test specific test cases
        #region FizzBuzz
        CSharp.FizzBuzzer.FizzBuzz.fizzBuzzed(15);
        #endregion

        #region SockMerchant
        Program.sockMerchant(7);
        #endregion

        #region  Repeated String
        RepeatingLetter.RepeatedString("ababa", 3);
        #endregion

        #region Least Path jumping clouds
        LeastPath.JumpingClouds.CloudLeastPath(new List<int>{0, 0, 1 ,0 ,0, 1 ,0});
        #endregion

    }

    // Sock Merchant color pairing
    public static int sockMerchant(int n)
    {
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