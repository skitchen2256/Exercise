using System;
using System.IO;

namespace HelloWorldUI.Helpers
{
    public class FileMessage : Message
    {
        public FileMessage(string content) : base(content)
        {
        }

        public override string WriteContent()
        {                  
            ApiHelper helper = new ApiHelper();
            return helper.WriteMessageToFile(this.Content);

        }
    }

}