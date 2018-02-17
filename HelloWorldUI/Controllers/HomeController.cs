using System;
using Microsoft.AspNetCore.Mvc;
using HelloWorldUI.Helpers;

namespace HelloWorldUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                ResponseHelper helper = new ResponseHelper();
                ViewData["Messages"] = helper.HandleResponseTypes();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return View();
        }       

    }
}
