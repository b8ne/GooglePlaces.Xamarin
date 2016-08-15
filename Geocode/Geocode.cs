using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GooglePlaces.Xamarin
{
	public class Geocode
	{
		[JsonProperty("results")]
		public List<GeocodeResult> results { get; set; }

		[JsonProperty("status")]
		public string status { get; set; }
	}
}