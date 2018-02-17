using System;
using System.IO;
using HelloWorldUI.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelloWorldUI.Helpers
{
    public class DatabaseMessage : Message
    {

        public DatabaseMessage(string content) : base(content)
        {   
        }  

        public override string WriteContent()
        {
            ApiHelper helper = new ApiHelper();
            return helper.WriteMessageToDatabase(this.Content);

        }
    }

}