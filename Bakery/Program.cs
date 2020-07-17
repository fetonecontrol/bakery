using System;
using System.Collections.Generic;
using FindAndReplace.Models;

namespace FindAndReplace.Models
{
  public class FindAndReplace
  {
    public static void Main()
    {
      Console.WriteLine("Enter a sentence");
      string Sentence = Console.ReadLine();
      Console.WriteLine("Enter a word to find");
      string WordToFind = Console.ReadLine();
      Console.WriteLine("Enter a word to replace the last word");
      string WordToReplace = Console.ReadLine();
      
      Sentence UserSentence = new Sentence(Sentence);
      Words UserWords = new Words(WordToFind, WordToReplace);

      //string ModSentence = UserSentence.SentenceInput.Replace(UserWords.Replaced, UserWords.ReplacedWith);
      string ModSentence = UserSentence.ReplaceIt();
      Console.WriteLine(ModSentence);
      
    }
  }
}