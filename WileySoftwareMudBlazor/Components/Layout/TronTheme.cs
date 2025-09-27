// Developer style comments
using MudBlazor;

namespace WileySoftwareMudBlazor.Components.Layout
{
    public class TronTheme : MudTheme
    {
        public TronTheme()
        {
            // "Light Mode" - Cyan theme with a dark background
            PaletteLight = new PaletteLight()
            {
                Primary = "#00FFFF", // Cyan
                PrimaryContrastText = "#000000",
                Background = "#000000", // Black background
                Surface = "#1C1C1C", // Dark grey surface
                TextPrimary = "#00FFFF", // Cyan text
                TextSecondary = "#FFFFFF",
                AppbarBackground = "#000000",
                AppbarText = "#00FFFF",
                LinesDefault = "#303C55",
                ActionDefault = "#00FFFF" // Cyan actions
            };

            // "Dark Mode" - Orange theme with the same dark background
            PaletteDark = new PaletteDark()
            {
                Primary = "#FF8C00", // Orange
                PrimaryContrastText = "#000000",
                Background = "#000000", // Black background
                Surface = "#1C1C1C", // Dark grey surface
                TextPrimary = "#FF8C00", // Orange text
                TextSecondary = "#FFFFFF",
                AppbarBackground = "#000000",
                AppbarText = "#FF8C00",
                LinesDefault = "#303C55",
                ActionDefault = "#FF8C00" // Orange actions
            };

            Typography = new Typography()
            {
                Default = new DefaultTypography()
                {
                    FontFamily = new[] { "Fira Code", "monospace" }
                },
                // ... (rest of typography settings remain the same)
            };

            LayoutProperties = new LayoutProperties()
            {
                DefaultBorderRadius = "0px"
            };
        }
    }
}