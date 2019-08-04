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
            using (var reader = new StreamReader(@"icons.json"))
            {
                var iconJson = IconJson.FromJson(reader.ReadToEnd());
                var iconList = new List<Icon>();
                foreach (var icon in iconJson)
                {
                    iconList.AddRange(icon.Value.Styles.Select(styles =>
                        new Icon { IconType = styles, Label = icon.Key, Unicode = icon.Value.Unicode }));
                }

                const string folderPath = @"..\..\..\..\..\..\Source\Plugin.Glypher.FontAwesome5Pro";
                const string libName = @"Font Awesome Pro 5.10.0";
                const string libNamespace = @"FontAwesome5Pro";

                FieldGenerator.Write(
                    folderPath,
                    "Brand",
                    libName,
                    libNamespace,
                    iconList.Where(i => i.IconType == Free.Brands).Cast<GlyphField>().ToList());

                FieldGenerator.Write(
                    folderPath,
                    "Duotone",
                    libName,
                    libNamespace,
                    iconList.Where(i => i.IconType == Free.Duotone).Cast<GlyphField>().ToList());

                FieldGenerator.Write(
                    folderPath,
                    "Light",
                    libName,
                    libNamespace,
                    iconList.Where(i => i.IconType == Free.Light).Cast<GlyphField>().ToList());

                FieldGenerator.Write(
                    folderPath,
                    "Regular",
                    libName,
                    libNamespace,
                    iconList.Where(i => i.IconType == Free.Regular).Cast<GlyphField>().ToList());

                FieldGenerator.Write(
                    folderPath,
                    "Solid",
                    libName,
                    libNamespace,
                    iconList.Where(i => i.IconType == Free.Solid).Cast<GlyphField>().ToList());
            }
        }
    }
}