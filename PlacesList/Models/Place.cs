using System.Collections.Generic;

namespace PlacesList.Models
{
  public class Place
  {
    private string _cityName;
    private string _journal;
    private string _dateTraveled;
    private string _traveledWith;
    private int _id;
    private static List<Place> _instances = new List<Place> {};

    public Place (string cityName, string journal, string dateTraveled, string traveledWith)
    {
      _cityName = cityName;
      _journal = journal;
      _dateTraveled = dateTraveled;
      _traveledWith = traveledWith;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetCityName()
    {
      return _cityName;
    }

    public string GetJournal()
    {
      return _journal;
    }

    public string GetDateTraveled()
    {
      return _dateTraveled;
    }

    public string GetTraveledWith()
    {
      return _traveledWith;
    }


    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public int GetId()
    {
      return _id;
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
