using MudBlazor;

namespace WileySoftwareMudBlazor.Components.Layout
{
    public class ProfessionalTheme : MudTheme
    {
        public ProfessionalTheme()
        {
            // A professional, clean light mode palette
            PaletteLight = new PaletteLight()
            {
                Primary = Colors.Blue.Default,
                Secondary = Colors.Gray.Darken1,
                Background = Colors.Gray.Lighten5,
                AppbarBackground = Colors.Blue.Default,
                AppbarText = Colors.Shades.White,
                DrawerBackground = Colors.Shades.White,
                Surface = Colors.Shades.White,
                TextPrimary = Colors.Gray.Darken3,
                TextSecondary = Colors.Gray.Darken1,
                ActionDefault = Colors.Blue.Default,
                LinesDefault = Colors.Gray.Lighten2
            };

            // A corresponding professional dark mode
            PaletteDark = new PaletteDark()
            {
                Primary = Colors.Blue.Lighten1,
                Secondary = Colors.Gray.Lighten1,
                Background = "#121212", // Standard Material Dark Background
                AppbarBackground = "#1E1E1E",
                AppbarText = Colors.Gray.Lighten5,
                DrawerBackground = "#1E1E1E",
                Surface = "#1E1E1E", // Dark surface for cards/dialogs
                TextPrimary = Colors.Gray.Lighten5,
                TextSecondary = Colors.Gray.Lighten2,
                ActionDefault = Colors.Blue.Lighten1,
                LinesDefault = Colors.Gray.Darken1
            };

            LayoutProperties = new LayoutProperties()
            {
                DefaultBorderRadius = "6px"
            };

            Typography = new Typography()
            {
                Default = new DefaultTypography()
                {
                    FontFamily = new[] { "Inter", "sans-serif" },
                    FontSize = ".875rem",
                    FontWeight = "400",
                    LineHeight = "1.6"
                },
                H4 = new H4Typography()
                {
                    FontFamily = new[] { "Inter", "sans-serif" },
                    FontSize = "2.125rem",
                    FontWeight = "600",
                },
                H5 = new H5Typography()
                {
                    FontFamily = new[] { "Inter", "sans-serif" },
                    FontSize = "1.5rem",
                    FontWeight = "600",
                },
                H6 = new H6Typography()
                {
                    FontFamily = new[] { "Inter", "sans-serif" },
                    FontSize = "1.25rem",
                    FontWeight = "600",
                },
                Button = new ButtonTypography()
                {
                    FontFamily = new[] { "Inter", "sans-serif" },
                    FontWeight = "600",
                }
            };
        }
    }
}