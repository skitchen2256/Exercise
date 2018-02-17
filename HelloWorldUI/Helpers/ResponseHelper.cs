using System;
using System.IO;
using HelloWorldUI.Models;
using HelloWorldUI.Helpers;


namespace HelloWorldUI.Helpers
{
    public class ResponseHelper
    {
        public ViewModel HandleResponseTypes()
        {
            ApiHelper helper = new ApiHelper();
            AppSettings settings = new AppSettings();
            ViewModel vm = new ViewModel();

            string welcomeMessage = helper.GetWelcomeMessage();

            if (settings.OutputToFile)
            {
                vm.FileMessage = WriteContent(new FileMessage(welcomeMessage));
            }

            if (settings.OutputToView)
            {
                vm.ViewMessage = WriteContent(new ViewMessage(welcomeMessage));
            }

            if (settings.OutputToDatabase)
            {
                vm.DatabaseMessage = WriteContent(new DatabaseMessage(welcomeMessage));
            }

            return vm;

        }

        public string WriteContent(Message r)
        {
            string s = string.Empty;
            try
            {
                s = r.WriteContent();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return s;
        }

    }

}