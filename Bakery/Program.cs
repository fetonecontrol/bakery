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
      Console.WriteLine("Otherwise, enter any not numerical character to advance to the Pastry menu");
      string breadOrderNumber = Console.ReadLine();
      if (breadOrderNumber == @"\d+\")
      {
      int number = Int32.Parse(breadOrderNumber);
      Bread loaves = new Bread(number);
      Console.WriteLine("The Price for Bread is: " + " " + loaves.NumberOfLoaves);
      }
      else 
      {
      Console.WriteLine("If you would like to order pastrys, please enter a number,");
      Console.WriteLine("Otherwise, enter N");
      string loaves = Console.ReadLine();
      }
      
    }
  }
}