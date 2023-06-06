using Newtonsoft.Json;
using StoicQuotes;



public class Program
{
    public static async Task Main()
    {

        HttpClient client = new HttpClient();


        HttpResponseMessage response = client.GetAsync("https://api.themotivate365.com/stoic-quote").Result;

        if (response.IsSuccessStatusCode)
        {
            string jsonObject = await response.Content.ReadAsStringAsync();


            Data data = JsonConvert.DeserializeObject<Data>(jsonObject);


            Console.WriteLine($"Author: {data.Author}" + ", " + $"Quote: {data.Quote}");

        }
        else
        {
            Console.WriteLine("Oops. Try again maybe?");
        }
    }
}
