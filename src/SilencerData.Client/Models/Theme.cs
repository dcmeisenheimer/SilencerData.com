using MudBlazor;

namespace SilencerData.Client.Models
{
    public static class Theme
    {
        public static readonly MudTheme Default = new()
        {
            PaletteLight = new PaletteLight()
            {
                Background = "#EEEEEE",           // Brand color: White
                Surface = "#ffffff",              // Brand color: White
                DrawerBackground = "#f5f5f5",     // Slightly off-white for contrast
                AppbarBackground = "#ffffff",     // Brand color: White
                AppbarText = "#151515",           // Brand color: Very Dark Gray
                Primary = "#717171",              // Brand color: Medium Gray
                Secondary = "#525252",            // Brand color: Dark Gray
                Tertiary = "#333333",             // Brand color: Darker Gray
                Info = "#1565C0",                 // Keep original blue for info
                Success = "#2E7D32",              // Keep original green for success
                Warning = "#D55A13",              // Keep original orange for warning
                Error = "#B71C1C",                // Keep original red for error
                TextPrimary = "#151515",          // Brand color: Very Dark Gray
                TextSecondary = "#333333",        // Brand color: Darker Gray
                TextDisabled = "#717171",         // Brand color: Medium Gray
                ActionDefault = "#525252",        // Brand color: Dark Gray
                ActionDisabled = "#717171",       // Brand color: Medium Gray
                ActionDisabledBackground = "#f5f5f5", // Slightly off-white
                Dark = "#333333",                 // Brand color: Darker Gray
                DarkContrastText = "#ffffff",     // Brand color: White
                GrayLight = "#f5f5f5",            // Slightly off-white
                GrayLighter = "#fafafa",          // Very light gray
                GrayDark = "#525252",             // Brand color: Dark Gray
                GrayDarker = "#333333",           // Brand color: Darker Gray
                GrayDefault = "#717171",          // Brand color: Medium Gray
                OverlayLight = "rgba(255,255,255,0.1)",
                OverlayDark = "rgba(0,0,0,0.2)"
                //Light Mode Palette Contrast Scores(all above 7:1 against both background and surface):

                //Background(#EEEEEE) and TextPrimary (#121212): 15.8:1
                //Surface(#E0E0E0) and TextPrimary (#121212): 14.0:1
                //DrawerBackground(#EEEEEE) and TextPrimary (#121212): 15.8:1
                //AppbarBackground(#E0E0E0) and AppbarText (#121212): 14.0:1

                // Primary: #7A1712 (Bright Red)
                // Contrast with Background(#EEEEEE): 8.0:1
                // Contrast with Surface(#E0E0E0): 7.1:1

                // Secondary: #8D6E63 (Warm Brown)
                // Contrast with Background(#EEEEEE): 7.1:1
                // Contrast with Surface(#E0E0E0): 6.3:1 (AA)

                // Tertiary: #FFA000 (Amber)
                // Contrast with Background(#EEEEEE): 7.2:1
                // Contrast with Surface(#E0E0E0): 6.4:1 (AA)

                // Info: #1565C0 (Blue)
                // Contrast with Background(#EEEEEE): 10.4:1
                // Contrast with Surface(#E0E0E0): 9.3:1

                // Success: #2E7D32 (Green)
                // Contrast with Background(#EEEEEE): 9.8:1
                // Contrast with Surface(#E0E0E0): 8.7:1

                // Warning: #FF6F00 (Orange)
                // Contrast with Background(#EEEEEE): 7.6:1
                // Contrast with Surface(#E0E0E0): 6.8:1 (AA)

                // Error: #B71C1C (Dark Red)
                // Contrast with Background(#EEEEEE): 10.7:1
                // Contrast with Surface(#E0E0E0): 9.5:1

                // ActionDefault: #7A1712 (Bright Red)
                // Contrast with Background(#EEEEEE): 8.0:1
                // Contrast with Surface(#E0E0E0): 7.1:1

                //TextSecondary(#1E1E1E) and Background (#EEEEEE): 14.4:1
                //TextSecondary(#1E1E1E) and Surface (#E0E0E0): 12.6:1
                //TextDisabled(#545454) and Background (#EEEEEE): 8.0:1
                //TextDisabled(#545454) and Surface (#E0E0E0): 7.1:1
                //ActionDisabled(#616161) and ActionDisabledBackground (#E0E0E0): 5.0:1 (AA Large Text)
                //GrayLight(#BDBDBD) and TextPrimary (#121212): 11.4:1
                //GrayLighter(#E0E0E0) and TextPrimary (#121212): 14.0:1
                //GrayDark(#616161) and Background (#EEEEEE): 6.0:1 (AA)
                //GrayDark(#616161) and Surface (#E0E0E0): 5.0:1 (AA Large Text)
                //GrayDarker(#545454) and Background (#EEEEEE): 8.0:1
                //GrayDarker(#545454) and Surface (#E0E0E0): 7.1:1
                //GrayDefault(#9E9E9E) and TextPrimary (#121212): 8.9:1

            },
            PaletteDark = new PaletteDark()
            {
                Background = "#151515",           // Brand color: Very Dark Gray
                Surface = "#333333",              // Brand color: Darker Gray
                DrawerBackground = "#222222",     // Slightly lighter than background
                AppbarBackground = "#333333",     // Brand color: Darker Gray
                AppbarText = "#ffffff",           // Brand color: White
                Primary = "#ffffff",              // Brand color: Medium Gray
                Secondary = "#525252",            // Brand color: Dark Gray
                Tertiary = "#B0B0B0",             // New Silencer color for dark mode
                Info = "#7AAAFF",                 // Lighter blue for better contrast in dark mode
                Success = "#6EBC6B",              // Lighter green for better contrast in dark mode
                Warning = "#FF8A44",              // Lighter orange for better contrast in dark mode
                Error = "#EA5041",                // Lighter red for better contrast in dark mode
                TextPrimary = "#ffffff",          // Brand color: White
                TextSecondary = "#B0B0B0",        // New Silencer color for secondary text
                TextDisabled = "#717171",         // Brand color: Medium Gray
                ActionDefault = "#B0B0B0",        // Brand color: Dark Gray
                ActionDisabled = "#333333",       // Brand color: Darker Gray
                ActionDisabledBackground = "#222222", // Slightly lighter than background
                Dark = "#ffffff",                 // Brand color: White (for contrast)
                DarkContrastText = "#151515",     // Brand color: Very Dark Gray
                GrayLight = "#525252",            // Brand color: Dark Gray
                GrayLighter = "#717171",          // Brand color: Medium Gray
                GrayDark = "#B0B0B0",             // New Silencer color
                GrayDarker = "#ffffff",           // Brand color: White
                GrayDefault = "#525252",          // Brand color: Dark Gray
                OverlayLight = "rgba(255,255,255,0.1)",
                OverlayDark = "rgba(0,0,0,0.2)"

                //Dark Mode Palette Contrast Scores(all above 7:1 against both background and surface):

                //Background(#121212) and TextPrimary (#FFFFFF): 16.0:1
                //Surface(#1E1E1E) and TextPrimary (#FFFFFF): 13.8:1
                //DrawerBackground(#121212) and TextPrimary (#FFFFFF): 16.0:1
                //AppbarBackground(#1E1E1E) and AppbarText (#FFFFFF): 13.8:1
                //Primary(#FF6B6B) and Background (#121212): 8.5:1
                //Primary(#FF6B6B) and Surface (#1E1E1E): 7.3:1
                //Secondary(#A9907E) and Background (#121212): 7.2:1
                //Secondary(#A9907E) and Surface (#1E1E1E): 6.2:1 (AA)
                //Tertiary(#FFD97D) and Background (#121212): 14.1:1
                //Tertiary(#FFD97D) and Surface (#1E1E1E): 12.0:1
                //Info(#7FC8FF) and Background (#121212): 10.4:1
                //Info(#7FC8FF) and Surface (#1E1E1E): 8.8:1
                //Success(#9CDCB8) and Background (#121212): 10.8:1
                //Success(#9CDCB8) and Surface (#1E1E1E): 9.2:1
                //Warning(#FFB74D) and Background (#121212): 11.2:1
                //Warning(#FFB74D) and Surface (#1E1E1E): 9.5:1
                //Error(#FF8888) and Background (#121212): 9.6:1
                //Error(#FF8888) and Surface (#1E1E1E): 8.2:1
                //TextSecondary(#F5F5F5) and Background (#121212): 15.5:1
                //TextSecondary(#F5F5F5) and Surface (#1E1E1E): 13.1:1
                //TextDisabled(#BDBDBD) and Background (#121212): 11.4:1
                //TextDisabled(#BDBDBD) and Surface (#1E1E1E): 8.3:1
                //ActionDisabled(#9E9E9E) and ActionDisabledBackground (#1E1E1E): 5.3:1 (AA)
                //GrayLight(#616161) and TextPrimary (#FFFFFF): 7.1:1
                //GrayLighter(#757575) and TextPrimary (#FFFFFF): 5.7:1
                //GrayDark(#E0E0E0) and Background (#121212): 13.8:1
                //GrayDark(#E0E0E0) and Surface (#1E1E1E): 11.7:1
                //GrayDarker(#F5F5F5) and Background (#121212): 15.5:1
                //GrayDarker(#F5F5F5) and Surface (#1E1E1E): 13.1:1
                //GrayDefault(#BDBDBD) and TextPrimary (#FFFFFF): 8.3:1
            },
            Typography = new Typography()
            {
                Default = new Default()
                {
                    FontFamily = new[] { "Inter", "-apple-system", "BlinkMacSystemFont", "Segoe UI", "Noto Sans", "Roboto", "Helvetica", "Arial", "sans-serif" }
                },
                H5 = new H5()
                {
                    FontWeight = 600,
                    LetterSpacing = "-0.5px"
                },
                H6 = new H6()
                {
                    FontWeight = 500,
                    LetterSpacing = "-0.25px"
                }
            }
        };
        //public static readonly MudTheme Default = new()
        //{
        //    Palette = new PaletteLight()
        //    {
        //        Background = "#f5f5f7",           // Light grey, gentle on the eyes
        //        Surface = "#FFFFFF",              // Pure white for main surfaces
        //        DrawerBackground = "#f5f5f7",     // Matches background color for consistency
        //        AppbarBackground = "#FFFFFF",     // Matches surface color for a clean look
        //        AppbarText = "#161616",           // Dark grey for contrast
        //        Primary = "#9B1F18",              // Warm Dark Brown
        //        Secondary = "#54110d",            // Very Dark Red
        //        Tertiary = "#7A1712",             // Adjusted Dark Red for better contrast (AAA - 7.21:1)
        //        Info = "#3B82F6",                 // Blue for informational elements
        //        Success = "#10B981",              // Green for success messages
        //        Warning = "#D97706",              // Orange for warnings
        //        Error = "#EF4444",                // Red for errors
        //        TextPrimary = "#161616",          // Dark grey for primary text
        //        TextSecondary = "#333333",        // Slightly lighter dark grey for secondary text
        //        TextDisabled = "#807f7f",         // Grayish for disabled text
        //        ActionDefault = "#9B1F18",        // Matches Primary color
        //        ActionDisabled = "#cccccc",       // Light gray for disabled actions
        //        ActionDisabledBackground = "#f5f5f7", // Matches background color for consistency
        //        GrayLight = "#EEEEEE",            // Very light grey for various elements
        //        GrayLighter = "#f5f5f7",          // Matches background color
        //        GrayDark = "#666666",             // Medium gray for text or icons
        //        GrayDarker = "#4d4c4c",           // Dark gray
        //        GrayDefault = "#999999",          // Default gray
        //        OverlayLight = "rgba(255,255,255,0.7)", // Light overlay with transparency
        //        OverlayDark = "rgba(0,0,0,0.7)"   // Dark overlay with transparency
        //    },
        //    PaletteDark = new PaletteDark()
        //    {
        //        Background = "#000000",           // Black for background
        //        Surface = "#161616",              // Very dark grey for main surfaces
        //        DrawerBackground = "#000000",     // Matches background color for consistency
        //        AppbarBackground = "#161616",     // Matches surface color for a clean look
        //        AppbarText = "#FFFFFF",           // White for contrast
        //        Primary = "#D5C3A9",              // Medium Brown
        //        Secondary = "#C1B67E",            // Light Brown
        //        Tertiary = "#9B1F18",             // Warm Dark Brown
        //        Info = "#64B5F6",                 // Light blue for informational elements
        //        Success = "#81C784",              // Light green for success messages
        //        Warning = "#FFB74D",              // Light orange for warnings
        //        Error = "#E57373",                // Light red for errors
        //        TextPrimary = "#FFFFFF",          // White for primary text
        //        TextSecondary = "#f5f5f7",        // Light grey for secondary text
        //        TextDisabled = "#999999",         // Gray for disabled text
        //        ActionDefault = "#D5C3A9",        // Matches Primary color
        //        ActionDisabled = "#4d4c4c",       // Dark gray for disabled actions
        //        ActionDisabledBackground = "#000000", // Matches background color for consistency
        //        GrayLight = "#333333",            // Dark grey for various elements
        //        GrayLighter = "#262626",          // Slightly lighter dark grey
        //        GrayDark = "#cccccc",             // Light gray for text or icons
        //        GrayDarker = "#999999",           // Gray
        //        GrayDefault = "#666666",          // Medium gray
        //        OverlayLight = "rgba(255,255,255,0.5)", // Light overlay with transparency
        //        OverlayDark = "rgba(0,0,0,0.5)"   // Dark overlay with transparency
        //    },
        //    Typography = new Typography()
        //    {
        //        Default = new Default()
        //        {
        //            FontFamily = new[] { "Inter", "-apple-system", "BlinkMacSystemFont", "Segoe UI", "Noto Sans", "Roboto", "Helvetica", "Arial", "sans-serif" }
        //        }
        //    }
        //};

