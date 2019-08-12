using GlyphFieldsGenerator;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace GlyphFieldsFontAwesome5Pro
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"icons.json"))
            {
                var iconJsonDictionary = JsonConvert.DeserializeObject<Dictionary<string, IconJson>>(reader.ReadToEnd(), Converter.Settings);
                var iconList = new List<Icon>();
                foreach (var (name, iconJson) in iconJsonDictionary)
                {
                    iconList.AddRange(iconJson.Styles.Select(styles =>
                        new Icon
                        {
                            IconType = styles,
                            Label = name,
                            Unicode = iconJson.Unicode
                        }));
                }

                var iconDuotoneList = iconList.Where(i => i.IconType == Free.Duotone);
                var iconDuotoneSecondaryList = new List<Icon>();
                foreach (var iconDuotone in iconDuotoneList)
                {
                    var originalLabel = iconDuotone.Label;
                    iconDuotone.Label = $"{originalLabel}-primary";

                    iconDuotoneSecondaryList.Add(
                        new Icon
                        {
                            IconType = iconDuotone.IconType,
                            Label = $"{originalLabel}-secondary",
                            Unicode = $"10{iconDuotone.Unicode}"
                        });
                }

                iconList.AddRange(iconDuotoneSecondaryList);

                const string folderPath = @"..\..\..\..\..\..\Source\Plugin.Glypher.FontAwesome5Pro";
                const string libName = @"Font Awesome Pro 5.10.1";
                const string libNamespace = @"FontAwesome5Pro";

                FieldGenerator.Write(
                    folderPath,
                    nameof(Free.Brands),
                    libName,
                    libNamespace,
                    iconList.Where(i => i.IconType == Free.Brands).Cast<GlyphField>().ToList());

                FieldGenerator.Write(
                    folderPath,
                    nameof(Free.Duotone),
                    libName,
                    libNamespace,
                    iconList.Where(i => i.IconType == Free.Duotone).Cast<GlyphField>().ToList());

                FieldGenerator.Write(
                    folderPath,
                    nameof(Free.Light),
                    libName,
                    libNamespace,
                    iconList.Where(i => i.IconType == Free.Light).Cast<GlyphField>().ToList());

                FieldGenerator.Write(
                    folderPath,
                    nameof(Free.Regular),
                    libName,
                    libNamespace,
                    iconList.Where(i => i.IconType == Free.Regular).Cast<GlyphField>().ToList());

                FieldGenerator.Write(
                    folderPath,
                    nameof(Free.Solid),
                    libName,
                    libNamespace,
                    iconList.Where(i => i.IconType == Free.Solid).Cast<GlyphField>().ToList());
            }
        }
    }
}