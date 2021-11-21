using System.Text.Json.Serialization;

namespace DataReader.Interface
{
    public class WeatherData
    {
        public class Rootobject
        {
            [JsonPropertyName("lat")]
            public float? Lat { get; set; }

            [JsonPropertyName("lon")]
            public float? Lon { get; set; }

            [JsonPropertyName("timezone")]
            public string? Timezone { get; set; }

            [JsonPropertyName("timezone_offset")]
            public int? Timezone_offset { get; set; }

            [JsonPropertyName("current")]
            public Current? Current { get; set; }
        }

        public class Current
        {
            [JsonPropertyName("dt")]
            public int? Dt { get; set; }

            [JsonPropertyName("sunrise")]
            public int? Sunrise { get; set; }

            [JsonPropertyName("sunset")]
            public int? Sunset { get; set; }

            [JsonPropertyName("temp")]
            public float? Temp { get; set; }

            [JsonPropertyName("feels_like")]
            public float? Feels_like { get; set; }

            [JsonPropertyName("pressure")]
            public int? Pressure { get; set; }

            [JsonPropertyName("humidity")]
            public int? Humidity { get; set; }

            [JsonPropertyName("dew_point")]
            public float? Dew_point { get; set; }

            [JsonPropertyName("uvi")]
            public float? Uvi { get; set; }

            [JsonPropertyName("clouds")]
            public int? Clouds { get; set; }

            [JsonPropertyName("visibility")]
            public int? Visibility { get; set; }

            [JsonPropertyName("qind_speed")]
            public int? Wind_speed { get; set; }

            [JsonPropertyName("qind_deg")]
            public int? Wind_deg { get; set; }

            [JsonPropertyName("Weather")]
            public Weather[]? Weather { get; set; }

            [JsonPropertyName("rain")]
            public Rain? Rain { get; set; }
        }

        public class Rain
        {
            [JsonPropertyName("1h")]
            public float? OneHour { get; set; }
        }

        public class Weather
        {
            [JsonPropertyName("id")]
            public int? Id { get; set; }

            [JsonPropertyName("main")]
            public string? Main { get; set; }

            [JsonPropertyName("description")]
            public string? Description { get; set; }

            [JsonPropertyName("icon")]
            public string? Icon { get; set; }
        }
    }
}

