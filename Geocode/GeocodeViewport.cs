using System;
using Newtonsoft.Json;

namespace GooglePlaces.Xamarin
{
	public class GeocodeViewport
	{
		[JsonProperty("northeast")]
		public GeocodeNortheast northeast { get; set; }

		[JsonProperty("southwest")]
		public GeocodeSouthwest southwest { get; set; }
	}
}

