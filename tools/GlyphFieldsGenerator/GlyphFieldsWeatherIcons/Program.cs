using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using GlyphFieldsGenerator;

namespace GlyphFieldsWeatherIcons
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader(@"weathericons.xml");

            var serializer = new XmlSerializer(typeof(IconXmlResources));
            var iconXml = (IconXmlResources)serializer.Deserialize(reader);
           
            var iconList = new List<Icon>();
            foreach (var icon in iconXml.IconXmlList)
            {
                iconList.Add(new Icon { Label = icon.Name, Unicode = icon.Text });
            }

            using (var file = new StreamWriter(@"icons.text"))
            {
                FieldGenerator.Current.WriteDisable1591(file);

                FieldGenerator.Current.WriteLine(file, null, iconList.Cast<GlyphField>().ToList());

                FieldGenerator.Current.WriteRestore1591(file);
            }
        }
    }
}
