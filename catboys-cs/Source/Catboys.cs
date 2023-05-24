namespace Catboys;

/// <summary>
/// Main class for the catboys API wrapper.
/// </summary>
public class CatboysAPI
{
	private static Client client = new Client();

	private static async Task<CatboyResponse> getGenericResponse(string endpoint)
	{
		Dictionary<string, string> httpResult = await client.GetEndpoint(endpoint);

		return new CatboyResponse { Response = httpResult["response"], URL = httpResult["url"] };
	}

	/// <summary>
	///	Retrieves an image of a catboy.
	/// </summary>
	/// <remarks>
	///	See the <see href="https://catboys.com/api">API</see> for reference.
	/// </remarks>
	public static async Task<CatboyImage> GetImage()
    {
        Dictionary<string, string> httpResult = await client.GetEndpoint("/img");

		return new CatboyImage { URL = httpResult["url"], Artist = httpResult["artist"], ArtistURL = httpResult["artist_url"], Source = httpResult["source_url"] };
    }

	/// <summary>
	///	Asks the magic 8 ball for its thoughts.
	/// </summary>
	/// <remarks>
	///	See the <see href="https://catboys.com/api">API</see> for reference.
	/// </remarks>
	public static async Task<CatboyResponse> Ask8Ball() => await getGenericResponse("/8ball");

	/// <summary>
	///	Rolls a dice.
	/// </summary>
	/// <remarks>
	///		See the <see href="https://catboys.com/api">API</see> for reference.
	/// </remarks>
	public static async Task<CatboyResponse> RollDice() => await getGenericResponse("/dice");

	/// <summary>
	///	Calls someone a Baka.
	/// Note that the artist URL is always empty.
	/// </summary>
	/// <remarks>
	///	See the <see href="https://catboys.com/api">API</see> for reference.
	/// </remarks>
	public static async Task<CatboyImage> GetBaka()
	{
        Dictionary<string, string> httpResult = await client.GetEndpoint("/baka");

		return new CatboyImage { URL = httpResult["url"], Artist = "unknown", ArtistURL = "none", Source = "none" };
    }
}
