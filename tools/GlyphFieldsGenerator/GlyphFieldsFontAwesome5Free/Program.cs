using GlyphFieldsGenerator;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace GlyphFieldsFontAwesome5Free
{
    internal class Program
    {
        private const string FolderPath = @"..\..\..\..\..\..\Source\Plugin.Glypher.FontAwesome5Free";
        private const string LibName = @"Font Awesome Free 5.11.2";
        private const string LibNamespace = @"FontAwesome5Free";

        private static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"icons.json"))
            {
                var iconJson = JsonConvert.DeserializeObject<Dictionary<string, IconJson>>(reader.ReadToEnd(), Converter.Settings);
                var iconList = new List<Icon>();
                foreach (var icon in iconJson)
                {
                    iconList.AddRange(icon.Value.Styles.Select(styles =>
                        new Icon { IconType = styles, Label = icon.Key, Unicode = icon.Value.Unicode }));
                }

                FieldGenerator.Write(
                    FolderPath,
                    nameof(Free.Brands),
                    LibName,
                    LibNamespace,
                    iconList.Where(i => i.IconType == Free.Brands).Cast<GlyphField>().ToList());

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