using System;
using Newtonsoft.Json;

namespace GooglePlaces.Xamarin
{
	/// <summary>
	/// The Autocomplete Prediction
	/// </summary>
	public class PlacesObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PlacesObject"/> class.
		/// </summary>
		internal PlacesObject()
		{
		}

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("place_id")]
		public string Place_id { get; set; }

		[JsonProperty("reference")]
		public string Reference { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("terms")]
		public Array Terms { get; set; }

		[JsonProperty("types")]
		public Array Types { get; set; }
	}
}

