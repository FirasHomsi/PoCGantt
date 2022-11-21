using Microsoft.AspNetCore.Mvc;

namespace PoCGantt.Controllers
{
  public class GanttController : Controller
  {
    public IActionResult DataBinding()
    {
      return View();
    }
  }
}
