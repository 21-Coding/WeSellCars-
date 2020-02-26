using System;

namespace Dealership.Model
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private string _message;
    private string _carColor;
    private string _doors;
    private bool _gps;
    public Car(string makeModel, int price, int miles, string message, string carColor, string doors, bool gps)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _message = message;
      _carColor = carColor;
      _doors = doors;
      _gps = gps;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public string GetMessage()
    {
      return _message;
    }
    public bool WorthyMiles(int maxMiles)
    {
      return (_miles < maxMiles);
    }

    public bool WorthyPurchase(int maxPrice)
    {
      return (_price < maxPrice);
    }
    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    public string GetCarColor()
    {
      return _carColor;
    }
    public string GetDoors()
    {
      return _doors;
    }
    public bool GetGPS()
    {
      return _gps;
    }
  }


}
