using System;
namespace GooglePlaces.Xamarin
{
	/// <summary>
	/// The auth config. 
	/// </summary>
	public class PlacesConfig
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PlacesConfig"/> class.
		/// </summary>
		/// <param name="apiKey"> The google web-service api key. </param>
		public PlacesConfig(string apiKey)
		{
			this.ApiKey = apiKey;
		}

		/// <summary>
		/// Gets or sets the api key of your Firebase app. 
		/// </summary>
		public string ApiKey
		{
			get;
			set;
		}
	}
}

