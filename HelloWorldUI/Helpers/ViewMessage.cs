namespace HelloWorldUI.Helpers
{
    public class ViewMessage : Message
    {
        public ViewMessage(string content) : base(content)
        {
        }

        public override string WriteContent()
        {
            return $"Welcome message: {this.Content}";   
        }
    }

}