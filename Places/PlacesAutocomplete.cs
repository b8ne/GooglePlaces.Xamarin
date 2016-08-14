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
		public async Task<List<PlacesObject>> GetGoogleAutoComplete(string input)
		{
			string content = "input=" + input + "&components=country:au";
			string responseData = await httpProvider.FetchPostContentAsync(content).ConfigureAwait(false);

			var predictions = JsonConvert.DeserializeObject<List<PlacesObject>>(responseData);

			return predictions;
		}
	}
}

