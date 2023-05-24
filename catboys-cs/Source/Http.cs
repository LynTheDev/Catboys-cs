using System.Text.Json;

namespace Catboys;

/// <summary>
/// Represents the Http class used for calling the API
/// </summary>
public static class Http
{
    private static readonly string _baseUrl = "https://api.catboys.com";
    private static readonly HttpClient _httpClient = new HttpClient();

	/// <summary>
	/// Calls the api.
	/// </summary>
	/// <param name="endpoint">The endpoint to call</param>
	/// <returns>Dictionary composed of the HTTP response</returns>
	/// <exception cref="NullReferenceException">If the api returns nothing.</exception>
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
