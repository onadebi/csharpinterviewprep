using Xunit;
using Xunit.Abstractions;

namespace grouping.Stringz
{
    public class PalindromeTest
    {        
        bool PalindromeCheck(String word)
        {

            if (String.IsNullOrEmpty(word)) return false;
            int length = word.Length / 2; // word.Length % 2 == 0 ? word.Length /2 : word.Length +1;
            word = word.ToLower();
            for(int i = 0; i < length; i++) {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }


        [Fact]
        public void PalindromeCheckTest() {
            string[] words = {"cac","ciVic","Rotor"};

            Array.ForEach(words,word=> Assert.True(PalindromeCheck(word)));
        }
    }
}
