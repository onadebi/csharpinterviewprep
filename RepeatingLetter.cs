public class RepeatingLetter
{
    
    // HackerRank String repeated.
    public static long RepeatedString(string s, long n)
    {
        #region cases where length of string is less than length or required characters
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        if (s.Length > n)
        {
            for (int i = 0; i < n; i++)
            {
                sb.Append(s[i]);
            }
            s = sb.ToString();
        }
        #endregion
        
        long iteration = n / s.Length;
        long modulus = n % s.Length;

        long result = 0;
        foreach (char i in s)
        {
            if (i.ToString() == "a")
            {
                result++;
            }
        }
        result = iteration > 0 ? result * iteration : result;
        if (modulus > 0)
        {
            for (int i = 0; i < modulus; i++)
            {
                if (s[i].ToString() == "a")
                {
                    result++;
                }
            }
        }
        Console.WriteLine(result);
        return result;
    }

}
