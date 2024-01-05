namespace CSharp.FizzBuzzer;

public class FizzBuzz
{
    public static void fizzBuzzed(int n)
    {
        #region Shorter code impl.
        for (int i = 1; i <= n; i++)
        {
            string result = i switch
            {
                _ when (i % 15 == 0) => "FizzBuzz",
                _ when (i % 3 == 0) && (i % 5 != 0) => "Fizz",
                _ when (i % 3 != 0) && (i % 5 == 0) => "Buzz",
                int val => $"{val}"
            };
            Console.WriteLine(result);
        }
        #endregion

        for (int i = 1; i <= n; i++)
        {
            #region For Code implementation before C#7
            // if(i%15 == 0){
            //     Console.WriteLine("FizzBuzz");
            // }
            // if(i%3 ==0 && i %5 != 0){
            //      Console.WriteLine("Fizz");
            // }
            // if(i%5 ==0 && i %3 != 0){
            //      Console.WriteLine("Buzz");
            // }
            // if(i%5 !=0 && i %3 != 0){
            //      Console.WriteLine(i);
            // }
            #endregion

            #region Below code is for C# 7 and above
            switch (i)
            {
                case var _ when (i % 15 == 0):
                    Console.WriteLine("FizzBuzz");
                    break;
                case var expression when (i % 3 == 0 && i % 5 != 0):
                    Console.WriteLine("Fizz");
                    break;
                case var valz when (i % 5 == 0 && i % 3 != 0):
                    Console.WriteLine("Buzz");
                    break;
                case var notused when (i % 5 != 0 && i % 3 != 0):
                    Console.WriteLine(i);
                    break;
            }
            #endregion
        }
    }
}