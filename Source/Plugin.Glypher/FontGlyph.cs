using Xamarin.Forms;

namespace Plugin.Glypher
{
    /// <summary>
    /// Has the Attached Property Glyph for Labels and Buttons
    /// </summary>
    public static class FontGlyph
    {
        /// <summary>
        /// Glyph Attached Property
        /// </summary>
        public static readonly BindableProperty GlyphProperty =
            BindableProperty.CreateAttached("Glyph", typeof(GlyphInfo), typeof(FontGlyph), null, propertyChanged: OnGlyphChanged);

        /// <summary>
        /// set Glyph
        /// </summary>
        /// <param name="bindable"></param>
        /// <returns></returns>
        public static GlyphInfo GetGlyph(BindableObject bindable)
        {
            return (GlyphInfo)bindable?.GetValue(GlyphProperty);
        }

        /// <summary>
        /// Internal use only
        /// </summary>
        /// <param name="bindable"></param>
        /// <param name="oldValue"></param>
        /// <param name="newValue"></param>
        public static void OnGlyphChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(newValue is GlyphInfo newGlyphInfo))
            {
                SetControl(bindable, null);
                return;
            }
            SetControl(bindable, newGlyphInfo);
        }

        /// <summary>
        /// get Glyph
        /// </summary>
        /// <param name="bindable"></param>
        /// <param name="value"></param>
        public static void SetGlyph(BindableObject bindable, GlyphInfo value) => bindable?.SetValue(GlyphProperty, value);

        private static void SetControl(BindableObject bindable, GlyphInfo newGlyphInfo)
        {
            switch (bindable)
            {
                case Label label:
                    label.FontFamily = newGlyphInfo?.FontFamily;
                    label.Text = newGlyphInfo?.Glyph;
                    break;

                case Span span:
                    span.FontFamily = newGlyphInfo?.FontFamily;
                    span.Text = newGlyphInfo?.Glyph;
                    break;

                case Button button:
                    button.FontFamily = newGlyphInfo?.FontFamily;
                    button.Text = newGlyphInfo?.Glyph;
                    break;

                case FontImageSource fontImageSource:
                    fontImageSource.FontFamily = newGlyphInfo?.FontFamily;
                    fontImageSource.Glyph = newGlyphInfo?.Glyph;
                    break;
            }
        }
    }
}