using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FindAndReplace.Models;
using System;


namespace FindAndReplace.Tests
{
  [TestClass]
  public class WordsTest
  {

    // [TestMethod]
    // public void WordToReplace_StoreWordToReplace_WordToReplace()
    // {
    //   string UserInput = "Hello";
    //   Words newWords = new Words(UserInput);
    //   Assert.AreEqual("Hello", newWords.Replaced);
    // }

    [TestMethod]
    public void Words_StoreWordToReplaceWith_WordToReplaceWith()
    {
      Words newWords = new Words("Hi", "Bye");
      Assert.AreEqual("Hi", newWords.Replaced);
      Assert.AreEqual("Bye", newWords.ReplacedWith);
    }
  }
}