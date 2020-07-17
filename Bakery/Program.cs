using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Models
{
  public class Bakery
  {
    public static void Main()
    { 
      try
      {  
        Console.WriteLine("Please enter the number of Loaves you'd like.");
        Console.WriteLine("Bread is 5 Ruppees a loaf and buy 2, get 1 free!");
        string breadOrder = Console.ReadLine();
        int breadOrderNumber = Int32.Parse(breadOrder);
        Bread loaves = new Bread(breadOrderNumber);
      
        Console.WriteLine("Please enter the number of Pastries you'd like.");
        Console.WriteLine("Pastries are 2 Ruppees each, or 3 for 5!");
        string pastryOrder = Console.ReadLine();
        int pastryOrderNumber = Int32.Parse(pastryOrder);
        Pastry pastries = new Pastry(pastryOrderNumber);
        Console.WriteLine("The Price for Bread is: " + " " + loaves.BreadPrice() + " " + "Ruppees");
        Console.WriteLine("The Price for Pastries is: " + " " + pastries.PastryPrice() + " " + "Ruppees");
        Order total = new Order(loaves.BreadPrice(), pastries.PastryPrice());
        Console.WriteLine("The Total Price of Your Order is: " + " " + total.OrderTotal + " " + "Ruppees");
        Console.WriteLine("If you would like to place another order, enter Y, all other input will end program.");
        string cont = Console.ReadLine();
        if (cont == "Y")
        {
          Console.WriteLine("Here We Go Again!");
          Main();
        }
        else
        {
          Console.WriteLine("Thanks for Stopping By! There's Monsters Out There, Travel Safe!");
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message + " " +"Please Pay Attention to the Prompts. Only The Suggested Inputs are Valid");
        Main();
      } 
    }

    }
}
