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
        private IEnumerable<Silencer>? _cachedData;

        public SilencerDataService(HttpClient httpClient, ILogger<SilencerDataService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<IEnumerable<Silencer>> GetSilencerDataAsync()
        {
            if (_cachedData != null)
            {
                return _cachedData;
            }

            try
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                options.Converters.Add(new DecimalJsonConverter());
                options.Converters.Add(new NullableDecimalJsonConverter());

                _cachedData = await _httpClient.GetFromJsonAsync<IEnumerable<Silencer>>("data/silencerdata.json", options);
                return _cachedData ?? Enumerable.Empty<Silencer>();
            }
            catch (JsonException e)
            {
                _logger.LogError(e, "Error deserializing silencer data");
                return Enumerable.Empty<Silencer>();
            }
        }
    }
}
