using Xunit;

namespace csharpinterviewprep.Stringz;

public class StringObjz{


    static bool isAtEvenIndex(string s, char c){
        if(s == null || s.Length == 0) return false;
        if(s.Length == 1) return s[0] == c;
        if(s[0] == c) return true;
        bool result =  s.IndexOf(c) % 2 == 0;
        return result;
    }

    /// <summary>
    /// Raw implementation without using any built in methods
    /// </summary>
    /// <param name="s"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    static bool IsAtEvenindexPosition(string s, char c){
        if(String.IsNullOrWhiteSpace(s)) return false;
        int i;
        for(i = 0; i< ((s.Length/2) + 1); i += 2){
            if(s[i] == c){
                return true;
            }
        }
        return false;
    }

    static bool IsAtEvenIndexPositionIgnoreCase(string s, char c){
        if(String.IsNullOrWhiteSpace(s)) return false;
        int i;
        s = s.ToLower();
        c= Char.ToLower(c);
        for(i = 0; i< ((s.Length/2) + 1); i += 2){
            if(s[i] == c){
                return true;
            }
        }
        return false;
    }




    [Fact]
    public void StringObjzTestPositionCaseSensitive(){
        Assert.True(IsAtEvenindexPosition("abCef", 'C'));
    }

    [Fact]
    public void StringObjzTestPositionCaseInSensitive(){
        Assert.True(IsAtEvenIndexPositionIgnoreCase("ABcef", 'C'));
    }

    [Fact]
    public void StringObjzTest(){
        Assert.True(isAtEvenIndex("abcef", 'a'));
    } 

}