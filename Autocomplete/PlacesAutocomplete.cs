namespace GooglePlaces.Xamarin
{
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using Newtonsoft.Json;

	/// <summary>
	/// Retrieves autocomplete address predictions
	/// </summary>
	public class PlacesAutocomplete
	{
		private readonly PlacesHttpProvider httpProvider;
		private readonly PlacesConfig authConfig;

		private const string GooglePlacesUrl = "https://maps.googleapis.com/maps/api/place/autocomplete/json";

		/// <summary>
		/// Initializes a new instance of the <see cref="PlacesAutocomplete"/> class.
		/// </summary>
		/// <param name="apikey"> The google api key. </param>
		public PlacesAutocomplete(string apikey)
		{
			this.authConfig = new PlacesConfig(apikey);
			this.httpProvider = new PlacesHttpProvider(authConfig);
		}

		/// <summary>
		/// Creates post body content for an autocomplete request
		/// </summary>
		/// <param name="input"> The search params. </param>
		public async Task<Predictions> GetAutocomplete(string input)
		{
			string content = "input=" + input + "&components=country:au";
			string responseData = await httpProvider.FetchPostContentAsync(GooglePlacesUrl, content).ConfigureAwait(false);

			var predictions = JsonConvert.DeserializeObject<Predictions>(responseData);

			return predictions;
		}
	}
}

