using SilencerData.Client.Interfaces;
using SilencerData.Client.Models;
using SilencerData.Client.Models.SilencerData.Client.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace SilencerData.Client.Services
{
    public class SilencerDataService : ISilencerDataService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<SilencerDataService> _logger;

        public SilencerDataService(HttpClient httpClient, ILogger<SilencerDataService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<IEnumerable<Silencer>> GetSilencerDataAsync()
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                options.Converters.Add(new DecimalJsonConverter());
                options.Converters.Add(new NullableDecimalJsonConverter());

                var suppressors = await _httpClient.GetFromJsonAsync<IEnumerable<Silencer>>("data/silencerdata.json", options);
                return suppressors ?? Enumerable.Empty<Silencer>();
            }
            catch (HttpRequestException e)
            {
                _logger.LogError(e, "Error fetching silencer data");
                return Enumerable.Empty<Silencer>();
            }
            catch (JsonException e)
            {
                _logger.LogError(e, "Error deserializing silencer data");
                return Enumerable.Empty<Silencer>();
            }
        }
    }
}
