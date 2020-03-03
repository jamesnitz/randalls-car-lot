using System;
using System.Collections.Generic;

namespace randalls_car_lot
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Ayyy it's Randy");
      List<Dictionary<string, Dictionary<string, string>>> vehicles = new List<Dictionary<string, Dictionary<string, string>>>();

      Dictionary<string, Dictionary<string, string>> saleInfo = new Dictionary<string, Dictionary<string, string>>();

      Dictionary<string, string> VehicleInfo = new Dictionary<string, string> { { "year", "1999" }, { "model", "cherokee" }, { "make", "jeep" }, { "color", "maroon" } };

      Dictionary<string, string> sales_agent = new Dictionary<string, string> { { "mobile", "555-555-4444" }, { "last_name", "Bigman" }, { "first_name", "Slick" } };

      Dictionary<string, string> credit = new Dictionary<string, string> { { "credit_provider", "The Creditor" }, { "account", "123456789" } };

      saleInfo.Add("vehicleInfo", VehicleInfo);
      saleInfo.Add("sales_agent", sales_agent);
      saleInfo.Add("credit", credit);

      vehicles.Add(saleInfo);


    }
  }
}
