using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PlacesList.Models;

namespace PlacesList.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityName, string journal, string dateTraveled, string traveledWith)
    {
      if(cityName != null || journal != null || dateTraveled != null || traveledWith != null)
      {
        Place myPlace = new Place(cityName, journal, dateTraveled, traveledWith);

      }
      return RedirectToAction("Index");
    }

    [HttpPost("/places/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return View();
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      Place place = Place.Find(id);
      return View(place);
    }
  }
}
