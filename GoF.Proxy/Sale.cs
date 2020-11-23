using System;

namespace GoF.Proxy
{
  class Sale : ISale
  {
    public void Sell(ICustomer customer)
    {
      Console.WriteLine("Receipt:");
      customer.Cart.ForEach(p => Console.WriteLine(p.Amount + "x " + p.Description));
      Console.WriteLine("End of Sale");
      Console.WriteLine("-----------");
      Console.WriteLine();
    }
  }
}
