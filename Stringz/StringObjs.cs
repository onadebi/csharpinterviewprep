using System.Text;
using Xunit;

namespace csharpinterviewprep.Stringz;

public class StringObjz{


    public static bool isAtEvenIndex(string s, char c){
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
    public static bool IsAtEvenindexPosition(string s, char c){
        if(String.IsNullOrWhiteSpace(s)) return false;
        int i;
        for(i = 0; i< ((s.Length/2) + 1); i += 2){
            if(s[i] == c){
                return true;
            }
        }
        return false;
    }

    public static bool IsAtEvenIndexPositionIgnoreCase(string s, char c){
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

    /// <summary>
    /// Reverse a string, using a StringBuilder with no built-in methods
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    internal static string ReverseString(string s)
    {
        if(String.IsNullOrWhiteSpace(s)) return s;
        StringBuilder sb = new();
        for(int i = s.Length; i > 0; i -= 1){
            sb.Append(s[i-1]);
        }
        return sb.ToString();
    }

    /// <summary>
    /// Reverse a string using CharArrays
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    internal static string ReverseStringUsingCharArrays(string s){
        if(String.IsNullOrWhiteSpace(s)) return s;
        Char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }


    /// <summary>
    /// Check if a string is a palindrome
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    internal static bool IsPalindromeCheck(string s){
        if(String.IsNullOrWhiteSpace(s)) return false;
        string normalizedVal = s.ToLower();
        int l = normalizedVal.Length;

        for(int i = 0; i >= (normalizedVal.Length/2); i +=1 ){
            if(normalizedVal[i] != normalizedVal[l - i -1]){
                return false;
            }
        }
        return true;
    }
}