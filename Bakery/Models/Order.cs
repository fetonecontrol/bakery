using System.Collections.Generic;
using System;

namespace Bakery.Models 
{
  public class Order
  {
    public int OrderTotal { get; set; }

    public Order(int bread, int pastry)
    {
      OrderTotal = bread + pastry;

    }    
  }
}