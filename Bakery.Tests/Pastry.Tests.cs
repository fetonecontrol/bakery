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
      int numberOfPastries = 16;
      int price = 0; 
      if ((numberOfPastries % 3) == 0)
      {
        int x = numberOfPastries / 3;
        price = x * 5;
      }
      Assert.AreEqual(25, price);
    }
  }
}