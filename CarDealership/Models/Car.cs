using System.Collections.Generic;

namespace CarDealership.Models
{
  
public class Car
  {
    // Variable declarations
    private string _makeModel;
    private int _price;
    private int _miles;

    private static List<Car> _instances = new List<Car> {};

    // Getters
    public string GetMakeModel ()
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

    // Car constructor
    public Car(string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;

      _instances.Add(this);
      
    }

    public static List<Car> GetAll ()
    {
      return _instances;
    }
  }
}