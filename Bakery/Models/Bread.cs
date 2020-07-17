using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int NumberOfLoaves { get; set; }

    public Bread(int input)
    {
      NumberOfLoaves = input;
    }
    
  }
}