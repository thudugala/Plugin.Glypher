using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Glypher;
using Plugin.Glypher.FontAwesome5Free;
using Xamarin.Forms;

namespace Plugin.Glypher.Sample
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
            var toolbarItemLabelColor = Device.RuntimePlatform == Device.Android ? Color.White : Color.Black;

            ToolbarItemLabel.TextColor = ToolbarItemLabel.TextColor == toolbarItemLabelColor ? Color.GreenYellow : toolbarItemLabelColor;

            var oldValueLabel1 = FontGlyph.GetGlyph(Label1);
            FontGlyph.SetGlyph(Label1, oldValueLabel1 == GlyphListBrands.Fab_Bluetooth ? GlyphListBrands.Fab_Adobe : GlyphListBrands.Fab_Bluetooth);

            var oldValueLabel2 = FontGlyph.GetGlyph(Label2);
            FontGlyph.SetGlyph(Label2, oldValueLabel2 == GlyphListRegular.Far_Angry ? GlyphListRegular.Far_Address_Book : GlyphListRegular.Far_Angry);
        }
    }
}