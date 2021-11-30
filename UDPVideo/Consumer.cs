using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using JsonConverter = System.Text.Json.Serialization.JsonConverter;

namespace UDPVideo
{
    class Consumer
    {
        public static async Task<TOut> PostToReceiver<TIn, TOut>(string uri, TIn item)
        {
            using HttpClient client = new HttpClient();

            string VideoObject = JsonConvert.SerializeObject(item);

            StringContent requestContent = new StringContent(VideoObject, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(uri, requestContent);

            string responseContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                TOut data = JsonConvert.DeserializeObject<TOut>(responseContent);
                return data;


            }

            throw new KeyNotFoundException($"status code = {response.StatusCode} message={responseContent}");
        }

    }
}
