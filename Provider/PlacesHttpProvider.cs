using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GooglePlaces.Xamarin
{
	/// <summary>
	/// The HTTP connection provider
	/// </summary>
	public class PlacesHttpProvider
	{
		private readonly HttpClient client;
		private readonly PlacesConfig authConfig;

		/// <summary>
		/// Initializes a new instance of the <see cref="PlacesHttpProvider"/> class.
		/// </summary>
		/// <param name="config"> A PlacesConfig instance. </param>
		public PlacesHttpProvider(PlacesConfig config)
		{
			this.client = new HttpClient();
			this.authConfig = config;
		}

		/// <summary>
		/// Makes post request to Google API
		/// </summary>
		/// <param name="postContent"> The post body. </param>
		public async Task<string> FetchPostContentAsync(string url, string postContent)
		{
			string uri = url + "?" + postContent + "&key=" + this.authConfig.ApiKey;
			var response = await this.client.PostAsync(new Uri(uri), new StringContent("")).ConfigureAwait(false);
			var responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

			response.EnsureSuccessStatusCode();

			return responseData;
		}
	}
}

