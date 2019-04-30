using System;
using System.Threading;
using Xamarin.Forms;

namespace Plugin.Glypher.FontAwesome5Free
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
                    Brand = "Font Awesome 5 Brands-Regular-400.otf#Font Awesome 5 Brands Regular";
                    Regular = "Font Awesome 5 Free-Regular-400.otf#Font Awesome 5 Free Regular";
                    Solid = "Font Awesome 5 Free-Solid-900.otf#Font Awesome 5 Free Solid";
                    break;

                case Device.iOS:
                    Brand = "FontAwesome5Brands-Regular";
                    Regular = "FontAwesome5Free-Regular";
                    Solid = "FontAwesome5Free-Solid";
                    break;
            };
        }

        /// <summary>
        /// Gets the lazily initialized value of the current instance.
        /// </summary>
        public static GlyphFont Current => _mySingleton.Value;

        /// <summary>
        /// Brand font.
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Regular font.
        /// </summary>
        public string Regular { get; set; }

        /// <summary>
        /// Solid font.
        /// </summary>
        public string Solid { get; set; }
    }
}