using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Palindrome;

namespace Palindrome.Tests
{

  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void IsPalindrome_compare_True()
    {
      //Arrange
      Palindrome newString = new Palindrome();
      // var output = "MADAM";


      //Act
      // string result = newString.FindAndReplace();

      //Assert
      Assert.AreEqual(true, newString.IsPalindrome("mad"));

    }
  }
}
