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
        /// <summary>
        /// Font Family.
        /// </summary>
        public string FontFamily { get; set; }
        
        /// <summary>
        /// Glyph
        /// </summary>
        public string Glyph { get; set; }

        /// <summary>
        /// Glyph Name
        /// </summary>
        public string Name { get; set; }
    }
}