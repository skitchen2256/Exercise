using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using HelloWorldAPI.Models;

namespace HelloWorldAPI.Controllers
{
    [Route("api/[controller]")]
    public class FileController : Controller
    {
        // Post api/file
        [HttpPost]
        public string WriteToFile([FromBody] Message m)
        {
            string file = $"{System.AppContext.BaseDirectory}{"WelcomeMessage.txt"}";
            System.IO.File.WriteAllText(file, $"{DateTime.Now} - {m.Content}");

            return $"Message logged to API file: {file}";
            
        }
           
    }
 
}
 
      
      
    