using System;
using Microsoft.AspNetCore.Mvc;
namespace cardCom.Controllers
{
   public class HomeController : Controller
   {
      public IActionResult Index()
      {
         return View();
      }
   }
}