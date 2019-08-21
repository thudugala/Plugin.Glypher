using System.ComponentModel;
using System.Diagnostics;

namespace Plugin.Glypher
{
    /// <summary>
    /// Font Image representation.
    /// </summary>
    [DebuggerDisplay("Name={Name}")]
    [TypeConverter(typeof(GlyphInfoTypeConverter))]
    public class GlyphInfo
    {
        private string _glyph;

        /// <summary>
        /// Font Family.
        /// </summary>
        public string FontFamily { get; set; }

        /// <summary>
        /// Glyph
        /// </summary>
        public string Glyph
        {
            get => UnicodeNumber.HasValue ? char.ConvertFromUtf32(UnicodeNumber.Value) : _glyph;
            set => _glyph = value;
        }

        /// <summary>
        /// Glyph Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Unicode Number
        /// </summary>
        public int? UnicodeNumber { get; set; }
    }
}