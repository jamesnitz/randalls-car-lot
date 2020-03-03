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

      Dictionary<string, Dictionary<string, string>> bigmanSalesInfo = new Dictionary<string, Dictionary<string, string>>();

      Dictionary<string, string> bigmanVehicleInfo = new Dictionary<string, string> { { "year", "1999" }, { "model", "cherokee" }, { "make", "jeep" }, { "color", "maroon" } };

      Dictionary<string, string> bigmanSalesAgent = new Dictionary<string, string> { { "mobile", "555-555-4444" }, { "last_name", "Bigman" }, { "first_name", "Slick" } };

      Dictionary<string, string> bigmanCredit = new Dictionary<string, string> { { "credit_provider", "The Creditor" }, { "account", "123456789" } };

      bigmanSalesInfo.Add("vehicleInfo", bigmanVehicleInfo);
      bigmanSalesInfo.Add("sales_agent", bigmanSalesAgent);
      bigmanSalesInfo.Add("credit", bigmanCredit);

      vehicles.Add(bigmanSalesInfo);

      Dictionary<string, Dictionary<string, string>> davisSalesInfo = new Dictionary<string, Dictionary<string, string>>();

      Dictionary<string, string> davisVehicleInfo = new Dictionary<string, string> { { "year", "2013" }, { "model", "Crosstrek" }, { "make", "Subaru" }, { "color", "White" } };

      Dictionary<string, string> DavisSalesAgent = new Dictionary<string, string> { { "mobile", "555-555-4444" }, { "last_name", "Dad" }, { "first_name", "My" } };

      Dictionary<string, string> DavisCredit = new Dictionary<string, string> { { "credit_provider", "The Creditor" }, { "account", "234234234234" } };

      davisSalesInfo.Add("davisVehicleInfo", davisVehicleInfo);
      davisSalesInfo.Add("sales_agent", DavisSalesAgent);
      davisSalesInfo.Add("credit", DavisCredit);

      vehicles.Add(davisSalesInfo);

      foreach (Dictionary<string, Dictionary<string, string>> saleDict in vehicles)
      {
        foreach (KeyValuePair<string, Dictionary<string, string>> salePair in saleDict)
        {
          Console.WriteLine("-----------");
          Console.WriteLine(salePair.Key);
          foreach (KeyValuePair<string, string> section in salePair.Value)
          {
            Console.WriteLine($"{section.Key}: {section.Value}");
          }
        }
      }

    }
  }
}
