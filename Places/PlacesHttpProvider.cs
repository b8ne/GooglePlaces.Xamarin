using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GooglePlaces.Xamarin
{
	public class PlacesHttpProvider
	{
		private readonly HttpClient client;
		private const string GooglePlacesAPI = "AIzaSyAgmGOT-0aURrQZ8vmvh1xNgRukpMhIcgU";
		private const string GooglePlacesUrl = "https://maps.googleapis.com/maps/api/place/autocomplete/json";

		public PlacesHttpProvider()
		{
			this.client = new HttpClient();
		}

		public async Task<JObject> FetchPostContentAsync(string postContent)
		{
			string uri = GooglePlacesUrl + "?" + postContent + "&key=" + GooglePlacesAPI;
			var response = await this.client.PostAsync(new Uri(uri), new StringContent("")).ConfigureAwait(false);
			var responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

			response.EnsureSuccessStatusCode();

			JObject returnData = JObject.Parse(responseData);

			return returnData;
		}
	}
}