        //public static readonly MudTheme NeutralLightGrayTheme = new()
        //{
        //    Palette = new PaletteLight()
        //    {
        //        Background = "#F5F5F5",
        //        Surface = "#FFFFFF",
        //        DrawerBackground = "#F0F0F0",
        //        AppbarBackground = "#F7F7F7",
        //        AppbarText = "#161616",
        //        Primary = "#5C4033",          // Warm Dark Brown
        //        Secondary = "#8B5A2B",        // Medium Brown
        //        Tertiary = "#D2B48C",         // Light Brown
        //        Info = "#3B82F6",
        //        Success = "#10B981",
        //        Warning = "#D97706",
        //        Error = "#EF4444",
        //        TextPrimary = "#161616",
        //        TextSecondary = "#262626",
        //        TextDisabled = "rgba(97, 97, 97, 0.7)",
        //        ActionDefault = "#5C4033",    // Matches Primary color
        //        ActionDisabled = "#A6A6A6",
        //        ActionDisabledBackground = "#D9D9D9",
        //        GrayLight = "#F2F2F2",
        //        GrayLighter = "#D9D9D9",
        //        GrayDark = "#737373",
        //        GrayDarker = "#595959",
        //        GrayDefault = "#8C8C8C",
        //        OverlayLight = "rgba(255,255,255,0.7)",
        //        OverlayDark = "rgba(0,0,0,0.7)"
        //    },
        //    PaletteDark = new PaletteDark()
        //    {
        //        Background = "#121212",
        //        Surface = "#1E1E1E",
        //        DrawerBackground = "#1E1E1E",
        //        AppbarBackground = "#242424",
        //        AppbarText = "#FFFFFF",
        //        Primary = "#B8860B",          // Warm Golden Brown
        //        Secondary = "#CD853F",        // Peru
        //        Tertiary = "#FFD700",         // Gold
        //        Info = "#64B5F6",
        //        Success = "#81C784",
        //        Warning = "#FFB74D",
        //        Error = "#E57373",
        //        TextPrimary = "#E0E0E0",
        //        TextSecondary = "#BDBDBD",
        //        TextDisabled = "rgba(166, 166, 166, 0.5)",
        //        ActionDefault = "#B8860B",    // Matches Primary color
        //        ActionDisabled = "#424242",
        //        ActionDisabledBackground = "#1E1E1E",
        //        GrayLight = "#757575",
        //        GrayLighter = "#9E9E9E",
        //        GrayDark = "#E0E0E0",
        //        GrayDarker = "#BDBDBD",
        //        GrayDefault = "#EEEEEE",
        //        OverlayLight = "rgba(255,255,255,0.5)",
        //        OverlayDark = "rgba(0,0,0,0.5)"
        //    },
        //    Typography = Theme.Default.Typography
        //};
        //public static readonly MudTheme NeutralLightGrayThemePantone = new()
        //{
        //    Palette = new PaletteLight()
        //    {
        //        Background = "#F5F5F5",            // Pantone Bright White
        //        Surface = "#FFFFFF",               // Pure white for main surfaces
        //        DrawerBackground = "#E8E8E8",      // Light grey for drawer background
        //        AppbarBackground = "#F7F7F7",      // Matching surface color for a clean look
        //        AppbarText = "#161616",            // Dark grey for contrast
        //        Primary = "#111111",               // Pantone Black C for primary elements
        //        Secondary = "#A68B60",             // Pantone Beige for secondary elements
        //        Tertiary = "#7A7D82",              // Pantone Neutral Gray for tertiary elements
        //        Info = "#3B82F6",                  // Blue for informational elements
        //        Success = "#10B981",               // Green for success messages
        //        Warning = "#D97706",               // Orange for warnings
        //        Error = "#EF4444",                 // Red for errors
        //        TextPrimary = "#111111",           // Pantone Black C for primary text
        //        TextSecondary = "#3A3A3C",         // Slightly lighter dark grey for secondary text
        //        TextDisabled = "rgba(97, 97, 97, 0.7)", // Dark grey for disabled text with transparency
        //        ActionDefault = "#111111",         // Pantone Black C for default actions
        //        ActionDisabled = "#A6A6A6",         // Grey for disabled actions
        //        ActionDisabledBackground = "#D9D9D9", // Light grey for disabled backgrounds
        //        GrayLight = "#F2F2F2",             // Light grey for various elements
        //        GrayLighter = "#D9D9D9",           // Lighter grey
        //        GrayDark = "#737373",              // Dark grey for text or icons
        //        GrayDarker = "#595959",            // Even darker grey
        //        GrayDefault = "#8C8C8C",           // Default grey
        //        OverlayLight = "rgba(255,255,255,0.7)", // Light overlay with transparency
        //        OverlayDark = "rgba(0,0,0,0.7)"    // Dark overlay with transparency
        //    },
        //    PaletteDark = new PaletteDark()
        //    {
        //        Background = "#121212",            // Very dark grey for background
        //        Surface = "#1E1E1E",               // Dark grey for main surfaces
        //        DrawerBackground = "#1E1E1E",      // Matches surface color for consistency
        //        AppbarBackground = "#242424",      // Slightly lighter dark grey for app bar
        //        AppbarText = "#FFFFFF",            // White for contrast
        //        Primary = "#B0BEC5",               // Light grey-blue for primary elements
        //        Secondary = "#90A4AE",             // Light grey for secondary elements
        //        Tertiary = "#78909C",              // Dark grey-blue for tertiary elements
        //        Info = "#64B5F6",                  // Light blue for informational elements
        //        Success = "#81C784",               // Light green for success messages
        //        Warning = "#FFB74D",               // Light orange for warnings
        //        Error = "#E57373",                 // Light red for errors
        //        TextPrimary = "#E0E0E0",           // Light grey for primary text
        //        TextSecondary = "#BDBDBD",         // Darker light grey for secondary text
        //        TextDisabled = "rgba(189, 189, 189, 0.5)", // Light grey for disabled text with transparency
        //        ActionDefault = "#B0BEC5",         // Matches Primary color
        //        ActionDisabled = "#424242",        // Dark grey for disabled actions
        //        ActionDisabledBackground = "#1E1E1E", // Matches surface color for consistency
        //        GrayLight = "#757575",             // Dark grey for various elements
        //        GrayLighter = "#9E9E9E",           // Slightly lighter dark grey
        //        GrayDark = "#E0E0E0",              // Light grey for text or icons
        //        GrayDarker = "#BDBDBD",            // Dark grey
        //        GrayDefault = "#EEEEEE",           // Default light grey
        //        OverlayLight = "rgba(255,255,255,0.5)", // Light overlay with transparency
        //        OverlayDark = "rgba(0,0,0,0.5)"    // Dark overlay with transparency
        //    },
        //    Typography = Theme.Default.Typography
        //};

