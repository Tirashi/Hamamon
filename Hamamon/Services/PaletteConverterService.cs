using Hamamon.HamaColors;

namespace Hamamon.Services
{
    public class PaletteConverterService
    {
        public List<string> ConvertToHamaColorByHue(List<string> colors)
        {
            List<string> res = [];
            
            foreach (string color in colors)
            {
                var col = System.Drawing.ColorTranslator.FromHtml(color);
                var id = ColorSearcher.ClosestHueColor(Colors.HamaColors, col);

                res.Add(Colors.HamaStringColors[id]);
            }

            return res;
        }

        public List<string> ConvertToHamaColorByRGB(List<string> colors)
        {
            List<string> res = [];

            foreach (string color in colors)
            {
                var col = System.Drawing.ColorTranslator.FromHtml(color);
                var id = ColorSearcher.ClosestRGBColor(Colors.HamaColors, col);

                res.Add(Colors.HamaStringColors[id]);
            }

            return res;
        }
    }
}
