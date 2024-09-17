namespace SilencerData.Client.Models
{
    using global::SilencerData.Client.Services;
    using System.Text.Json.Serialization;

    namespace SilencerData.Client.Models
    {
        public class Silencer
        {
            public string Manufacturer { get; set; } = string.Empty;
            public string Model { get; set; } = string.Empty;

            [JsonConverter(typeof(DecimalJsonConverter))]
            public decimal MSRP { get; set; }

            [JsonConverter(typeof(DecimalJsonConverter))]
            public decimal LengthIn { get; set; }

            [JsonConverter(typeof(NullableDecimalJsonConverter))]
            public decimal? DiameterIn { get; set; }

            [JsonConverter(typeof(DecimalJsonConverter))]
            public decimal ApproximateVolumeIn { get; set; }

            [JsonConverter(typeof(NullableDecimalJsonConverter))]
            public decimal? WeightOz { get; set; }

            public string TubeMaterial { get; set; } = string.Empty;
            public string Color { get; set; } = string.Empty;
            public string Caliber { get; set; } = string.Empty;
            public string Mount { get; set; } = string.Empty;
            public string? FullAutoRated { get; set; }
            public string? BarrelLengthRestrictions { get; set; }
            public string? MagnumRated { get; set; }
            public string? PistonCompatible { get; set; }
            public string Class { get; set; } = string.Empty;
            public string ShortestModularLength { get; set; } = "NA";
            public string BaffleTypecount { get; set; } = string.Empty;
            public string? AdditionalNotes { get; set; }
            public string Webpage { get; set; } = string.Empty;
            public string? PewSciencePagesIfApplicable { get; set; }
        }
    }
}
