using System;
using Plugin.Glypher;
using Plugin.Glypher.FontAwesome5Free;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            GlyphList.Fas_Redo.FontFamily = "FontAwesome5Free-Solid";
            GlyphList.Fab_Bluetooth.FontFamily = "FontAwesome5Brands-Regular";
            GlyphList.Far_Angry.FontFamily = "FontAwesome5Free-Regular";
            GlyphList.Fab_Bitcoin.FontFamily = "FontAwesome5Brands-Regular";

            GlyphRegister.Current.Init(typeof(GlyphList));

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
