using System.Text.Json;

namespace Catboys;

public static class Http
{
    private static readonly string _baseUrl = "https://api.catboys.com";
    private static readonly HttpClient _httpClient = new HttpClient();

    public static async Task<Dictionary<string, string>> GetEndpoint(string endpoint)
    {
		// This is unorthodox
        string url = $"{_baseUrl}{endpoint}";
        HttpResponseMessage result = await _httpClient.GetAsync(url);

        // Ensuring the request is successful
        result.EnsureSuccessStatusCode();

        // Deserializing result into a dictionary
        string content = await result.Content.ReadAsStringAsync();
        Dictionary<string, string>? resDict =
            JsonSerializer.Deserialize<Dictionary<string, string>>(content);

		return resDict ?? throw new NullReferenceException("The API returned nothing.");
	}
}
