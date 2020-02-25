using System;
using System.Collections.Generic;


public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
  public string Message;
  public Car(string makeModel, int price, int miles, string message)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
    Message = message;
  }
  public bool WorthyMiles(int maxMiles)
  {
    return (Miles < maxMiles);
  }

  public bool WorthyPurchase(int maxPrice)
  {
    return (Price < maxPrice);
  }
}

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

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum miles: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);


    List<Car> CarsMatchingSearch = new List<Car>(0);
    foreach(Car automobile in Cars)
    {
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
      Console.WriteLine(automobile.MakeModel);
      Console.WriteLine(automobile.Message);
    }
    if (CarsMatchingSearch.Count == 0)
    {
     Console.WriteLine("No matches!");
   }
  }
}
