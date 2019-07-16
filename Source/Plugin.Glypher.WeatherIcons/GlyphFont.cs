using System;
using System.Threading;
using Xamarin.Forms;

namespace Plugin.Glypher.WeatherIcons
{
    /// <summary>
    /// Font Awesome 5 Pro fonts
    /// </summary>
    public class GlyphFont
    {
        private static readonly Lazy<GlyphFont> _mySingleton = new Lazy<GlyphFont>(() => new GlyphFont(), LazyThreadSafetyMode.PublicationOnly);

        /// <summary>
        /// Internal use only
        /// </summary>
        protected GlyphFont()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    WI = "weathericons-regular-webfont.ttf#Weather Icons Regular";
                    break;

                case Device.iOS:
                    WI = "WeatherIcons-Regular";
                    break;
            };
        }

        /// <summary>
        /// Gets the lazily initialized value of the current instance.
        /// </summary>
        public static GlyphFont Current => _mySingleton.Value;

        /// <summary>
        /// WI font.
        /// </summary>
        public string WI { get; set; }
    }
}