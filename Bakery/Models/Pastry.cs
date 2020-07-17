using System.Collections.Generic;
using System;

namespace Bakery.Models 
{
  public class Pastry
  {
    public int NumberOfPastries { get; set; }

    public Pastry(int input)
    {
      NumberOfPastries = input;

    }    
    public int PastryPrice()
    {
      int price = 0;
      for (int i = 1; i <= NumberOfPastries; i++)
      {
        Console.WriteLine(price);
        if (i % 3 == 0)
        {
          price += 1;
        }
        else if (i % 3 != 0)
        {
          price += 2;
        } 
      }
      return price;
    }
  }
}