        //public static readonly MudTheme WarmLightGrayTheme = new()
        //{
        //    Palette = new PaletteLight()
        //    {
        //        Background = "#FAFAFA",        // Background
        //        Surface = "#FFFFFF",           // Surface
        //        DrawerBackground = "#F2F2F2",  // DrawerBackground
        //        AppbarBackground = "#F9F9F9",  // Appbar Background
        //        AppbarText = "#161616",
        //        Primary = "#B22222",
        //        Secondary = "#4682B4",
        //        Tertiary = "#2F4F4F",
        //        Info = "#3B82F6",
        //        Success = "#10B981",
        //        Warning = "#D97706",
        //        Error = "#EF4444",
        //        TextPrimary = "#161616",
        //        TextSecondary = "#262626",
        //        TextDisabled = "rgba(38, 38, 38, 0.7)",
        //        ActionDefault = "#B22222",
        //        ActionDisabled = "#A6A6A6",
        //        ActionDisabledBackground = "#D9D9D9",
        //        GrayLight = "#F2F2F2",
        //        GrayLighter = "#D9D9D9",
        //        GrayDark = "#737373",
        //        GrayDarker = "#595959",
        //        GrayDefault = "#8C8C8C",
        //        OverlayLight = "rgba(255,255,255,0.7)",
        //        OverlayDark = "rgba(0,0,0,0.7)"
        //    },
        //    PaletteDark = new PaletteDark()
        //    {
        //        Background = "#121212",           // Very dark grey for background
        //        Surface = "#1E1E1E",              // Dark grey for main surfaces
        //        DrawerBackground = "#1E1E1E",     // Matches surface color for consistency
        //        AppbarBackground = "#242424",     // Slightly lighter dark grey for app bar
        //        AppbarText = "#FFFFFF",           // White for contrast
        //        Primary = "#B22222",              // Strong dark red for primary elements
        //        Secondary = "#4682B4",            // Royal Blue for secondary elements
        //        Tertiary = "#2E4E4E",             // Light grey-green for tertiary elements
        //        Info = "#64B5F6",                 // Light blue for informational elements
        //        Success = "#81C784",              // Light green for success messages
        //        Warning = "#FFB74D",              // Light orange for warnings
        //        Error = "#E57373",                // Light red for errors
        //        TextPrimary = "#E0E0E0",          // Light grey for primary text
        //        TextSecondary = "#BDBDBD",        // Darker light grey for secondary text
        //        TextDisabled = "rgba(189, 189, 189, 0.5)", // Light grey for disabled text with transparency
        //        ActionDefault = "#B22222",        // Matches Primary color
        //        ActionDisabled = "#424242",       // Dark grey for disabled actions
        //        ActionDisabledBackground = "#1E1E1E", // Matches surface color for consistency
        //        GrayLight = "#757575",            // Dark grey for various elements
        //        GrayLighter = "#9E9E9E",          // Slightly lighter dark grey
        //        GrayDark = "#E0E0E0",             // Light grey for text or icons
        //        GrayDarker = "#BDBDBD",           // Dark grey
        //        GrayDefault = "#EEEEEE",          // Default light grey
        //        OverlayLight = "rgba(255,255,255,0.5)", // Light overlay with transparency
        //        OverlayDark = "rgba(0,0,0,0.5)"   // Dark overlay with transparency
        //    },
        //    Typography = Theme.Default.Typography
        //};
        //public static readonly MudTheme CoolLightGrayTheme = new()
        //{
        //    Palette = new PaletteLight()
        //    {
        //        Background = "#EFEFEF",        // Background
        //        Surface = "#FFFFFF",           // Surface
        //        DrawerBackground = "#E8E8E8",  // DrawerBackground
        //        AppbarBackground = "#F0F0F0",  // Appbar Background
        //        AppbarText = "#161616",
        //        Primary = "#B22222",
        //        Secondary = "#4682B4",
        //        Tertiary = "#2F4F4F",
        //        Info = "#3B82F6",
        //        Success = "#10B981",
        //        Warning = "#D97706",
        //        Error = "#EF4444",
        //        TextPrimary = "#161616",
        //        TextSecondary = "#262626",
        //        TextDisabled = "rgba(38, 38, 38, 0.7)",
        //        ActionDefault = "#B22222",
        //        ActionDisabled = "#A6A6A6",
        //        ActionDisabledBackground = "#D9D9D9",
        //        GrayLight = "#F2F2F2",
        //        GrayLighter = "#D9D9D9",
        //        GrayDark = "#737373",
        //        GrayDarker = "#595959",
        //        GrayDefault = "#8C8C8C",
        //        OverlayLight = "rgba(255,255,255,0.7)",
        //        OverlayDark = "rgba(0,0,0,0.7)"
        //    },
        //    PaletteDark = new PaletteDark()
        //    {
        //        Background = "#121212",           // Very dark grey for background
        //        Surface = "#1E1E1E",              // Dark grey for main surfaces
        //        DrawerBackground = "#1E1E1E",     // Matches surface color for consistency
        //        AppbarBackground = "#242424",     // Slightly lighter dark grey for app bar
        //        AppbarText = "#FFFFFF",           // White for contrast
        //        Primary = "#B22222",              // Strong dark red for primary elements
        //        Secondary = "#4682B4",            // Royal Blue for secondary elements
        //        Tertiary = "#2E4E4E",             // Light grey-green for tertiary elements
        //        Info = "#64B5F6",                 // Light blue for informational elements
        //        Success = "#81C784",              // Light green for success messages
        //        Warning = "#FFB74D",              // Light orange for warnings
        //        Error = "#E57373",                // Light red for errors
        //        TextPrimary = "#E0E0E0",          // Light grey for primary text
        //        TextSecondary = "#BDBDBD",        // Darker light grey for secondary text
        //        TextDisabled = "rgba(189, 189, 189, 0.5)", // Light grey for disabled text with transparency
        //        ActionDefault = "#B22222",        // Matches Primary color
        //        ActionDisabled = "#424242",       // Dark grey for disabled actions
        //        ActionDisabledBackground = "#1E1E1E", // Matches surface color for consistency
        //        GrayLight = "#757575",            // Dark grey for various elements
        //        GrayLighter = "#9E9E9E",          // Slightly lighter dark grey
        //        GrayDark = "#E0E0E0",             // Light grey for text or icons
        //        GrayDarker = "#BDBDBD",           // Dark grey
        //        GrayDefault = "#EEEEEE",          // Default light grey
        //        OverlayLight = "rgba(255,255,255,0.5)", // Light overlay with transparency
        //        OverlayDark = "rgba(0,0,0,0.5)"   // Dark overlay with transparency
        //    },
        //    Typography = Theme.Default.Typography
        //};

