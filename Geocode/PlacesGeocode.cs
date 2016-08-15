using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GooglePlaces.Xamarin
{
	public class PlacesGeocode
	{
		private readonly PlacesHttpProvider httpProvider;
		private readonly PlacesConfig authConfig;

		private const string GooglePlacesUrl = "https://maps.googleapis.com/maps/api/geocode/json";

		public PlacesGeocode(string apikey)
		{
			this.authConfig = new PlacesConfig(apikey);
			this.httpProvider = new PlacesHttpProvider(authConfig);
		}

		/// <summary>
		/// Creates post body content for an geocode request
		/// </summary>
		/// <param name="input"> The search params. </param>
		public async Task<Geocode> GetGeocode(string input)
		{
			string content = "address=" + input;
			string responseData = await httpProvider.FetchPostContentAsync(GooglePlacesUrl, content).ConfigureAwait(false);

			var geocode = JsonConvert.DeserializeObject<Geocode>(responseData);

			return geocode;
		}
	}
}

