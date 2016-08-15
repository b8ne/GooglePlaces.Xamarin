using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GooglePlaces.Xamarin
{
	public class GeocodeAddressComponent
	{
		[JsonProperty("long_name")]
		public string long_name { get; set; }

		[JsonProperty("short_name")]
		public string short_name { get; set; }

		[JsonProperty("types")]
		public List<string> types { get; set; }
	}
}

