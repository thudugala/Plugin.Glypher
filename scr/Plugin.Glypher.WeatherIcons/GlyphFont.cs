using Xamarin.Forms;

namespace Plugin.Glypher.WeatherIcons
{
    /// <summary>
    /// Font Awesome 5 Pro fonts
    /// </summary>
    public static class GlyphFont
    {
        /// <summary>
        /// WI font.
        /// </summary>
        public static string WI
        {
            get
            {
                switch (Device.RuntimePlatform)
                {
                    case Device.Android:
                        return "weathericons-regular-webfont.woff2#Weather Icons";

                    case Device.iOS:
                        return "Weather Icons";

                    default:
                        return "";
                };
            }
        }
    }
}