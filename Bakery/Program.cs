using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Models
{
  public class Bakery
  {
    public static void Main()
    { 
      Console.WriteLine("Would you like to Purchase Bread, Pastry, or both?");
      Console.WriteLine("If you would like to order Bread, please enter a number,");
      Console.WriteLine("Otherwise, enter N to advance to the Pastry Menu");
      string breadOrder = Console.ReadLine();
      int breadOrderNumber = Int32.Parse(breadOrder);
      Bread loaves = new Bread(breadOrderNumber);
      Console.WriteLine("The Price for Bread is: " + " " + loaves.BreadPrice());
    
      Console.WriteLine("If you would like to order pastrys, please enter a number,");
      Console.WriteLine("Otherwise, enter N");
      string pastryOrder = Console.ReadLine();
      int pastryOrderNumber = Int32.Parse(pastryOrder);
      Pastry pastries = new Pastry(pastryOrderNumber);
      Console.WriteLine("The Price for Pastries is: " + " " + pastries.PastryPrice());
      }

    }
}
