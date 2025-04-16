Planet Positions API
============

Planet Positions is a simple tool for getting the position of planets in the solar system. It returns the position of planets in the solar system.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [Planet Positions API](https://apiverve.com/marketplace/api/planetpositions)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.PlanetPositions
```

Using the Package Manager:
```
nuget install APIVerve.API.PlanetPositions
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.PlanetPositions
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages..
4. Click on the Browse tab and search for "APIVerve.API.PlanetPositions".
5. Click on the APIVerve.API.PlanetPositions package, click Install.


---

## Configuration

Before using the planetpositions API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The Planet Positions API documentation is found here: [https://docs.apiverve.com/api/planetpositions](https://docs.apiverve.com/api/planetpositions).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
Planet Positions API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new PlanetPositionsAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new PlanetPositionsQueryOptions {
  planet = "Moon",
  date = "2025-04-15 10:37:00",
  lat = 37.7749,
  lon = -122.4194,
  alt = 52
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "planet": "Moon",
    "isBelowHorizon": false,
    "date": "2025-04-15T10:37:00.000Z",
    "observer": {
      "latitude": 37.7749,
      "longitude": -122.4194
    },
    "rightAscension": {
      "hours": 15,
      "minutes": 13,
      "seconds": 11
    },
    "declination": {
      "degrees": -23,
      "minutes": 10,
      "seconds": 56
    },
    "distance": {
      "km": 402457.36,
      "lightTravelSeconds": 1.342,
      "astronomicalUnits": 0.003
    },
    "siderealTime": {
      "hours": 16,
      "minutes": 2,
      "seconds": 42
    },
    "hourAngle": {
      "hours": 0,
      "minutes": 49,
      "seconds": 31
    },
    "vectors": {
      "x": -0.0016452947779903913,
      "y": -0.0018463324771434563,
      "z": -0.0010590407236111441
    }
  },
  "code": 200
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2025 APIVerve, and EvlarSoft LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.