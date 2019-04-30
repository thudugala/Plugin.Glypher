using System;
using System.Threading;
using Xamarin.Forms;

namespace Plugin.Glypher.FontAwesome5Pro
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
                    Light = "Font Awesome 5 Pro-Light-300.otf#Font Awesome 5 Pro Light";
                    Regular = "Font Awesome 5 Pro-Regular-400.otf#Font Awesome 5 Pro Regular";
                    Solid = "Font Awesome 5 Pro-Solid-900.otf#Font Awesome 5 Pro Solid";
                    break;

                case Device.iOS:
                    Brand = "FontAwesome5Brands-Regular";
                    Light = "FontAwesome5Pro-Light";
                    Regular = "FontAwesome5Pro-Regular";
                    Solid = "FontAwesome5Pro-Solid";
                    break;
            };
        }

        /// <summary>
        /// Gets the lazily initialized value of the current instance.
        /// </summary>
        public static GlyphFont Current => _mySingleton.Value;

        /// <summary>
        /// Solid font.
        /// </summary>
        public static string Solid { get; set; }

        /// <summary>
        /// Brand font.
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Light font
        /// </summary>
        public string Light { get; set; }

        /// <summary>
        /// Regular font.
        /// </summary>
        public string Regular { get; set; }
    }
}