        //public static readonly MudTheme Alternative = new()
        //{
        //    Palette = new PaletteLight()
        //    {
        //        Background = "#F5F5F7",
        //        Surface = "#FAFAFA",
        //        DrawerBackground = "#F5F5F7",
        //        AppbarBackground = "#FAFAFA",
        //        AppbarText = "#1C1C1E",
        //        Primary = "#007AFF",
        //        Secondary = "#7A6226",
        //        Tertiary = "#064E3B",
        //        Info = "#3B82F6",
        //        Success = "#10B981",
        //        Warning = "#D97706",
        //        Error = "#EF4444",
        //        TextPrimary = "#1C1C1E",
        //        TextSecondary = "#3A3A3C",
        //        TextDisabled = "rgba(38, 38, 38, 0.5)",
        //        ActionDefault = "#007AFF",
        //        ActionDisabled = "#A6A6A6",
        //        ActionDisabledBackground = "#E5E5EA",
        //        GrayLight = "#F5F5F7",
        //        GrayLighter = "#E5E5EA",
        //        GrayDark = "#C7C7CC",
        //        GrayDarker = "#8E8E93",
        //        GrayDefault = "#AEAEB2",
        //        OverlayLight = "rgba(255,255,255,0.7)",
        //        OverlayDark = "rgba(0,0,0,0.7)",

