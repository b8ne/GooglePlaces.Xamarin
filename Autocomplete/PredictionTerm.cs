using System;
using Newtonsoft.Json;

namespace GooglePlaces.Xamarin
{
	/// <summary>
	/// The Autocomplete Prediction Term
	/// </summary>
	public class PredictionTerm
	{
		[JsonProperty("offset")]
		public int Offset { get; set; }

		[JsonProperty("value")]
		public string Value { get; set; }
	}
}