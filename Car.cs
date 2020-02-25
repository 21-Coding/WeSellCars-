using System;
using System.Collections.Generic;


public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;

  public bool WorthyPurchase(int maxPrice)
  {
    return (Price < maxPrice);
  }
}

public class Program
{
  public static void Main()
  {
    Car bmw = new Car();
    bmw.MakeModel = "1990 BMW Alpine";
    bmw.Price = 110100;
    bmw.Miles = 4000;

    Car chevy = new Car();
    chevy.MakeModel = "2019 Chevy Silverado";
    chevy.Price = 200000;
    chevy.Miles = 130000;

    Car magiccarpet = new Car();
    magiccarpet.MakeModel = "2022 Tesla Throwrug";
    magiccarpet.Price = 210000;
    magiccarpet.Miles = 100000;

    Car magicschoolbus = new Car();
    magicschoolbus.MakeModel = "1991 Cheese Bus";
    magicschoolbus.Price = 1;
    magicschoolbus.Miles = 90000000;

    List<Car> Cars = new List<Car>() { bmw, chevy, magiccarpet, magicschoolbus};

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>(0);
    foreach(Car automobile in Cars)
    {
      if (automobile.WorthyPurchase(maxPrice))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }
    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
    }

  }
}
