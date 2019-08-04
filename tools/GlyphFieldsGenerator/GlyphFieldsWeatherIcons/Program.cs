using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using GlyphFieldsGenerator;

namespace GlyphFieldsWeatherIcons
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"weathericons.xml"))
            {
                var serializer = new XmlSerializer(typeof(IconXmlResources));
                var iconXml = (IconXmlResources)serializer.Deserialize(reader);

                var iconList = new List<Icon>();
                foreach (var icon in iconXml.IconXmlList)
                {
                    iconList.Add(new Icon { Label = icon.Name, Unicode = icon.Text });
                }

                FieldGenerator.Write(@"..\..\..\..\..\..\Source\Plugin.Glypher.WeatherIcons",
                    null,
                    "Weather Icons 2.0.10",
                    "WeatherIcons",
                    iconList.Cast<GlyphField>().ToList());
            }
        }
    }
}