using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void Bread_StoreBreadOrder_Bread()
    {
      int numberOfLoaves = 5;
      Bread breadOrder = new Bread(numberOfLoaves);
      Assert.AreEqual(5, breadOrder.NumberOfLoaves);
    }
    [TestMethod]
    public void Bread_CalculateBreadOrderPrice_Bread()
    {
      int numberOfLoaves = 3;
      int price = 0; 
      for (int i = 1; i <= numberOfLoaves; i++)
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
      Assert.AreEqual(10, price);
    }
    
  }
}

