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
    public void Bread_CalculatePastryOrderPrice_BreadPrice()
    {
      int loaves = 32;
      Bread BreadOrder = new Bread(loaves);
      Assert.AreEqual(110, BreadOrder.BreadPrice());
    }
    
  }
}


