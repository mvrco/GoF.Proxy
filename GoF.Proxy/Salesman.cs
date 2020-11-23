using System;
using System.Collections.Generic;

namespace GoF.Proxy
{
  class Salesman : ISale
  {
    public void Sell(ICustomer customer)
    {
      ISale sale = new Sale();
      List<IProduct> adjustCart = new List<IProduct>();

      foreach (IProduct p in customer.Cart)
      {
        if (p.Restriction == true)
          if (p.AgeRestriction > customer.Age)
            Console.WriteLine("Customer is too young to buy " + p.Description);
          else
            adjustCart.Add(p);
        else
          adjustCart.Add(p);
      }

      customer.Cart = adjustCart;

      if (customer.Cart.Count > 0)
        sale.Sell(customer);
      else
      {
        Console.WriteLine("There are no Items to sell in the cart.");
        Console.WriteLine("End of Sale");
        Console.WriteLine("-----------");
        Console.WriteLine();
      }
        
    }
  }
}
