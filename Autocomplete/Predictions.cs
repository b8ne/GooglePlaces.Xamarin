using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GooglePlaces.Xamarin
{
	/// <summary>
	/// The Autocomplete Prediction Collection
	/// </summary>
	public class Predictions
	{
		[JsonProperty("status")]
		public string status { get; set; }

		[JsonProperty("predictions")]
		public List<Prediction> predictions { get; set; }
	}
}

