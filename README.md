# GooglePlaces.Xamarin
Lightweight C# wrapper for Google Places API.
## Installation
```csharp
// Install release version
Install-Package GooglePlaces.Xamarin

```

## Supported frameworks
* .NET 4.5+
* ASP.Net Core 1.0
* Xamarin Android
* Xamarin iOS 
* Xamarin iOS Classic
* Windows 8

## Usage

### Setup

You will need your own valid Google API and project setup via the Google Developers Console.

### Autocomplete

```csharp
PlacesAutocomplete autocompleteObject = new PlacesAutocomplete("YOUR API KEY");
Predictions predictions = await autocompleteObject.GetGoogleAutoComplete("SEARCH INPUT");
foreach (var prediction in predictions.predictions) {
    var description = prediction.Description;
	var place_id = prediction.Place_id;
	var id = prediction.Id;
	var reference = prediction.Reference;
	var terms = prediction.Terms;
	var type = prediction.Types;
}
```
View prediction definitions at [Google Places API](https://developers.google.com/places/web-service/autocomplete#place_autocomplete_responses)
