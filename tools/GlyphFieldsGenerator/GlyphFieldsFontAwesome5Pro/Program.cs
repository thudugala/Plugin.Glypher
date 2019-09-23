using GlyphFieldsGenerator;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace GlyphFieldsFontAwesome5Pro
{
    internal class Program
    {
        private const string FolderPath = @"..\..\..\..\..\..\Source\Plugin.Glypher.FontAwesome5Pro";
        private const string LibName = @"Font Awesome Pro 5.11.2";
        private const string LibNamespace = @"FontAwesome5Pro";

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

                    iconDuotoneSecondaryList.Add(new Icon
                    {
                        IconType = iconDuotone.IconType,
                        Label = $"{originalLabel}-secondary",
                        UnicodeNumber = int.Parse($"0010{iconDuotone.Unicode}",
                            System.Globalization.NumberStyles.HexNumber),
                    });
                }

                iconList.AddRange(iconDuotoneSecondaryList);

                FieldGenerator.Write(
                    FolderPath,
                    nameof(Free.Brands),
                    LibName,
                    LibNamespace,
                    iconList.Where(i => i.IconType == Free.Brands).Cast<GlyphField>().ToList());

                FieldGenerator.Write(
                    FolderPath,
                    nameof(Free.Duotone),
                    LibName,
                    LibNamespace,
                    iconList.Where(i => i.IconType == Free.Duotone).Cast<GlyphField>().ToList());

                FieldGenerator.Write(
                    FolderPath,
                    nameof(Free.Light),
                    LibName,
                    LibNamespace,
                    iconList.Where(i => i.IconType == Free.Light).Cast<GlyphField>().ToList());

                FieldGenerator.Write(
                    FolderPath,
                    nameof(Free.Regular),
                    LibName,
                    LibNamespace,
                    iconList.Where(i => i.IconType == Free.Regular).Cast<GlyphField>().ToList());

                FieldGenerator.Write(
                    FolderPath,
                    nameof(Free.Solid),
                    LibName,
                    LibNamespace,
                    iconList.Where(i => i.IconType == Free.Solid).Cast<GlyphField>().ToList());
            }
        }
    }
}