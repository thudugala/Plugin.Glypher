using GlyphFieldsGenerator;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GlyphFieldsFontAwesome5Free
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var reader = new StreamReader(@"icons.json");

            var iconJson = IconJson.FromJson(reader.ReadToEnd());
            var iconList = new List<Icon>();
            foreach (var icon in iconJson)
            {
                iconList.AddRange(icon.Value.Styles.Select(styles => new Icon { IconType = styles, Label = icon.Key, Unicode = icon.Value.Unicode }));
            }

            using (var file = new StreamWriter(@"iconsBrands.text"))
            {
                FieldGenerator.Current.WriteLine(file, "Brands",
                    iconList.Where(i => i.IconType == Free.Brands).Cast<GlyphField>().ToList());
            }

            using (var file = new StreamWriter(@"iconsRegular.text"))
            {
                FieldGenerator.Current.WriteLine(file, "Regular",
                    iconList.Where(i => i.IconType == Free.Regular).Cast<GlyphField>().ToList());
            }

            using (var file = new StreamWriter(@"iconsSolid.text"))
            {
                FieldGenerator.Current.WriteLine(file, "Solid",
                    iconList.Where(i => i.IconType == Free.Solid).Cast<GlyphField>().ToList());
            }
        }
    }
}