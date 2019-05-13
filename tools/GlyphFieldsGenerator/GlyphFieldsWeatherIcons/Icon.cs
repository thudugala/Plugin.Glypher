using System;
using System.Collections.Generic;
using System.Text;
using GlyphFieldsGenerator;

namespace GlyphFieldsWeatherIcons
{
    internal class Icon : GlyphField
    {
        protected override string FontFamily => "GlyphFont.Current.WI";
        
        public override string Unicode
        {
            get => base.Unicode;
            set
            {
                var intValue = (int) value[0];
                base.Unicode = $"{intValue:x4}";
            }
        }

        public override string Label
        {
            get => base.Label;
            set => base.Label = value.Replace("_", "-");
        }
    }
}
