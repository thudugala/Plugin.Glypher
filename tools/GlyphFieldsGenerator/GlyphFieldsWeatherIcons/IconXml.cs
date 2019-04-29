/* 
 Licensed under the Apache License, Version 2.0
 
 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace GlyphFieldsWeatherIcons
{
    [XmlRoot(ElementName = "string")]
    public class IconXml
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "resources")]
    public class IconXmlResources
    {
        [XmlElement(ElementName = "string")]
        public List<IconXml> IconXmlList { get; set; }
    }

}

