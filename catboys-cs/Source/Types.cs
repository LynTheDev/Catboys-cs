namespace Catboys;

/// <summary>
/// An image of a Catboy from the catboys API.
/// </summary>
public struct CatboyImage
{
	/// <summary>
	/// The URL to the image, generally served by the catboys CDN.
	/// </summary>
	public string URL;

	/// <summary>
	/// The name of the artist. May be "unknown"
	/// </summary>
	public string Artist;

	/// <summary>
	/// The URL linking to the artist of the given image. May be "none".
	/// </summary>
	public string ArtistURL;

	/// <summary>
	/// The URL linking to the source of the given image. May be "none".
	/// </summary>
	public string Source;
};

/// <summary>
/// A representation of a text response from the catboys API.
/// </summary>
public struct CatboyResponse
{
	/// <summary>
	/// The response, in plaintext English.
	/// </summary>
	public string Response;

	/// <summary>
	/// The URL linking to an image related to the response.
	/// </summary>
	public string URL;
};
