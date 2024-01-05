
using csharpinterviewprep.Arrays;
using Xunit;

namespace Arrays;
public class ArrayThings
{
    [Theory]
    [InlineData(6)]
    public void ArrayLastInsert(int value)
    {
        int[] objResp = ArrayInsertLast(value);
        foreach (var item in objResp)
        {
            Console.WriteLine(item);
        }
        Assert.NotNull(objResp);
    }

    [Theory]
    [InlineData(6, 6)]
    [InlineData(6, 7)]
    public void ArrayFirstInsert(int value, int insertionValue)
    {
        int[] objResp = ArrayInsertFirst(value, insertionValue);
        int item = Array.Find(objResp,(p)=> p== insertionValue);

        Abstractor checker = new AbstractImpl();
        string callerName = checker.GetName();
        int item2 = Abstractor.FindAll(objResp, a => a == insertionValue);
        Assert.Equal(objResp[0], insertionValue);
    }

    public int[] ArrayInsertLast(int arrayCount = 6)
    {
        int[] arrayz = new int[arrayCount];
        int length = 0;

        for (int i = 0; i <= 3; i++)
        {
            arrayz[i] = length + 1;
            length++;
        }
        return arrayz;
    }

    public int[] ArrayInsertFirst(int arrayCount, int valueToInsert)
    {
        int[] arrayz = new int[arrayCount];
        int length = 0;
        for (int i = 0; i < arrayz.Length; i++)
        {
            arrayz[i] = length + 1;
            length++;
        }
        int countOfNonZero = arrayz.Where(x => x > 0).Count();
        for (int i = countOfNonZero; i >= 0; i--)
        {
            //int currentValue = arrayz[i+1];
            if (i == 0)
            {
                arrayz[i] = 0;
                break;
            }
            if (i == arrayz.Length)
            {
                continue;
                int[] newArray = new int[arrayz.Length+1];
                Array.Copy(arrayz, newArray, arrayz.Length);
            }
            arrayz[i] = arrayz[i - 1];
            //arrayz[0] = currentValue;
        }
        arrayz[0] = valueToInsert;
        return arrayz;
    }
}