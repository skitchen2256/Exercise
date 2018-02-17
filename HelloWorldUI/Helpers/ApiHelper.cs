using System;
using System.Net.Http;

namespace HelloWorldUI.Helpers
{
    public class ApiHelper
    {
        public string GetWelcomeMessage()
        {
            string apiResponse = string.Empty;
            
            try
            {
                using(HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5001/");
                    client.DefaultRequestHeaders.Accept.Clear();

                    using (HttpResponseMessage response = client.GetAsync("api/welcome").Result)
                    {
                        using (HttpContent content = response.Content)
                        {
                            apiResponse = content.ReadAsStringAsync().Result;
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
 
            return apiResponse;           

        }


        public string WriteMessageToFile(string content)
        {
            return Post("api/file", content);   

        }

        public string WriteMessageToDatabase(string content)
        {
            return Post("api/database", content);                   

        }

        private string Post(string uri, string content)
        {
            string apiResponse = string.Empty;
            
            try
            {
                using(HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5001/");
                    client.DefaultRequestHeaders.Accept.Clear();

                    var stringContent = new StringContent("{ \"content\": \"" + content + "\" }", System.Text.Encoding.UTF8, "application/json");
                    using (HttpResponseMessage response = client.PostAsync(uri, stringContent).Result)
                    {
                        using (HttpContent resposeContent = response.Content)
                        {
                            apiResponse = resposeContent.ReadAsStringAsync().Result;
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 

            return apiResponse;  
        }

    }

}