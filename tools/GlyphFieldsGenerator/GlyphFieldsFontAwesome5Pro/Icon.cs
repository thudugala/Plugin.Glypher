using GlyphFieldsGenerator;

namespace GlyphFieldsFontAwesome5Pro
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

                    case Free.Light:
                        return $"GlyphFont.Current.{nameof(Free.Light)}";

                    case Free.Regular:
                        return $"GlyphFont.Current.{nameof(Free.Regular)}";

                    case Free.Solid:
                        return $"GlyphFont.Current.{nameof(Free.Solid)}";

                    case Free.Duotone:
                        return $"GlyphFont.Current.{nameof(Free.Duotone)}";

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

                    case Free.Light:
                        return "fal";

                    case Free.Regular:
                        return "far";

                    case Free.Solid:
                        return "fas";

                    case Free.Duotone:
                        return "fad";

                    default:
                        return null;
                }
            }
        }
    }
}