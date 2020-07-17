using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;


namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_StorePasterOrder_Pastry()
    {
      int numberOfPastries = 5;
      Pastry pastryOrder = new Pastry(numberOfPastries);
      Assert.AreEqual(5, pastryOrder.NumberOfPastries);
    }
    [TestMethod]
    public void Pastry_CalculatePastryOrderPrice_Pastry()
    {
      int numberOfPastries = 32;
      int price = 0; 
      for (int i = 1; i <= numberOfPastries; i++)
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
      Assert.AreEqual(54, price);
    }
  }
}