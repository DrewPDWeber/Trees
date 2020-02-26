Notes :
Geo JSON is a standardized JSON structure for geographical data ex.

{
  "Id": 1,
  "Name": "My first Tree",
  "Species": "Potato",
  "GeoType": {
    "Type": 2,
    "Values": {
      "type": "FeatureCollection",
      "features": [
        {
          "type": "Feature",
          "geometry": {
            "type": "Polygon",
            "coordinates": [
              [
                [
                  39.4116761,
                  20.236237
                ],
                [
                  39.4115249,
                  20.2363602
                ],
                [
                  39.4110652,
                  20.2365152
                ],
                [
                  39.4104468,
                  20.2364942
                ],
                [
                  39.4116761,
                  20.236237
                ]
              ]
            ]
          },
          "properties": {}
        }
      ]
    }
  }
}


Due to unities build in JSON decoders short comings it is unable to process two dimensional arrays : https://answers.unity.com/questions/1513741/reading-in-json-data-using-jsonutility-c.html

We will be using a.net JSON decoder called JSON.net the 3rd party unity lib is available : https://assetstore.unity.com/packages/tools/input-management/json-net-for-unity-11347

Due to switching to JSON.net we are able to use the .Net libary called GeoJSON.net : https://github.com/GeoJSON-Net/GeoJSON.Net