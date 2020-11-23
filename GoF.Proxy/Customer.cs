using System.Collections.Generic;

namespace GoF.Proxy
{
  class Customer : ICustomer
  {
    public int Age { get; set; }
    public List<IProduct> Cart { get; set; }

    public Customer(int age)
    {
      Age = age;
      Cart = new List<IProduct>();
    }

    public void AddItemToCart(IProduct item)
    {
      Cart.Add(item);
    }
  }
}
