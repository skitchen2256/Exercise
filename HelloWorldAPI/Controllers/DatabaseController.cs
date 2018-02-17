using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using HelloWorldAPI.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;

namespace HelloWorldAPI.Controllers
{
    [Route("api/[controller]")]
    public class DatabaseController : Controller
    {  
        // Post api/database
        [HttpPost]
        public string WriteToDatabase([FromBody] Message m)
        {
            WelcomeContext wc = null;
            string response = string.Empty;
            
            try
            {
                DbContextOptionsBuilder<WelcomeContext> builder = new DbContextOptionsBuilder<WelcomeContext>();
                builder.UseInMemoryDatabase("Welcome");
                DbContextOptions<WelcomeContext> options = builder.Options;

                wc = new WelcomeContext(options);

                wc.WelcomeMessages.Add(
                    new Welcome {
                        WelcomeMessage = m.Content,
                        DateReceived = DateTime.Now
                    }
                );
        
                wc.SaveChanges();   

                response = wc.WelcomeMessages.OrderByDescending(i => i.Id)
                                    .Select(f => f.WelcomeMessage)
                                    .First().ToString();

            }
            catch (Exception ex)
            {
                response = ex.Message;
            }  
            finally
            {
                wc.Dispose();
            }

            return response;
        }
           
    }
 
}
 