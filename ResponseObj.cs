using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Observer data
    /// </summary>
    public class Observer
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

    }
    /// <summary>
    /// RightAscension data
    /// </summary>
    public class RightAscension
    {
        [JsonProperty("hours")]
        public int Hours { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("seconds")]
        public int Seconds { get; set; }

    }
    /// <summary>
    /// Declination data
    /// </summary>
    public class Declination
    {
        [JsonProperty("degrees")]
        public int Degrees { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("seconds")]
        public int Seconds { get; set; }

    }
    /// <summary>
    /// Distance data
    /// </summary>
    public class Distance
    {
        [JsonProperty("km")]
        public double Km { get; set; }

        [JsonProperty("lightTravelSeconds")]
        public double LightTravelSeconds { get; set; }

        [JsonProperty("astronomicalUnits")]
        public double AstronomicalUnits { get; set; }

    }
    /// <summary>
    /// SiderealTime data
    /// </summary>
    public class SiderealTime
    {
        [JsonProperty("hours")]
        public int Hours { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("seconds")]
        public int Seconds { get; set; }

    }
    /// <summary>
    /// HourAngle data
    /// </summary>
    public class HourAngle
    {
        [JsonProperty("hours")]
        public int Hours { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("seconds")]
        public int Seconds { get; set; }

    }
    /// <summary>
    /// Vectors data
    /// </summary>
    public class Vectors
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }

        [JsonProperty("z")]
        public double Z { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("planet")]
        public string Planet { get; set; }

        [JsonProperty("isBelowHorizon")]
        public bool IsBelowHorizon { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("observer")]
        public Observer Observer { get; set; }

        [JsonProperty("rightAscension")]
        public RightAscension RightAscension { get; set; }

        [JsonProperty("declination")]
        public Declination Declination { get; set; }

        [JsonProperty("distance")]
        public Distance Distance { get; set; }

        [JsonProperty("siderealTime")]
        public SiderealTime SiderealTime { get; set; }

        [JsonProperty("hourAngle")]
        public HourAngle HourAngle { get; set; }

        [JsonProperty("vectors")]
        public Vectors Vectors { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
