namespace csharpinterviewprep.Stringz;
using Xunit;
using Xunit.Abstractions;

public class StringObjsTest
{

    private readonly ITestOutputHelper _output;

    public StringObjsTest(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void StringObjzTestPositionCaseSensitive()
    {
        Assert.True(StringObjz.IsAtEvenindexPosition("abCef", 'C'));
    }

    [Fact]
    public void StringObjzTestPositionCaseInSensitive()
    {
        Assert.True(StringObjz.IsAtEvenIndexPositionIgnoreCase("ABcef", 'C'));
    }

    [Fact]
    public void StringObjzTest()
    {
        Assert.True(StringObjz.isAtEvenIndex("abcef", 'a'));
    }

    [Fact]
    public void ReverseStringTest()
    {
        // Arrange
        string s = "abcef";
        // Act
        string reversedString = StringObjz.ReverseString(s);
        // Assert
        Assert.Equal("fecba", reversedString);
    }

    [Fact]
    void ReverseStringBuiltInTest()
    {
        // Arrange
        string s = "abcEfgh";
        // Act
        string reversedString = StringObjz.ReverseStringUsingCharArrays(s);
        _output.WriteLine($"\n***The reversed value: {reversedString} ***\n");
        // Assert
        Assert.Equal("hgfEcba", reversedString);
    }

    [Fact]
    void EnumerateStringTest()
    {
        int countOfTimes = 5;
        string result = string.Concat(Enumerable.Repeat("done", countOfTimes));
        System.Console.WriteLine(result);
    }

    [Fact]
    void IsPalindromeCheckTest()
    {
        // Arrange
        string s = "abcEfgh";
        // Act
        bool isPalindrome = StringObjz.IsPalindromeCheck(s);
        // Assert
        Assert.True(isPalindrome);
    }

    [Theory(DisplayName = nameof(IsAllUpperCaseTest))]
    [InlineData("ABC")]
    void IsAllUpperCaseTest(string s)
    {
        // Act
        bool isUpper = IsUpperCase(s);
        // Assert
        Assert.True(isUpper);
    }

    [Theory(DisplayName = nameof(SomeUpperCaseTest))]
    [InlineData("AbXyZ")]
    void SomeUpperCaseTest(string s)
    {
        // Assert that there Exception is thrown if isUpper is false
        Assert.Throws<System.Exception>(() => IsLowerCase(s));

        // Capture the error message thrown
        var ex = Assert.Throws<System.Exception>(() => IsLowerCase(s));
        Assert.Equal("Not all characters are lower case", ex.Message);
    }

    [Theory(DisplayName = nameof(NameLettersCheck))]
    [InlineData("AbXyZ")]
    void NameLettersCheck(string s)
    {
        //Act 
        var IsValidName = NameLetters(s);
        // Assert that there Exception is thrown if isUpper is false
        Assert.True(IsValidName);
    }

    [Theory(DisplayName = nameof(PasswordComplexityCHeck))]
    [InlineData("AbXyZ")]
    [InlineData("Pa55word")]
    void PasswordComplexityCHeck(string s)
    {
        //Act 
        var IsPwdComplex = IsPasswordComplex(s);
        // Assert
        Assert.True(IsPwdComplex);
    }

    #region HELPERS
    Func<string,bool> IsUpperCase =(s) => s.All(char.IsUpper);
    Func<string,bool> NameLetters =(s) => s.All(m => (char.IsLetter(m)));

    public bool IsLowerCase(string s)
    {
        bool objResp = s.All(char.IsLower);
        if (!objResp)
        {
            // Return exception that can be captured in a variable
            throw new System.Exception("Not all characters are lower case");
        }
        return objResp;
    }

    Func<string, bool> IsPasswordComplex = (s) =>
    {
        return s.Any(_ => char.IsDigit(_)) && s.Any(m => char.IsUpper(m)) && s.Any(_ => char.IsLower(_));
    };
    #endregion
}
