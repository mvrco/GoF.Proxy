using System;

namespace GoF.Proxy
{
  class Program
  {
    static void Main(string[] args)
    {
      // Verkäufer öffnet den Laden und beginnt zu arbeiten
      Salesman salesman = new Salesman();

      #region Kunde 1
      // Kunde betritt den Laden und hat ein Alter
      ICustomer c1 = new Customer(30);

      // Kunde füllt seinen Einkaufswagen/-korb
      c1.AddItemToCart(new Product("Banane", 0.90m, 5, false, null));
      c1.AddItemToCart(new Product("Bier", 1.50m, 10, true, 16));
      c1.AddItemToCart(new Product("Vodka", 9.90m, 1, true, 18));
      c1.AddItemToCart(new Product("Apfel", 1.00m, 2, false, null));

      // Kunde kommt zur Kasse, der Verkäufer scannt die Artikel ein
      // Es wird geprüft ob eine Altersbeschränkung auf einem Artikel vorhanden ist
      salesman.Sell(c1);
      #endregion

      #region Kunde 2
      ICustomer c2 = new Customer(14);
      c2.AddItemToCart(new Product("Vodka", 9.90m, 1, true, 18));
      salesman.Sell(c2);
      #endregion

      #region Kunde 3
      ICustomer c3 = new Customer(17);

      c3.AddItemToCart(new Product("Banane", 0.90m, 4, false, null));
      c3.AddItemToCart(new Product("Bier", 1.50m, 10, true, 16));
      c3.AddItemToCart(new Product("Vodka", 9.90m, 1, true, 18));
      c3.AddItemToCart(new Product("Apfel", 1.00m, 2, false, null));
      
      salesman.Sell(c3);
      #endregion

      Console.ReadLine();
    }
  }
}
