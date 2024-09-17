namespace SilencerData.Client.Models
{
    public class Silencer
    {
        public required string Manufacturer { get; set; }
        public required string Model { get; set; }
        public decimal MSRP { get; set; }
        public decimal LengthIn { get; set; }
        public decimal? DiameterIn { get; set; }
        public decimal ApproximateVolumeIn { get; set; }
        public decimal? WeightOz { get; set; }
        public required string TubeMaterial { get; set; }
        public required string Color { get; set; }
        public required string Caliber { get; set; }
        public required string Mount { get; set; }
        public string? FullAutoRated { get; set; }
        public string? BarrelLengthRestrictions { get; set; }
        public string? MagnumRated { get; set; }
        public string? PistonCompatible { get; set; }
        public required string Class { get; set; }
        public string ShortestModularLength { get; set; } = "NA";
        public required string BaffleTypecount { get; set; }
        public string? AdditionalNotes { get; set; }
        public required string Webpage { get; set; }
        public string? PewSciencePagesIfApplicable { get; set; }
    }
}
