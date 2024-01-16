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
    public void StringObjzTestPositionCaseSensitive(){
        Assert.True(StringObjz.IsAtEvenindexPosition("abCef", 'C'));
    }

    [Fact]
    public void StringObjzTestPositionCaseInSensitive(){
        Assert.True(StringObjz.IsAtEvenIndexPositionIgnoreCase("ABcef", 'C'));
    }

    [Fact]
    public void StringObjzTest(){
        Assert.True(StringObjz.isAtEvenIndex("abcef", 'a'));
    } 

    [Fact]
    public void ReverseStringTest(){
        // Arrange
        string s = "abcef";        
        // Act
        string reversedString = StringObjz.ReverseString(s);
        // Assert
        Assert.Equal("fecba", reversedString);
    }

    [Fact]
    void ReverseStringBuiltInTest(){
        // Arrange
        string s = "abcEfgh";        
        // Act
        string reversedString = StringObjz.ReverseStringUsingCharArrays(s);
        _output.WriteLine($"\n***The reversed value: {reversedString} ***\n");
        // Assert
        Assert.Equal("hgfEcba", reversedString);
    }

    [Fact]
    void IsPalindromeCheckTest(){
        // Arrange
        string s = "abcEfgh";
        // Act
        bool isPalindrome = StringObjz.IsPalindromeCheck(s);
        // Assert
        Assert.True(isPalindrome);
    }
}
