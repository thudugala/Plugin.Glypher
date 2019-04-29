using Xamarin.Forms;

namespace Plugin.Glypher.FontAwesome5Pro
{
    /// <summary>
    /// Font Awesome 5 Pro fonts
    /// </summary>
    public static class GlyphFont
    {
        /// <summary>
        /// Brand font.
        /// </summary>
        public static string Brand
        {
            get
            {
                switch (Device.RuntimePlatform)
                {
                    case Device.Android:
                        return "Font Awesome 5 Brands-Regular-400.otf#Font Awesome 5 Brands Regular";

                    case Device.iOS:
                        return "FontAwesome5Brand-Regular";

                    default:
                        return "";
                };
            }
        }

        /// <summary>
        /// Light font
        /// </summary>
        public static string Light
        {
            get
            {
                switch (Device.RuntimePlatform)
                {
                    case Device.Android:
                        return "Font Awesome 5 Pro-Light-300.otf#Font Awesome 5 Pro Light";

                    case Device.iOS:
                        return "FontAwesome5Pro-Light";

                    default:
                        return "";
                };
            }
        }

        /// <summary>
        /// Regular font.
        /// </summary>
        public static string Regular
        {
            get
            {
                switch (Device.RuntimePlatform)
                {
                    case Device.Android:
                        return "Font Awesome 5 Pro-Regular-400.otf#Font Awesome 5 Pro Regular";

                    case Device.iOS:
                        return "FontAwesome5Pro-Regular";

                    default:
                        return "";
                };
            }
        }

        /// <summary>
        /// Solid font.
        /// </summary>
        public static string Solid
        {
            get
            {
                switch (Device.RuntimePlatform)
                {
                    case Device.Android:
                        return "Font Awesome 5 Pro-Solid-900.otf#Font Awesome 5 Pro Solid";

                    case Device.iOS:
                        return "FontAwesome5Pro-Solid";

                    default:
                        return "";
                };
            }
        }
    }
}