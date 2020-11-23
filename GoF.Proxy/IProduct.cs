namespace GoF.Proxy
{
  public interface IProduct
  {
    string Description { get; set; }
    decimal Price { get; set; }
    int Amount { get; set; }
    bool Restriction { get; set; }
    int? AgeRestriction { get; set; }
  }
}
