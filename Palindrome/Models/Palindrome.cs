using System;
using System.Collections.Generic;

//
// namespace Palindrome
// {
//   public class Palindrome
//   {
//     public bool IsPalindrome(string input)
//     { string result="";
//       char a = '@';
//       char[] SplitInput = input.ToCharArray();
//       for (int i=SplitInput.Length; i>=0; i--)
//       {
//         ++a;
//         result += a;
//       }
//       if(input == result)
//       {
//         return true;
//       }
//       else
//       {
//         return false;
//       }
//     }
//   }
// }

namespace Palindrome
{
  public class Palindrome
  {
    public bool IsPalindrome(string input, )
    {
      char[] SplitInput = input.ToCharArray();
      for (int i=SplitInput.Length; i>=0; i--)
      {
          result.Add(SplitInput[i]);
      }
      if(SplitInput == result)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
