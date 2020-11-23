namespace GoF.Proxy
{
  class Product : IProduct
  {
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Amount { get; set; }
    public bool Restriction { get; set; }
    public int? AgeRestriction { get; set; }


    public Product(string description, decimal price, int amount, bool restriction, int? ageRestriction)
    {
      Description = description;
      Price = price;
      Amount = amount;
      Restriction = restriction;
      AgeRestriction = ageRestriction;
    }
  }
}
