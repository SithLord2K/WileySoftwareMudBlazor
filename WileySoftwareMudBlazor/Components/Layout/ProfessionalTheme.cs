using MudBlazor;

namespace WileySoftwareMudBlazor.Components.Layout
{
    public class ProfessionalTheme : MudTheme
    {
        public ProfessionalTheme()
        {
            // Standard professional light mode
            PaletteLight = new PaletteLight()
            {
                Primary = Colors.Blue.Default,
                Background = Colors.Gray.Lighten5, // Light gray
                Surface = Colors.Shades.White,
                TextPrimary = Colors.Gray.Darken3,
                TextSecondary = Colors.Gray.Darken1,
                AppbarBackground = Colors.Blue.Default,
                AppbarText = Colors.Shades.White,
                DrawerBackground = Colors.Shades.White,
                ActionDefault = Colors.Gray.Darken1 // Sets default icon color
            };

            // A professional dark mode that is NOT black or "Tron"
            PaletteDark = new PaletteDark()
            {
                Primary = Colors.Blue.Lighten1,
                Background = Colors.Gray.Darken3, // A medium-dark gray
                Surface = Colors.Gray.Darken2,
                TextPrimary = Colors.Gray.Lighten5,
                TextSecondary = Colors.Gray.Lighten2,
                AppbarBackground = Colors.Gray.Darken4,
                AppbarText = Colors.Shades.White,
                DrawerBackground = Colors.Gray.Darken4,
                ActionDefault = Colors.Gray.Lighten1 // Sets default icon color
            };

            LayoutProperties = new LayoutProperties()
            {
                DefaultBorderRadius = "6px"
            };

            // Enforce a single professional font for all text
            Typography = new Typography()
            {
                Default = new DefaultTypography()
                {
                    FontFamily = new[] { "Inter", "sans-serif" },
                    FontWeight = "400"
                },
                H1 = new H1Typography() { FontFamily = new[] { "Inter", "sans-serif" }, FontWeight = "600" },
                H2 = new H2Typography() { FontFamily = new[] { "Inter", "sans-serif" }, FontWeight = "600" },
                H3 = new H3Typography() { FontFamily = new[] { "Inter", "sans-serif" }, FontWeight = "600" },
                H4 = new H4Typography() { FontFamily = new[] { "Inter", "sans-serif" }, FontWeight = "600" },
                H5 = new H5Typography() { FontFamily = new[] { "Inter", "sans-serif" }, FontWeight = "600" },
                H6 = new H6Typography() { FontFamily = new[] { "Inter", "sans-serif" }, FontWeight = "600" },
                Button = new ButtonTypography() { FontFamily = new[] { "Inter", "sans-serif" }, FontWeight = "500" }
            };
        }
    }
}