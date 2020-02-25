using System;
using System.Collections.Generic;


public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
  public Car(string makeModel, int price, int miles)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
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
    Car bmw = new Car("1990 BMW Alpine", 110100, 4000);
    Car chevy = new Car("2019 Chevy Silverado", 200000, 130000);
    Car magiccarpet = new Car("2022 Tesla Magic Carpet", 210000, 100000);
    Car magicschoolbus = new Car("1991 Cheese Bus", 1, 90000000);











    List<Car> Cars = new List<Car>() {bmw, chevy, magiccarpet, magicschoolbus};

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
