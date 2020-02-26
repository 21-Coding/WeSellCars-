using System;
using System.Collections.Generic;
using Dealership.Model;


namespace Dealership 
{


    public class Program
    {
      public static void Main()
      {
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
        Car bmw = new Car("1990 BMW Alpine", 110100, 4000, "Rides smooth, huge dents on sides.");
        Car chevy = new Car("2019 Chevy Silverado", 200000, 130000, "Brakes are bad.");
        Car magiccarpet = new Car("2022 Tesla Magic Carpet", 210000, 100000, "Needs weekly shampoo.");
        Car magicschoolbus = new Car("1991 Cheese Bus", 1, 90000000, "Snacks and crumbs in seats.");

        List<Car> Cars = new List<Car>() {bmw, chevy, magiccarpet, magicschoolbus};

        chevy.SetPrice(300);

        Console.WriteLine("Enter maximum price: ");
        string stringMaxPrice = Console.ReadLine();
        int maxPrice = int.Parse(stringMaxPrice);

        Console.WriteLine("Enter maximum miles: ");
        string stringMaxMiles = Console.ReadLine();
        int maxMiles = int.Parse(stringMaxMiles);


        List<Car> CarsMatchingSearch = new List<Car>(0);
        foreach(Car automobile in Cars)
        {
          // Console.WriteLine(automobile.GetMakeModel());
          if (automobile.WorthyPurchase(maxPrice))
          {

          if (automobile.WorthyMiles(maxMiles))
          {
            CarsMatchingSearch.Add(automobile);
          }
        }
        if (!automobile.WorthyPurchase(maxPrice))
        {
          Console.WriteLine("Price is too low!");
        }
        }


        foreach(Car automobile in CarsMatchingSearch)
        {
          Console.WriteLine(automobile.GetMakeModel());
          Console.WriteLine(automobile.GetMessage());
          Console.WriteLine(automobile.GetMiles() + " Miles");
          Console.WriteLine("$" + automobile.GetPrice() + ".00");

        }
        if (CarsMatchingSearch.Count == 0)
        {
        Console.WriteLine("No matches!");
      }
    }
  }
}
