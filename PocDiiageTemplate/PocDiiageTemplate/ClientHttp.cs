using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PocDiiageTemplate
{
    public class ClientHttp 
    {
        HttpClient client;
        public ClientHttp()
        {
            client = new HttpClient();
        }
        public async Task<ObservableCollection<Beer>> GetBeerAsync()
        {
            try
            {
               
                HttpResponseMessage response = await client.GetAsync("https://api.punkapi.com/v2/beers?ids=1|3|5");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);
                return JsonConvert.DeserializeObject<ObservableCollection<Beer>>(responseBody);
            }
            catch (HttpRequestException e)
            {
                return new ObservableCollection<Beer>();
            }
        }
    }
}
