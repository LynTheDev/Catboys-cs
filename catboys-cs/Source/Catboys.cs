namespace Catboys;

public class CatboysAPI
{
	/// <summary>
	///		Calls the /img API endpoint.
	/// </summary>
	/// <param name="getAll">
	///		When set to true, result includes all the fields from the HTTP response.
	/// </param>
	/// <returns>Dictionary composed of the URL and artist</returns>
	/// <remarks>
	///		Returns the entire HTTP response if getAll is set to true. Use the <see href="https://catboys.com/api">API</see> for reference.
	/// </remarks>
	public static async Task<Dictionary<string, string>> Img(bool getAll=false)
    {
        Dictionary<string, string> httpResult = await Http.GetEndpoint("/img");

        if (getAll)
            return httpResult;

        // We simplify the dictionary if the user doesn't want all of it
        return new Dictionary<string, string>()
        {
            {"url", httpResult["url"]},
            {"artist", httpResult["artist"]}
        };
    }

	/// <summary>
	///		Calls /8ball API endpoint.
	/// </summary>
	/// <remarks>
	///		See the <see href="https://catboys.com/api">API</see> for reference
	/// </remarks>
	/// <returns>Dictionary composed from the HTTP result.</returns>
	public static async Task<Dictionary<string, string>> EightBall()
		=> await Http.GetEndpoint("/8ball");

	/// <summary>
	///		Calls the /dice API endpoint
	/// </summary>
	/// <remarks>
	///		See the <see href="https://catboys.com/api">API</see> for reference
	/// </remarks>
	/// <returns>Dictionary composed from the HTTP result.</returns>
	public static async Task<Dictionary<string, string>> Dice()
		=> await Http.GetEndpoint("/dice");

	/// <summary>
	///		Calls the /baka API endpoint
	/// </summary>
	/// <remarks>
	///		See the <see href="https://catboys.com/api">API</see> for reference
	/// </remarks>
	/// <returns>Dictionary composed from the HTTP result.</returns>
	public static async Task<Dictionary<string, string>> Baka()
		=> await Http.GetEndpoint("/baka");
}
