using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    private string _make;
    private string _model;
    private int _year;
    private string _color;
    private static List<Car> _instances = new List<Car> {};

    //this is the constructor
    public Car (string make, string model, int year, string color)
    {
      _make = make;
      _model = model;
      _year = year;
      _color = color;
    }


    public string GetMake()
    {
      return _make;
    }

    public string GetModel()
    {
      return _model;
    }

    public int GetYear()
    {
      return _year;
    }

    public string GetColor()
    {
      return _color;
    }

    // public void SetDescription(string newDescription, string newMake, string newModel, int newYear, string newColor)
    // {
    //   _description = newDescription;
    //   _make = newMake;
    //   _model = newModel;
    //   _year = newYear;
    //   _color = newColor;
    // }
    public static List<Car> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
