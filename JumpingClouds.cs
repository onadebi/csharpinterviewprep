namespace LeastPath;

public class JumpingClouds
{
    public static int CloudLeastPath(List<int> c)
    {
        int objResult = 0;
        int index = 0;
        int len = c.Count;

        for (index = 0; index < len; index++)
        {
            if (c[index] == 0)
            {
                objResult++;
            }
            if (index < len - 1 && index < len - 2)
            {

                if (c[index + 1] == 0 && c[index + 2] == 0)
                {
                    c[index + 1] = 1;
                }
            }
        }
        Console.WriteLine(objResult);
        return objResult;
    }
}