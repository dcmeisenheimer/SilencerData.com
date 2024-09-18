using SilencerData.Client;
using SilencerData.Client.Models.SilencerData.Client.Models;

namespace SilencerData.Client.Models
{
    public class SilencerMatcher
    {
        private List<Silencer> _silencers;

        public SilencerMatcher(List<Silencer> silencers)
        {
            _silencers = silencers;
        }

        public List<Silencer> FindMatches(UserPreferences preferences)
        {
            var matches = _silencers
                .Where(s => s.Caliber == preferences.Caliber)
                .Where(s => s.MSRP >= preferences.MinBudget && s.MSRP <= preferences.MaxBudget)
                .ToList();

            if (!string.IsNullOrEmpty(preferences.Class) && preferences.Class != "Any")
                matches = matches.Where(s => s.Class.Contains(preferences.Class)).ToList();

            if (!string.IsNullOrEmpty(preferences.Manufacturer))
                matches = matches.Where(s => s.Manufacturer == preferences.Manufacturer).ToList();

            if (!string.IsNullOrEmpty(preferences.Material))
                matches = matches.Where(s => s.TubeMaterial == preferences.Material).ToList();

            if (preferences.LengthPreference.HasValue && preferences.LengthPreference != LengthPreference.Any)
                matches = FilterByLength(matches, preferences.LengthPreference.Value);

            if (preferences.WeightPreference.HasValue && preferences.WeightPreference != WeightPreference.Any)
                matches = FilterByWeight(matches, preferences.WeightPreference.Value);

            if (preferences.FullAutoRated.HasValue)
                matches = matches.Where(s => (s.FullAutoRated == "Yes") == preferences.FullAutoRated.Value).ToList();

            if (preferences.MagnumRated.HasValue)
                matches = matches.Where(s => (s.MagnumRated == "Yes") == preferences.MagnumRated.Value).ToList();

            if (preferences.PistonCompatible.HasValue)
                matches = matches.Where(s => (s.PistonCompatible == "Yes") == preferences.PistonCompatible.Value).ToList();

            return matches.OrderByDescending(s => CalculateMatchScore(s, preferences)).Take(10).ToList();
        }

        private List<Silencer> FilterByLength(List<Silencer> silencers, LengthPreference preference)
        {
            switch (preference)
            {
                case LengthPreference.Short:
                    return silencers.Where(s => s.LengthIn < 6).ToList();
                case LengthPreference.Medium:
                    return silencers.Where(s => s.LengthIn >= 6 && s.LengthIn < 8).ToList();
                case LengthPreference.Long:
                    return silencers.Where(s => s.LengthIn >= 8).ToList();
                default:
                    return silencers;
            }
        }

        private List<Silencer> FilterByWeight(List<Silencer> silencers, WeightPreference preference)
        {
            switch (preference)
            {
                case WeightPreference.Light:
                    return silencers.Where(s => s.WeightOz < 10).ToList();
                case WeightPreference.Medium:
                    return silencers.Where(s => s.WeightOz >= 10 && s.WeightOz < 15).ToList();
                case WeightPreference.Heavy:
                    return silencers.Where(s => s.WeightOz >= 15).ToList();
                default:
                    return silencers;
            }
        }

        private int CalculateMatchScore(Silencer silencer, UserPreferences preferences)
        {
            int score = 0;

            if (silencer.Manufacturer == preferences.Manufacturer) score += 5;
            if (silencer.TubeMaterial == preferences.Material) score += 3;
            if (MatchesLengthPreference(silencer, preferences.LengthPreference)) score += 3;
            if (MatchesWeightPreference(silencer, preferences.WeightPreference)) score += 3;
            if ((silencer.FullAutoRated == "Yes") == preferences.FullAutoRated) score += 2;
            if ((silencer.MagnumRated == "Yes") == preferences.MagnumRated) score += 2;
            if ((silencer.PistonCompatible == "Yes") == preferences.PistonCompatible) score += 2;

            return score;
        }

        private bool MatchesLengthPreference(Silencer silencer, LengthPreference? preference)
        {
            if (!preference.HasValue) return true;
            switch (preference.Value)
            {
                case LengthPreference.Short:
                    return silencer.LengthIn < 6;
                case LengthPreference.Medium:
                    return silencer.LengthIn >= 6 && silencer.LengthIn < 8;
                case LengthPreference.Long:
                    return silencer.LengthIn >= 8;
                default:
                    return true;
            }
        }

        private bool MatchesWeightPreference(Silencer silencer, WeightPreference? preference)
        {
            if (!preference.HasValue) return true;
            switch (preference.Value)
            {
                case WeightPreference.Light:
                    return silencer.WeightOz < 10;
                case WeightPreference.Medium:
                    return silencer.WeightOz >= 10 && silencer.WeightOz < 15;
                case WeightPreference.Heavy:
                    return silencer.WeightOz >= 15;
                default:
                    return true;
            }
        }
    }

    public class UserPreferences
    {
        public string Caliber { get; set; }
        public string Class { get; set; }
        public decimal MinBudget { get; set; }
        public decimal MaxBudget { get; set; }
        public string Manufacturer { get; set; }
        public string Material { get; set; }
        public LengthPreference? LengthPreference { get; set; }
        public WeightPreference? WeightPreference { get; set; }
        public bool? FullAutoRated { get; set; }
        public bool? MagnumRated { get; set; }
        public bool? PistonCompatible { get; set; }
    }

    public enum LengthPreference
    {
        Any,
        Short,
        Medium,
        Long
    }

    public enum WeightPreference
    {
        Any,
        Light,
        Medium,
        Heavy
    }
}
//Essential User Selections:

//Caliber
//Class(e.g., Rimfire, Pistol, Rifle, Magnum, Universal)
//Budget(MSRP range)


//Optional User Selections:

//Manufacturer
//Material preference (e.g., Aluminum, Stainless Steel, Titanium)
//Length preference (Short, Medium, Long)
//Weight preference (Light, Medium, Heavy)
//Full Auto Rated (Yes/No)
//Magnum Rated (Yes/No)
//Piston Compatible (Yes/No)


//Algorithm Steps:

//Step 1: Filter by Essential Criteria

//Filter silencers by selected caliber
//Filter by selected class
//Filter by MSRP within the user's budget range

//Step 2: Apply Optional Criteria (if selected)

//Filter by manufacturer
//Filter by material
//Filter by length range
//Filter by weight range
//Filter by full auto rating
//Filter by magnum rating
//Filter by piston compatibility

//Step 3: Rank Results

//Assign points to each silencer based on how well it matches the user's preferences
//Sort silencers by total points in descending order

//Step 4: Present Results

//Show top 5-10 matches
//Provide option to view all matches
