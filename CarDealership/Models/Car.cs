namespace CarDealership.Models
{
  
public class Car
  {
    // Variable declarations
    private string _makeModel;
    private int _price;
    private int _miles;

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
    Public Car (string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      
    }
  }
}