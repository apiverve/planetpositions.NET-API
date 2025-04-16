using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class observer
{
    [JsonProperty("latitude")]
    public double latitude { get; set; }

    [JsonProperty("longitude")]
    public double longitude { get; set; }

}

public class rightAscension
{
    [JsonProperty("hours")]
    public int hours { get; set; }

    [JsonProperty("minutes")]
    public int minutes { get; set; }

    [JsonProperty("seconds")]
    public int seconds { get; set; }

}

public class declination
{
    [JsonProperty("degrees")]
    public int degrees { get; set; }

    [JsonProperty("minutes")]
    public int minutes { get; set; }

    [JsonProperty("seconds")]
    public int seconds { get; set; }

}

public class distance
{
    [JsonProperty("km")]
    public double km { get; set; }

    [JsonProperty("lightTravelSeconds")]
    public double lightTravelSeconds { get; set; }

    [JsonProperty("astronomicalUnits")]
    public double astronomicalUnits { get; set; }

}

public class siderealTime
{
    [JsonProperty("hours")]
    public int hours { get; set; }

    [JsonProperty("minutes")]
    public int minutes { get; set; }

    [JsonProperty("seconds")]
    public int seconds { get; set; }

}

public class hourAngle
{
    [JsonProperty("hours")]
    public int hours { get; set; }

    [JsonProperty("minutes")]
    public int minutes { get; set; }

    [JsonProperty("seconds")]
    public int seconds { get; set; }

}

public class vectors
{
    [JsonProperty("x")]
    public double x { get; set; }

    [JsonProperty("y")]
    public double y { get; set; }

    [JsonProperty("z")]
    public double z { get; set; }

}

public class data
{
    [JsonProperty("planet")]
    public string planet { get; set; }

    [JsonProperty("isBelowHorizon")]
    public bool isBelowHorizon { get; set; }

    [JsonProperty("date")]
    public DateTime date { get; set; }

    [JsonProperty("observer")]
    public observer observer { get; set; }

    [JsonProperty("rightAscension")]
    public rightAscension rightAscension { get; set; }

    [JsonProperty("declination")]
    public declination declination { get; set; }

    [JsonProperty("distance")]
    public distance distance { get; set; }

    [JsonProperty("siderealTime")]
    public siderealTime siderealTime { get; set; }

    [JsonProperty("hourAngle")]
    public hourAngle hourAngle { get; set; }

    [JsonProperty("vectors")]
    public vectors vectors { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
