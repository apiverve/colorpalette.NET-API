using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class colorPalette
{
    [JsonProperty("hex")]
    public string hex { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }

}

public class data
{
    [JsonProperty("source")]
    public string source { get; set; }

    [JsonProperty("hue")]
    public int hue { get; set; }

    [JsonProperty("variation")]
    public string variation { get; set; }

    [JsonProperty("colorPalette")]
    public colorPalette[] colorPalette { get; set; }

    [JsonProperty("colorPaletteRaw")]
    public string[] colorPaletteRaw { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
