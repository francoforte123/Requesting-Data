using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requesting_Data
{
    public class RetriveUrl
    {
        public async Task<string> GetDescription(string url)
        {
            var httpClient= new HttpClient();
            var uri= new Uri(url);
            var response= await httpClient.GetAsync(uri);
            
            foreach(var header in  response.Headers)
            {
                Console.WriteLine(header.Key + "= " + string.Join(", ", header.Value));
            }

            var result= await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