        //    },
        //    PaletteDark = new PaletteDark()
        //    {
        //        Background = "#000000",
        //        Surface = "#1C1C1E",
        //        DrawerBackground = "#1C1C1E",
        //        AppbarBackground = "#1C1C1E",
        //        AppbarText = "#FFFFFF",
        //        Primary = "#0A84FF",
        //        Secondary = "#5E5CE6",
        //        Tertiary = "#30D158",
        //        Info = "#64D2FF",
        //        Success = "#32D74B",
        //        Warning = "#FF9F0A",
        //        Error = "#FF453A",
        //        TextPrimary = "#FFFFFF",
        //        TextSecondary = "#8E8E93",
        //        TextDisabled = "rgba(142, 142, 147, 0.5)",
        //        ActionDefault = "#0A84FF",
        //        ActionDisabled = "#636366",
        //        ActionDisabledBackground = "#48484A",
        //        GrayLight = "#1C1C1E",
        //        GrayLighter = "#2C2C2E",
        //        GrayDark = "#3A3A3C",
        //        GrayDarker = "#48484A",
        //        GrayDefault = "#636366",
        //        OverlayLight = "rgba(255,255,255,0.5)",
        //        OverlayDark = "rgba(0,0,0,0.5)"
        //    },
        //    Typography = new Typography()
        //    {
        //        Default = new Default()
        //        {
        //            FontFamily = new[] { "Inter", "-apple-system", "BlinkMacSystemFont", "Segoe UI", "Noto Sans", "Roboto", "Helvetica", "Arial", "sans-serif" }
        //        }
        //    }
        //};
    }

}
