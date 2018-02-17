using System;

namespace HelloWorldUI.Helpers
{    
    public abstract class Message
    {
        private readonly string content;

        protected Message(string content)
        {
            if(String.IsNullOrEmpty(content))
            {
                throw new ArgumentException("Message not supplied");
            }

            this.content = content;
        }

        public string Content { get { return content; } }

        public abstract string WriteContent();
    }

}