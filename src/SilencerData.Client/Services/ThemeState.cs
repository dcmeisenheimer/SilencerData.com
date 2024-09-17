using Blazored.LocalStorage;

namespace SilencerData.Client.Services
{
    public class ThemeState
    {
        private const string DarkModeKey = "darkMode";
        public const string LightMode = "light";
        public const string DarkMode = "dark";
        public const string SystemMode = "system";

        private readonly ILocalStorageService _localStorage;

        public ThemeState(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task<string> GetAppliedModeAsync()
        {
            string userChoice = await GetUserPreferenceAsync();

            if (userChoice == LightMode || userChoice == DarkMode)
            {
                return userChoice;
            }
            else
            {
                return SystemMode;
            }
        }

        public async Task<string> GetUserPreferenceAsync()
        {
            // Retrieve the user's stored preference from local storage
            string? userPreference = await _localStorage.GetItemAsStringAsync(DarkModeKey);

            // If no preference is stored, default to "system"
            return string.IsNullOrEmpty(userPreference) ? SystemMode : userPreference;
        }

        public async Task SetUserPreferenceAsync(string preference)
        {
            // Store the user's preference in local storage
            await _localStorage.SetItemAsStringAsync(DarkModeKey, preference);
        }

        public async Task ToggleDarkModeAsync(bool isDarkMode)
        {
            // Update the user's preference in local storage based on the provided value
            await SetUserPreferenceAsync(isDarkMode ? DarkMode : LightMode);
        }
    }
}
