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

1. Log in to [Google Developer Console](https://console.developers.google.com)

2. Create a new project.

3. Add a "Browser" API Key under Credentials.

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


### Geocode
```csharp
PlacesGeocode geocodeObject = new PlacesGeocode("YOUR API KEY");
Geocode response = await geocodeObject.GetGeocode("ADDRESS");
foreach (var results in response.results) {
	var location = results.geometry.location;
	var lat = location.lat;
	var lng = location.lng;
	...
}
```
