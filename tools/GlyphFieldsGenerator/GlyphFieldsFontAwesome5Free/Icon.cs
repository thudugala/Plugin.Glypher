using GlyphFieldsGenerator;

namespace GlyphFieldsFontAwesome5Free
{
    internal class Icon : GlyphField
    {
        public Free IconType { get; set; }

        protected override string FontFamily
        {
            get
            {
                switch (IconType)
                {
                    case Free.Brands:
                        return $"GlyphFont.Current.{nameof(Free.Brands)}";

                    case Free.Regular:
                        return $"GlyphFont.Current.{nameof(Free.Regular)}";

                    case Free.Solid:
                        return $"GlyphFont.Current.{nameof(Free.Solid)}";

                    default:
                        return null;
                }
            }
        }

        protected override string Prefix
        {
            get
            {
                switch (IconType)
                {
                    case Free.Brands:
                        return "fab";

                    case Free.Regular:
                        return "far";

                    case Free.Solid:
                        return "fas";

                    default:
                        return null;
                }
            }
        }
    }
}