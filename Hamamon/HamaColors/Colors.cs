using MudBlazor;

namespace Hamamon.HamaColors
{
    public class Colors
    {
        public static List<string> HamaStringColors =
        [
            "#ECEDED",
			"#F0E8B9",
			"#F0B901",
			"#E64F27",
			"#B63136",
			"#E1889F",
			"#694A82",
			"#2C468F",
			"#305CB0",
			"#256847",
			"#49AE89",
			"#534137",
			"#C02435",
			"#37B876",
			"#83888A",
			"#2F2F31",
			"#2E2F2E",
			"#313741",
			"#FF208D",
			"#FF3956",
			"#E5EF13",
			"#FF2833",
			"#2353B0",
			"#0CB73C",
			"#FD8600",
			"#F1F21C",
			"#FE636F",
			"#FFE763",
			"#265EEE",
			"#FF208D",
			"#FE635A",
			"#264CA8",
			"#0CB539",
			"#2E59B2",
			"#0CBD51",
			"#FDE600",
			"#FEE303",
			"#FE630B",
			"#2659B2",
			"#0CBDB1",
			"#88694B",
			"#FF593A",
			"#591F38",
			"#77A59A",
			"#403F40",
			"#CCAB93",
			"#F49422",
			"#B0B9BC",
			"#404040",
			"#B4B94A",
			"#8F2F36",
			"#DC9B90",
			"#DCB487"
        ];

		public static List<System.Drawing.Color> HamaColors
		{
            get
			{
                List<System.Drawing.Color> col = new List<System.Drawing.Color>();

                foreach (var color in HamaStringColors)
                {
                    col.Add(System.Drawing.ColorTranslator.FromHtml(color));
                }

				return col;
            }
		}
    }
}
