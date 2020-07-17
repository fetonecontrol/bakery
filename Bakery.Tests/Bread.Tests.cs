using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FindAndReplace.Models;
using System;

namespace FindAndReplace.Tests
{
  [TestClass]
  public class SentenceTest
  {

    [TestMethod]
    public void Sentence_StoreSentenceInput_Sentence()
    {
      string UserInput = "Hello World";
      Sentence Sentence1 = new Sentence(UserInput);
      Assert.AreEqual(UserInput, Sentence1.SentenceInput);
    }
    [TestMethod]
    public void Sentence_CreateNewSentence_WordReplace()
    {
      string UserInput = "Hello World";
      Sentence Sentence1 = new Sentence(UserInput);
      Words newWords = new Words("Hello", "Bye");
      Assert.AreEqual("Bye World", Sentence1.SentenceInput.Replace(newWords.Replaced, newWords.ReplacedWith));
    }
  }
}

