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
    public int BreadPrice()
    {
      int price = 0; 
        for (int i = 1; i <= NumberOfLoaves; i++)
        {
          Console.WriteLine(price);
          if (i % 3 == 0)
          {
            price += 0;
          }
          else if (i % 3 != 0)
          {
            price += 5;
          } 
        }
      return price;
    }
  }
}