using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// ColorPalette data
    /// </summary>
    public class ColorPalette
    {
        [JsonProperty("hex")]
        public string Hex { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("hue")]
        public int Hue { get; set; }

        [JsonProperty("variation")]
        public string Variation { get; set; }

        [JsonProperty("colorPalette")]
        public ColorPalette[] ColorPalette { get; set; }

        [JsonProperty("colorPaletteRaw")]
        public string[] ColorPaletteRaw { get; set; }

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
