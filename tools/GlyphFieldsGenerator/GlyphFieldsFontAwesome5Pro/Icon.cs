﻿using GlyphFieldsGenerator;

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
                        return "GlyphFont.Current.Brand";

                    case Free.Light:
                        return "GlyphFont.Current.Light";

                    case Free.Regular:
                        return "GlyphFont.Current.Regular";

                    case Free.Solid:
                        return "GlyphFont.Current.Solid";

                    case Free.Duotone:
                        return "GlyphFont.Current.Duotone";

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