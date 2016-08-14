namespace GooglePlaces.Xamarin
{
	using System.Threading.Tasks;
	using Newtonsoft.Json.Linq;

	public class PlacesAutocomplete
	{
		private PlacesHttpProvider httpProvider;

		public PlacesAutocomplete()
		{
			this.httpProvider = new PlacesHttpProvider();
		}

		public async Task<JObject> GetGoogleAutoComplete(string input)
		{
			string content = "input=" + input + "&components=country:au";
			dynamic responseData = await httpProvider.FetchPostContentAsync(content).ConfigureAwait(false);
			JObject predictions = responseData["predictions"];

			return predictions;
		}
	}
}

