using Microsoft.AspNetCore.Mvc;

namespace PlacesList.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return new ViewResult();
    }

  }
}
