using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;


namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void Order_AddOrderTotal_Order()
    {
      int value1 = 5;
      int value2 = 5;
      Order newOrder = new Order(value1, value2);
      Assert.AreEqual(10, newOrder.OrderTotal);
    }
  }
}