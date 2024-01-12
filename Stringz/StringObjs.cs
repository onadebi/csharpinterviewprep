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


    [Fact]
    public void StringObjzTest(){
        Assert.True(isAtEvenIndex("abcef", 'a'));
    } 

}