using System.Collections.Generic;
using System;

namespace FindAndReplace.Models 
{
  public class Words
  {
    public string Replaced { get; set; }
    public string ReplacedWith { get; set; }

    public Words(string input, string input2)
    {
      Replaced = input;
      ReplacedWith = input2;
    }

  }
}