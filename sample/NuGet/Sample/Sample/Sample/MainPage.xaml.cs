using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Glypher;
using Plugin.Glypher.FontAwesome5Free;
using Xamarin.Forms;

namespace Sample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Redo_Tapped(object sender, EventArgs e)
        {
            var oldValueLabel1 = FontGlyph.GetGlyph(Label1);
            FontGlyph.SetGlyph(Label1, oldValueLabel1 == GlyphList.Fab_Bluetooth ? GlyphList.Fab_Adobe : GlyphList.Fab_Bluetooth);

            var oldValueLabel2 = FontGlyph.GetGlyph(Label2);
            FontGlyph.SetGlyph(Label2, oldValueLabel2 == GlyphList.Far_Angry ? GlyphList.Far_Address_Book : GlyphList.Far_Angry);
        }
    }
}
