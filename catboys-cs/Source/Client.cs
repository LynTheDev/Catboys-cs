using System.Text.Json;

namespace Catboys;

class Client
{
    private readonly string _baseUrl = "https://api.catboys.com";
    private readonly HttpClient _httpClient = new HttpClient();

    public async Task<Dictionary<string, string>> GetEndpoint(string endpoint)
    {
        HttpResponseMessage result = await _httpClient.GetAsync($"{_baseUrl}{endpoint}");

        // Ensuring the request is successful
        result.EnsureSuccessStatusCode();

        // Deserializing result into a dictionary
        string content = await result.Content.ReadAsStringAsync();
        Dictionary<string, string>? resDict =
            JsonSerializer.Deserialize<Dictionary<string, string>>(content);

		return resDict ?? throw new NullReferenceException("Received no data");
	}
}
