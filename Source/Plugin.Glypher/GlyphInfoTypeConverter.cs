using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Plugin.Glypher
{
    /// <summary>
    /// Convert Glyph name to GlyphInfo.
    /// </summary>
    [TypeConversion(typeof(GlyphInfo))]
    //[ProvideCompiled("Abel.FontAwesome.GlyphInfoTypeConverter")]
    public class GlyphInfoTypeConverter : TypeConverter
    {
        /// <inheritdoc />
        public override object ConvertFromInvariantString(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? null : GlyphRegister.Current.GetGlyph(value);
        }
    }
}