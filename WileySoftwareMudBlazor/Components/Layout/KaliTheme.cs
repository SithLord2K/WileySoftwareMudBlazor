using MudBlazor;
using MudBlazor.Utilities;
using System;
using static MudBlazor.CategoryTypes;

public class KaliTheme : MudTheme
{
    public KaliTheme()
    {
        PaletteLight = new PaletteLight()
        {
            // The iconic "hacker green"
            Primary = new MudColor("#4AE02C"),
            PrimaryContrastText = new MudColor("#1c1c1e"),

            // A secondary color for links, directories, etc.
            Secondary = new MudColor("#00BCD4"),
            SecondaryContrastText = new MudColor("#1c1c1e"),

            // A tertiary color, can be used for other accents
            Tertiary = new MudColor("#9C27B0"),

            // Standard terminal colors
            Info = new MudColor("#00BCD4"), // Cyan
            Success = new MudColor("#4AE02C"), // Green
            Warning = new MudColor("#FFD600"), // Yellow
            Error = new MudColor("#F44336"), // Red

            // Background and Surfaces
            Background = new MudColor("#1c1c1e"), // Very dark charcoal, not pure black
            AppbarBackground = new MudColor("#1c1c1e"),
            DrawerBackground = new MudColor("#1c1c1e"),
            Surface = new MudColor("#2c2c2e"), // Slightly lighter for cards, etc.

            // Text and Lines
            TextPrimary = new MudColor("#E0E0E0"), // Off-white for readability
            TextSecondary = new MudColor("#BDBDBD"),
            TextDisabled = new MudColor("#757575"),
            LinesDefault = new MudColor("#555555"),
            LinesInputs = new MudColor("#757575"),

            // Action Colors
            ActionDefault = new MudColor("#BDBDBD"),
            ActionDisabled = new MudColor("#757575"),
            ActionDisabledBackground = new MudColor("#555555"),

            // Greys
            Black = "#1c1c1e",
            White = "#ffffff",
            Dark = new MudColor("#333333"),

        };

        LayoutProperties = new LayoutProperties()
        {
            DefaultBorderRadius = "0px", // Sharp, square corners like a terminal window
            DrawerWidthLeft = "260px",
            DrawerWidthRight = "300px"
        };

        Typography = new Typography()
        {
            Default = new DefaultTypography()
            {
                FontFamily = new[] { "Fira Code", "Hack", "monospace" },
                FontSize = ".875rem",
                FontWeight = "400",
                LineHeight = "1.6",
                LetterSpacing = ".02em"
            },
            H1 = new H1Typography()
            {
                FontFamily = new[] { "Fira Code", "Hack", "monospace" },
                FontSize = "2.5rem",
                FontWeight = "700",
                LineHeight = "1.2"
            },
            // You can continue to define H2, H3, etc. if needed
            Button = new ButtonTypography()
            {
                FontFamily = new[] { "Fira Code", "Hack", "monospace" },
                FontWeight = "600",
                TextTransform = "none" // Buttons look more "terminal-like" without all-caps
            },
            Body1 = new Body1Typography()
            {
                FontFamily = new[] { "Fira Code", "Hack", "monospace" },
                FontSize = ".875rem"
            },
            Caption = new CaptionTypography()
            {
                FontFamily = new[] { "Fira Code", "Hack", "monospace" },
                FontSize = ".75rem"
            }
        };

        // Terminals are flat. We remove all shadows.
        Shadows = new Shadow();
    }
}