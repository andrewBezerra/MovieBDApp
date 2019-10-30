using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MovieDBApp.Services
{
    public class HttpRequestv2 : IHttpRequest
    {
        private static HttpClient httpClient = new HttpClient();
        private readonly JsonSerializerOptions _serializerSettings;

        public HttpRequestv2()
        {
            //_serializerSettings = new Jsonsettings
            //{
                     
            //    //ContractResolver = new CamelCasePropertyNamesContractResolver(),
                
            //    DateTimeZoneHandling = DateTimeZoneHandling.Utc,
            //    NullValueHandling = NullValueHandling.Ignore
            //};

            //_serializerSettings.Converters.Add(new StringEnumConverter());
        }
        public async Task<TResult> GetAsync<TResult>(string uri)
        {
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await httpClient.GetAsync(uri).ConfigureAwait(false);

            // await HandleResponse(response);

            StringBuilder serialized = new StringBuilder(await response.Content.ReadAsStringAsync());
          
            TResult result = await Task.Run(() => JsonSerializer.Deserialize<TResult>(serialized.ToString(), _serializerSettings));

            return result;
        }
    }
}
