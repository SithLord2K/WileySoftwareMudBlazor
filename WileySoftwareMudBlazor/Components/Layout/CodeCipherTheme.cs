using MudBlazor;

namespace WileySoftwareMudBlazor.Components.Layout
{
    public class CodeCipherTheme : MudTheme
    {
        public CodeCipherTheme()
        {
            PaletteLight = new PaletteLight()
            {
                Primary = "#007BFF",
                PrimaryContrastText = "#0A192F",
                Background = "#0A192F",
                Surface = "#112240",
                TextPrimary = "#CCD6F6",
                TextSecondary = "#8892B0",
                AppbarBackground = "#0A192F",
                AppbarText = "#CCD6F6",
                LinesDefault = "#303C55",
                ActionDefault = "#007BFF"
            };

            Typography = new Typography()
            {
                Default = new DefaultTypography()
                {
                    FontFamily = new[] { "Inter", "sans-serif" }
                },
                H1 = new H1Typography()
                {
                    FontFamily = new[] { "Fira Code", "monospace" }
                },
                H2 = new H2Typography()
                {
                    FontFamily = new[] { "Fira Code", "monospace" }
                },
                H3 = new H3Typography()
                {
                    FontFamily = new[] { "Fira Code", "monospace" }
                },
                H4 = new H4Typography()
                {
                    FontFamily = new[] { "Fira Code", "monospace" }
                },
                H5 = new H5Typography()
                {
                    FontFamily = new[] { "Fira Code", "monospace" }
                },
                H6 = new H6Typography()
                {
                    FontFamily = new[] { "Fira Code", "monospace" }
                },
            };

            LayoutProperties = new LayoutProperties()
            {
                DefaultBorderRadius = "6px"
            };
        }
    }
}