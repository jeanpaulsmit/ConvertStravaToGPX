
using Newtonsoft.Json;

namespace Didago.ConvertStravaToGPX;

internal class Program
{
    static void Main(string[] args)
    {
        // https://www.strava.com/activities/7247917223/streams?stream_types%5B%5D=latlng&_=1654379108791
        // https://www.strava.com/activities/7247917223/streams?stream_types%5B%5D=time&stream_types%5B%5D=watts_calc&stream_types%5B%5D=altitude&stream_types%5B%5D=heartrate&stream_types%5B%5D=cadence&stream_types%5B%5D=temp&stream_types%5B%5D=distance&stream_types%5B%5D=grade_smooth&_=1654379108792

        var gpxName = "Retourtje Rhenen UHR";
        var gpxLink = "https://www.strava.com/activities/7247917223";

        var latlngData = JsonConvert.DeserializeObject<Coordinates>(File.ReadAllText("Strava-data-latlng.json"));
        var altitudeData = JsonConvert.DeserializeObject<CoordinatesMetadata>(File.ReadAllText("Strava-data-altitude.json"));

        System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(gpx));
        System.IO.StreamReader file = new System.IO.StreamReader("GPX-Template.xml");
        gpx data = (gpx)reader.Deserialize(file);
        data.metadata.link.href = gpxLink;
        data.trk.name = gpxName;
        data.trk.trkseg = new gpxTrkTrkpt[latlngData.latlng.Count()];

        for(int i=0; i<latlngData.latlng.Count();i++)
        {
            data.trk.trkseg[i] = new gpxTrkTrkpt()
            {
                lat = latlngData.latlng[i][0],
                lon = latlngData.latlng[i][1],
                ele = altitudeData.altitude[i],
                time = DateTime.UtcNow
            };
        }

        var writer = new System.Xml.Serialization.XmlSerializer(typeof(gpx));
        var wfile = new System.IO.StreamWriter($"GPX-{gpxName}.gpx");
        writer.Serialize(wfile, data);
        wfile.Close();

        file.Close();
    }
}