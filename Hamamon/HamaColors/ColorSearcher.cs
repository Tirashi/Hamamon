namespace Hamamon.HamaColors
{
    public class ColorSearcher
    {
        /// <summary>
        /// Search the closest match for hues only.
        /// </summary>
        /// <param name="colors">The list where choose a color.</param>
        /// <param name="target">The target color.</param>
        /// <returns>The ID of the closest color in the list.</returns>
        public static int ClosestHueColor(List<System.Drawing.Color> colors, System.Drawing.Color target)
        {
            var hue1 = target.GetHue();
            var diffs = colors.Select(n => getHueDistance(n.GetHue(), hue1));
            var diffMin = diffs.Min(n => n);
            return diffs.ToList().FindIndex(n => n == diffMin);
        }

        /// <summary>
        /// Search the closest match in RGB space.
        /// </summary>
        /// <param name="colors">The list where choose a color.</param>
        /// <param name="target">The target color.</param>
        /// <returns>The ID of the closest color in the list.</returns>
        public static int ClosestRGBColor(List<System.Drawing.Color> colors, System.Drawing.Color target)
        {
            var colorDiffs = colors.Select(n => ColorDiff(n, target)).Min(n => n);
            return colors.FindIndex(n => ColorDiff(n, target) == colorDiffs);
        }

        // color brightness as perceived:
        public static float GetBrightness(System.Drawing.Color c)
        { return (c.R * 0.299f + c.G * 0.587f + c.B * 0.114f) / 256f; }

        // distance between two hues:
        public static float getHueDistance(float hue1, float hue2)
        {
            float d = Math.Abs(hue1 - hue2); return d > 180 ? 360 - d : d;
        }

        // distance in RGB space
        public static int ColorDiff(System.Drawing.Color c1, System.Drawing.Color c2)
        {
            return (int)Math.Sqrt((c1.R - c2.R) * (c1.R - c2.R)
                                 + (c1.G - c2.G) * (c1.G - c2.G)
                                 + (c1.B - c2.B) * (c1.B - c2.B));
        }

    }
}
