using System.Collections.Generic;

namespace GoF.Proxy
{
  public interface ICustomer
  {
    int Age { get; set; }
    List<IProduct> Cart { get; set; }

    void AddItemToCart(IProduct item);
  }
}
