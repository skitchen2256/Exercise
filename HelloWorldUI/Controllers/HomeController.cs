using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorldUI.Models;
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
