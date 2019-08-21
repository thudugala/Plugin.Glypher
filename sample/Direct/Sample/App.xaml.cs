using System;
using Plugin.Glypher;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Plugin.Glypher.Sample
{
    public partial class App : Application
    {
        public App()
        {
            //If you want to change Font Name
            //ChangeFontName();

            //GlyphRegister.Current.Init(typeof(Plugin.Glypher.FontAwesome5Pro.GlyphListBrands));
            //GlyphRegister.Current.Init(typeof(Plugin.Glypher.FontAwesome5Pro.GlyphListDuotone));
            //GlyphRegister.Current.Init(typeof(Plugin.Glypher.FontAwesome5Pro.GlyphListLight));
            //GlyphRegister.Current.Init(typeof(Plugin.Glypher.FontAwesome5Pro.GlyphListRegular));
            //GlyphRegister.Current.Init(typeof(Plugin.Glypher.FontAwesome5Pro.GlyphListSolid));
            GlyphRegister.Current.Init(typeof(Plugin.Glypher.FontAwesome5Free.GlyphListBrands));
            GlyphRegister.Current.Init(typeof(Plugin.Glypher.FontAwesome5Free.GlyphListRegular));
            GlyphRegister.Current.Init(typeof(Plugin.Glypher.FontAwesome5Free.GlyphListSolid));
            GlyphRegister.Current.Init(typeof(Plugin.Glypher.WeatherIcons.GlyphList));

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        /// <summary>
        /// If you want to change Font Name
        /// </summary>
        private void ChangeFontName()
        {
            var glyphFont = Plugin.Glypher.FontAwesome5Free.GlyphFont.Current;
            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    glyphFont.Brands = "fontAwesomeBrands.ttf#Font Awesome 5 Brands Regular";
                    glyphFont.Regular = "fontAwesomeRegular.ttf#Font Awesome 5 Free Regular";
                    glyphFont.Solid = "fontAwesomeSolid.ttf#Font Awesome 5 Free Solid";
                    break;
            };
        }
    }
}