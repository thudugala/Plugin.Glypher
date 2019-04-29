using System.Globalization;

namespace GlyphFieldsGenerator
{
    public abstract class GlyphField
    {
        public virtual string Label { get; set; }

        public virtual string Unicode { get; set; }

        protected virtual string Prefix { get; }

        protected virtual string FontFamily { get; }
        
        protected virtual string Glyph => $"\"\\u{Unicode}\"";

        protected virtual string GlyphName => string.IsNullOrWhiteSpace(Prefix) ? $"\"{Label}\"" : $"\"{Prefix}-{Label}\"";

        protected virtual string GlyphPropertyName
        {
            get
            {
                var glyphProperty = string.IsNullOrWhiteSpace(Prefix) ? $"{Label}" : $"{Prefix}-{Label}";
                if (string.IsNullOrWhiteSpace(glyphProperty))
                {
                    return string.Empty;
                }

                var txtInfo = CultureInfo.InvariantCulture.TextInfo;
                return txtInfo.ToTitleCase(glyphProperty).Replace("-", "_");
            }
        }

        public override string ToString()
        {
            return $"public static readonly GlyphInfo {GlyphPropertyName} = new GlyphInfo {{ Name = {GlyphName}, Glyph = {Glyph}, FontFamily = {FontFamily}}};";
        }
    }
}