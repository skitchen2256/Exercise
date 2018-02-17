using System;
using Microsoft.EntityFrameworkCore;

namespace HelloWorldAPI.Models
{
    public class Welcome
    {
        public long Id { get; set; }
        public string WelcomeMessage { get; set; }
        public DateTime DateReceived { get; set; }
    }
    
    public class WelcomeContext : DbContext
    {
        public WelcomeContext(DbContextOptions<WelcomeContext> options) : base(options)
        {
        }

        public DbSet<Welcome> WelcomeMessages { get; set; }

    }
}