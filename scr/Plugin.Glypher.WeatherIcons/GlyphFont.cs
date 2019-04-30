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
                        return "weathericons-regular-webfont.ttf#Weather Icons Regular";

                    case Device.iOS:
                        return "WeatherIcons-Regular";

                    default:
                        return "";
                };
            }
        }
    }
}