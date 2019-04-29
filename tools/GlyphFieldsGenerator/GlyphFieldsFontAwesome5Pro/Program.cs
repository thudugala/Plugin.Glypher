using GlyphFieldsGenerator;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GlyphFieldsFontAwesome5Pro
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

            using (var file = new StreamWriter(@"icons.text"))
            {
                FieldGenerator.Current.WriteDisable1591(file);

                FieldGenerator.Current.WriteLine(file, "Brands", iconList.Where(i => i.IconType == Free.Brands).Cast<GlyphField>().ToList());
                FieldGenerator.Current.WriteLine(file, "Light", iconList.Where(i => i.IconType == Free.Light).Cast<GlyphField>().ToList());
                FieldGenerator.Current.WriteLine(file, "Regular", iconList.Where(i => i.IconType == Free.Regular).Cast<GlyphField>().ToList());
                FieldGenerator.Current.WriteLine(file, "Solid", iconList.Where(i => i.IconType == Free.Solid).Cast<GlyphField>().ToList());

                FieldGenerator.Current.WriteRestore1591(file);
            }
        }
    }
}