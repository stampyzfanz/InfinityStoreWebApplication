using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using InfinityWebApplication.Util;

namespace InfinityWebApplication.Services
{
    public class LocationData
    {
        public int status { get; set; }
        public string? ip { get; set; }
        public string? city { get; set; }
        public string? region { get; set; }
        public string? country { get; set; }
        public string? loc { get; set; }
        public string? org { get; set; }
        public string? postal { get; set; }
        public string? timezone { get; set; }
        public string? error { get; set; }
    }

    public class LocationService : ILocationService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<LocationService> _logger;

        public LocationService(IHttpClientFactory httpClientFactory, ILogger<LocationService> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        public async Task<LocationData> getLocationData(string IPAddress)
        {
            // The name IPAdress is consistent with naming conventions in C#
            // https://github.com/dotnet/runtime/blob/main/src/libraries/System.Net.Primitives/src/System/Net/IPAddress.cs
            // If the webpage is loaded from a local server for development purposes, 
            // change ip address to a public ip address.
            if (IPAddress == "::1" || IPAddress == "127.0.0.1")
            {
                IPAddress = "129.78.110.124";
            }

            HttpClient httpClient = _httpClientFactory.CreateClient();
            // Create HTTP request
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(
                HttpMethod.Get, $"https://ipinfo.io/{IPAddress}?token=62841c358cd7de"
            )
            { };
            // Send HTTP request and wait for response
            HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using System.IO.Stream contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();
                // Try to deserialize the responce to LocationData object and 
                // provide error if its in the wrong format
                try
                {
                    LocationData locationData = (await JsonSerializer.DeserializeAsync<LocationData>(contentStream))!;

                    _logger.LogInformation(locationData.ToJsonString());
                    return locationData;
                }
                catch (JsonException e)
                {
                    _logger.LogError(e.ToString());
                    return new LocationData
                    {
                        error = "IPInfo provided data in wrong format.",
                        status = 500
                    };
                }
            }
            else
            {
                // IPInfo could not parse the query
                _logger.LogError($"IPInfo gave error message for the IP: {IPAddress}");
                return new LocationData
                {
                    error = "IPInfo couldn't parse IP address.",
                    status = 500
                };
            }
        }
    }

    public interface ILocationService
    {
        Task<LocationData> getLocationData(string IPAddress);
    }
}
