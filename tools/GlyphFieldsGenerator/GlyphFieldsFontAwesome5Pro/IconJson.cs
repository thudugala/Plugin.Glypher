﻿namespace GlyphFieldsFontAwesome5Pro
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public enum ChangeEnum { The31, The32, The41, The42, The43, The44, The45, The46, The47, The500, The501, The5010, The5011, The5012, The5013, The502, The503, The505, The507, The509, The510, The5100, The5101, The5102, The511, The5110, The5111, The5112, The520, The530, The540, The541, The542, The550, The560, The561, The563, The570, The571, The580, The581, The582, The590 };

    public enum Free { Brands, Duotone, Light, Regular, Solid };

    public partial struct ChangeElement
    {
        public ChangeEnum? Enum;
        public long? Integer;

        public static implicit operator ChangeElement(ChangeEnum Enum) => new ChangeElement { Enum = Enum };

        public static implicit operator ChangeElement(long Integer) => new ChangeElement { Integer = Integer };
    }

    public partial struct Term
    {
        public long? Integer;
        public string String;

        public static implicit operator Term(long Integer) => new Term { Integer = Integer };

        public static implicit operator Term(string String) => new Term { String = String };
    }

    public partial class Brands
    {
        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("last_modified")]
        public long LastModified { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("raw")]
        public string Raw { get; set; }

        [JsonProperty("viewBox")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public long[] ViewBox { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }
    }

    public partial class Duotone
    {
        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("last_modified")]
        public long LastModified { get; set; }

        [JsonProperty("path")]
        public string[] Path { get; set; }

        [JsonProperty("raw")]
        public string Raw { get; set; }

        [JsonProperty("viewBox")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public long[] ViewBox { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }
    }

    public partial class IconJson
    {
        [JsonProperty("changes")]
        public ChangeElement[] Changes { get; set; }

        [JsonProperty("free")]
        public Free[] Free { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("ligatures")]
        public string[] Ligatures { get; set; }

        [JsonProperty("private", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Private { get; set; }

        [JsonProperty("search")]
        public Search Search { get; set; }

        [JsonProperty("styles")]
        public Free[] Styles { get; set; }

        [JsonProperty("svg")]
        public Svg Svg { get; set; }

        [JsonProperty("unicode")]
        public string Unicode { get; set; }

        [JsonProperty("voted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Voted { get; set; }
    }

    public partial class Search
    {
        [JsonProperty("terms")]
        public Term[] Terms { get; set; }
    }

    public partial class Svg
    {
        [JsonProperty("brands", NullValueHandling = NullValueHandling.Ignore)]
        public Brands Brands { get; set; }

        [JsonProperty("duotone", NullValueHandling = NullValueHandling.Ignore)]
        public Duotone Duotone { get; set; }

        [JsonProperty("light", NullValueHandling = NullValueHandling.Ignore)]
        public Brands Light { get; set; }

        [JsonProperty("regular", NullValueHandling = NullValueHandling.Ignore)]
        public Brands Regular { get; set; }

        [JsonProperty("solid", NullValueHandling = NullValueHandling.Ignore)]
        public Brands Solid { get; set; }
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ChangeElementConverter.Singleton,
                ChangeEnumConverter.Singleton,
                FreeConverter.Singleton,
                TermConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ChangeElementConverter : JsonConverter
    {
        public static readonly ChangeElementConverter Singleton = new ChangeElementConverter();

        public override bool CanConvert(Type t) => t == typeof(ChangeElement) || t == typeof(ChangeElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "3.1":
                            return new ChangeElement { Enum = ChangeEnum.The31 };

                        case "3.2":
                            return new ChangeElement { Enum = ChangeEnum.The32 };

                        case "4.1":
                            return new ChangeElement { Enum = ChangeEnum.The41 };

                        case "4.2":
                            return new ChangeElement { Enum = ChangeEnum.The42 };

                        case "4.3":
                            return new ChangeElement { Enum = ChangeEnum.The43 };

                        case "4.4":
                            return new ChangeElement { Enum = ChangeEnum.The44 };

                        case "4.5":
                            return new ChangeElement { Enum = ChangeEnum.The45 };

                        case "4.6":
                            return new ChangeElement { Enum = ChangeEnum.The46 };

                        case "4.7":
                            return new ChangeElement { Enum = ChangeEnum.The47 };

                        case "5.0.0":
                            return new ChangeElement { Enum = ChangeEnum.The500 };

                        case "5.0.1":
                            return new ChangeElement { Enum = ChangeEnum.The501 };

                        case "5.0.10":
                            return new ChangeElement { Enum = ChangeEnum.The5010 };

                        case "5.0.11":
                            return new ChangeElement { Enum = ChangeEnum.The5011 };

                        case "5.0.12":
                            return new ChangeElement { Enum = ChangeEnum.The5012 };

                        case "5.0.13":
                            return new ChangeElement { Enum = ChangeEnum.The5013 };

                        case "5.0.2":
                            return new ChangeElement { Enum = ChangeEnum.The502 };

                        case "5.0.3":
                            return new ChangeElement { Enum = ChangeEnum.The503 };

                        case "5.0.5":
                            return new ChangeElement { Enum = ChangeEnum.The505 };

                        case "5.0.7":
                            return new ChangeElement { Enum = ChangeEnum.The507 };

                        case "5.0.9":
                            return new ChangeElement { Enum = ChangeEnum.The509 };

                        case "5.1.0":
                            return new ChangeElement { Enum = ChangeEnum.The510 };

                        case "5.1.1":
                            return new ChangeElement { Enum = ChangeEnum.The511 };

                        case "5.10.0":
                            return new ChangeElement { Enum = ChangeEnum.The5100 };

                        case "5.10.1":
                            return new ChangeElement { Enum = ChangeEnum.The5101 };

                        case "5.10.2":
                            return new ChangeElement { Enum = ChangeEnum.The5102 };

                        case "5.11.0":
                            return new ChangeElement { Enum = ChangeEnum.The5110 };

                        case "5.11.1":
                            return new ChangeElement { Enum = ChangeEnum.The5111 };

                        case "5.11.2":
                            return new ChangeElement { Enum = ChangeEnum.The5112 };

                        case "5.2.0":
                            return new ChangeElement { Enum = ChangeEnum.The520 };

                        case "5.3.0":
                            return new ChangeElement { Enum = ChangeEnum.The530 };

                        case "5.4.0":
                            return new ChangeElement { Enum = ChangeEnum.The540 };

                        case "5.4.1":
                            return new ChangeElement { Enum = ChangeEnum.The541 };

                        case "5.4.2":
                            return new ChangeElement { Enum = ChangeEnum.The542 };

                        case "5.5.0":
                            return new ChangeElement { Enum = ChangeEnum.The550 };

                        case "5.6.0":
                            return new ChangeElement { Enum = ChangeEnum.The560 };

                        case "5.6.1":
                            return new ChangeElement { Enum = ChangeEnum.The561 };

                        case "5.6.3":
                            return new ChangeElement { Enum = ChangeEnum.The563 };

                        case "5.7.0":
                            return new ChangeElement { Enum = ChangeEnum.The570 };

                        case "5.7.1":
                            return new ChangeElement { Enum = ChangeEnum.The571 };

                        case "5.8.0":
                            return new ChangeElement { Enum = ChangeEnum.The580 };

                        case "5.8.1":
                            return new ChangeElement { Enum = ChangeEnum.The581 };

                        case "5.8.2":
                            return new ChangeElement { Enum = ChangeEnum.The582 };

                        case "5.9.0":
                            return new ChangeElement { Enum = ChangeEnum.The590 };
                    }
                    long l;
                    if (Int64.TryParse(stringValue, out l))
                    {
                        return new ChangeElement { Integer = l };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type ChangeElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ChangeElement)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case ChangeEnum.The31:
                        serializer.Serialize(writer, "3.1");
                        return;

                    case ChangeEnum.The32:
                        serializer.Serialize(writer, "3.2");
                        return;

                    case ChangeEnum.The41:
                        serializer.Serialize(writer, "4.1");
                        return;

                    case ChangeEnum.The42:
                        serializer.Serialize(writer, "4.2");
                        return;

                    case ChangeEnum.The43:
                        serializer.Serialize(writer, "4.3");
                        return;

                    case ChangeEnum.The44:
                        serializer.Serialize(writer, "4.4");
                        return;

                    case ChangeEnum.The45:
                        serializer.Serialize(writer, "4.5");
                        return;

                    case ChangeEnum.The46:
                        serializer.Serialize(writer, "4.6");
                        return;

                    case ChangeEnum.The47:
                        serializer.Serialize(writer, "4.7");
                        return;

                    case ChangeEnum.The500:
                        serializer.Serialize(writer, "5.0.0");
                        return;

                    case ChangeEnum.The501:
                        serializer.Serialize(writer, "5.0.1");
                        return;

                    case ChangeEnum.The5010:
                        serializer.Serialize(writer, "5.0.10");
                        return;

                    case ChangeEnum.The5011:
                        serializer.Serialize(writer, "5.0.11");
                        return;

                    case ChangeEnum.The5012:
                        serializer.Serialize(writer, "5.0.12");
                        return;

                    case ChangeEnum.The5013:
                        serializer.Serialize(writer, "5.0.13");
                        return;

                    case ChangeEnum.The502:
                        serializer.Serialize(writer, "5.0.2");
                        return;

                    case ChangeEnum.The503:
                        serializer.Serialize(writer, "5.0.3");
                        return;

                    case ChangeEnum.The505:
                        serializer.Serialize(writer, "5.0.5");
                        return;

                    case ChangeEnum.The507:
                        serializer.Serialize(writer, "5.0.7");
                        return;

                    case ChangeEnum.The509:
                        serializer.Serialize(writer, "5.0.9");
                        return;

                    case ChangeEnum.The510:
                        serializer.Serialize(writer, "5.1.0");
                        return;

                    case ChangeEnum.The511:
                        serializer.Serialize(writer, "5.1.1");
                        return;

                    case ChangeEnum.The5100:
                        serializer.Serialize(writer, "5.10.0");
                        return;

                    case ChangeEnum.The5101:
                        serializer.Serialize(writer, "5.10.1");
                        return;

                    case ChangeEnum.The5102:
                        serializer.Serialize(writer, "5.10.2");
                        return;

                    case ChangeEnum.The5110:
                        serializer.Serialize(writer, "5.11.0");
                        return;

                    case ChangeEnum.The5111:
                        serializer.Serialize(writer, "5.11.1");
                        return;

                    case ChangeEnum.The5112:
                        serializer.Serialize(writer, "5.11.2");
                        return;

                    case ChangeEnum.The520:
                        serializer.Serialize(writer, "5.2.0");
                        return;

                    case ChangeEnum.The530:
                        serializer.Serialize(writer, "5.3.0");
                        return;

                    case ChangeEnum.The540:
                        serializer.Serialize(writer, "5.4.0");
                        return;

                    case ChangeEnum.The541:
                        serializer.Serialize(writer, "5.4.1");
                        return;

                    case ChangeEnum.The542:
                        serializer.Serialize(writer, "5.4.2");
                        return;

                    case ChangeEnum.The550:
                        serializer.Serialize(writer, "5.5.0");
                        return;

                    case ChangeEnum.The560:
                        serializer.Serialize(writer, "5.6.0");
                        return;

                    case ChangeEnum.The561:
                        serializer.Serialize(writer, "5.6.1");
                        return;

                    case ChangeEnum.The563:
                        serializer.Serialize(writer, "5.6.3");
                        return;

                    case ChangeEnum.The570:
                        serializer.Serialize(writer, "5.7.0");
                        return;

                    case ChangeEnum.The571:
                        serializer.Serialize(writer, "5.7.1");
                        return;

                    case ChangeEnum.The580:
                        serializer.Serialize(writer, "5.8.0");
                        return;

                    case ChangeEnum.The581:
                        serializer.Serialize(writer, "5.8.1");
                        return;

                    case ChangeEnum.The582:
                        serializer.Serialize(writer, "5.8.2");
                        return;

                    case ChangeEnum.The590:
                        serializer.Serialize(writer, "5.9.0");
                        return;
                }
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value.ToString());
                return;
            }
            throw new Exception("Cannot marshal type ChangeElement");
        }
    }

    internal class ChangeEnumConverter : JsonConverter
    {
        public static readonly ChangeEnumConverter Singleton = new ChangeEnumConverter();

        public override bool CanConvert(Type t) => t == typeof(ChangeEnum) || t == typeof(ChangeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "3.1":
                    return ChangeEnum.The31;

                case "3.2":
                    return ChangeEnum.The32;

                case "4.1":
                    return ChangeEnum.The41;

                case "4.2":
                    return ChangeEnum.The42;

                case "4.3":
                    return ChangeEnum.The43;

                case "4.4":
                    return ChangeEnum.The44;

                case "4.5":
                    return ChangeEnum.The45;

                case "4.6":
                    return ChangeEnum.The46;

                case "4.7":
                    return ChangeEnum.The47;

                case "5.0.0":
                    return ChangeEnum.The500;

                case "5.0.1":
                    return ChangeEnum.The501;

                case "5.0.10":
                    return ChangeEnum.The5010;

                case "5.0.11":
                    return ChangeEnum.The5011;

                case "5.0.12":
                    return ChangeEnum.The5012;

                case "5.0.13":
                    return ChangeEnum.The5013;

                case "5.0.2":
                    return ChangeEnum.The502;

                case "5.0.3":
                    return ChangeEnum.The503;

                case "5.0.5":
                    return ChangeEnum.The505;

                case "5.0.7":
                    return ChangeEnum.The507;

                case "5.0.9":
                    return ChangeEnum.The509;

                case "5.1.0":
                    return ChangeEnum.The510;

                case "5.1.1":
                    return ChangeEnum.The511;

                case "5.10.0":
                    return ChangeEnum.The5100;

                case "5.10.1":
                    return ChangeEnum.The5101;

                case "5.10.2":
                    return ChangeEnum.The5102;

                case "5.11.0":
                    return ChangeEnum.The5110;

                case "5.11.1":
                    return ChangeEnum.The5111;

                case "5.11.2":
                    return ChangeEnum.The5112;

                case "5.2.0":
                    return ChangeEnum.The520;

                case "5.3.0":
                    return ChangeEnum.The530;

                case "5.4.0":
                    return ChangeEnum.The540;

                case "5.4.1":
                    return ChangeEnum.The541;

                case "5.4.2":
                    return ChangeEnum.The542;

                case "5.5.0":
                    return ChangeEnum.The550;

                case "5.6.0":
                    return ChangeEnum.The560;

                case "5.6.1":
                    return ChangeEnum.The561;

                case "5.6.3":
                    return ChangeEnum.The563;

                case "5.7.0":
                    return ChangeEnum.The570;

                case "5.7.1":
                    return ChangeEnum.The571;

                case "5.8.0":
                    return ChangeEnum.The580;

                case "5.8.1":
                    return ChangeEnum.The581;

                case "5.8.2":
                    return ChangeEnum.The582;

                case "5.9.0":
                    return ChangeEnum.The590;
            }
            throw new Exception("Cannot unmarshal type ChangeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ChangeEnum)untypedValue;
            switch (value)
            {
                case ChangeEnum.The31:
                    serializer.Serialize(writer, "3.1");
                    return;

                case ChangeEnum.The32:
                    serializer.Serialize(writer, "3.2");
                    return;

                case ChangeEnum.The41:
                    serializer.Serialize(writer, "4.1");
                    return;

                case ChangeEnum.The42:
                    serializer.Serialize(writer, "4.2");
                    return;

                case ChangeEnum.The43:
                    serializer.Serialize(writer, "4.3");
                    return;

                case ChangeEnum.The44:
                    serializer.Serialize(writer, "4.4");
                    return;

                case ChangeEnum.The45:
                    serializer.Serialize(writer, "4.5");
                    return;

                case ChangeEnum.The46:
                    serializer.Serialize(writer, "4.6");
                    return;

                case ChangeEnum.The47:
                    serializer.Serialize(writer, "4.7");
                    return;

                case ChangeEnum.The500:
                    serializer.Serialize(writer, "5.0.0");
                    return;

                case ChangeEnum.The501:
                    serializer.Serialize(writer, "5.0.1");
                    return;

                case ChangeEnum.The5010:
                    serializer.Serialize(writer, "5.0.10");
                    return;

                case ChangeEnum.The5011:
                    serializer.Serialize(writer, "5.0.11");
                    return;

                case ChangeEnum.The5012:
                    serializer.Serialize(writer, "5.0.12");
                    return;

                case ChangeEnum.The5013:
                    serializer.Serialize(writer, "5.0.13");
                    return;

                case ChangeEnum.The502:
                    serializer.Serialize(writer, "5.0.2");
                    return;

                case ChangeEnum.The503:
                    serializer.Serialize(writer, "5.0.3");
                    return;

                case ChangeEnum.The505:
                    serializer.Serialize(writer, "5.0.5");
                    return;

                case ChangeEnum.The507:
                    serializer.Serialize(writer, "5.0.7");
                    return;

                case ChangeEnum.The509:
                    serializer.Serialize(writer, "5.0.9");
                    return;

                case ChangeEnum.The510:
                    serializer.Serialize(writer, "5.1.0");
                    return;

                case ChangeEnum.The511:
                    serializer.Serialize(writer, "5.1.1");
                    return;

                case ChangeEnum.The5100:
                    serializer.Serialize(writer, "5.10.0");
                    return;

                case ChangeEnum.The5101:
                    serializer.Serialize(writer, "5.10.1");
                    return;

                case ChangeEnum.The5102:
                    serializer.Serialize(writer, "5.10.2");
                    return;

                case ChangeEnum.The5110:
                    serializer.Serialize(writer, "5.11.0");
                    return;

                case ChangeEnum.The5111:
                    serializer.Serialize(writer, "5.11.1");
                    return;

                case ChangeEnum.The5112:
                    serializer.Serialize(writer, "5.11.2");
                    return;

                case ChangeEnum.The520:
                    serializer.Serialize(writer, "5.2.0");
                    return;

                case ChangeEnum.The530:
                    serializer.Serialize(writer, "5.3.0");
                    return;

                case ChangeEnum.The540:
                    serializer.Serialize(writer, "5.4.0");
                    return;

                case ChangeEnum.The541:
                    serializer.Serialize(writer, "5.4.1");
                    return;

                case ChangeEnum.The542:
                    serializer.Serialize(writer, "5.4.2");
                    return;

                case ChangeEnum.The550:
                    serializer.Serialize(writer, "5.5.0");
                    return;

                case ChangeEnum.The560:
                    serializer.Serialize(writer, "5.6.0");
                    return;

                case ChangeEnum.The561:
                    serializer.Serialize(writer, "5.6.1");
                    return;

                case ChangeEnum.The563:
                    serializer.Serialize(writer, "5.6.3");
                    return;

                case ChangeEnum.The570:
                    serializer.Serialize(writer, "5.7.0");
                    return;

                case ChangeEnum.The571:
                    serializer.Serialize(writer, "5.7.1");
                    return;

                case ChangeEnum.The580:
                    serializer.Serialize(writer, "5.8.0");
                    return;

                case ChangeEnum.The581:
                    serializer.Serialize(writer, "5.8.1");
                    return;

                case ChangeEnum.The582:
                    serializer.Serialize(writer, "5.8.2");
                    return;

                case ChangeEnum.The590:
                    serializer.Serialize(writer, "5.9.0");
                    return;
            }
            throw new Exception("Cannot marshal type ChangeEnum");
        }
    }

    internal class DecodeArrayConverter : JsonConverter
    {
        public static readonly DecodeArrayConverter Singleton = new DecodeArrayConverter();

        public override bool CanConvert(Type t) => t == typeof(long[]);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            reader.Read();
            var value = new List<long>();
            while (reader.TokenType != JsonToken.EndArray)
            {
                var converter = ParseStringConverter.Singleton;
                var arrayItem = (long)converter.ReadJson(reader, typeof(long), null, serializer);
                value.Add(arrayItem);
                reader.Read();
            }
            return value.ToArray();
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (long[])untypedValue;
            writer.WriteStartArray();
            foreach (var arrayItem in value)
            {
                var converter = ParseStringConverter.Singleton;
                converter.WriteJson(writer, arrayItem, serializer);
            }
            writer.WriteEndArray();
            return;
        }
    }

    internal class FreeConverter : JsonConverter
    {
        public static readonly FreeConverter Singleton = new FreeConverter();

        public override bool CanConvert(Type t) => t == typeof(Free) || t == typeof(Free?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "brands":
                    return Free.Brands;

                case "duotone":
                    return Free.Duotone;

                case "light":
                    return Free.Light;

                case "regular":
                    return Free.Regular;

                case "solid":
                    return Free.Solid;
            }
            throw new Exception("Cannot unmarshal type Free");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Free)untypedValue;
            switch (value)
            {
                case Free.Brands:
                    serializer.Serialize(writer, "brands");
                    return;

                case Free.Duotone:
                    serializer.Serialize(writer, "duotone");
                    return;

                case Free.Light:
                    serializer.Serialize(writer, "light");
                    return;

                case Free.Regular:
                    serializer.Serialize(writer, "regular");
                    return;

                case Free.Solid:
                    serializer.Serialize(writer, "solid");
                    return;
            }
            throw new Exception("Cannot marshal type Free");
        }
    }

    internal class ParseStringConverter : JsonConverter
    {
        public static readonly ParseStringConverter Singleton = new ParseStringConverter();

        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }
    }

    internal class TermConverter : JsonConverter
    {
        public static readonly TermConverter Singleton = new TermConverter();

        public override bool CanConvert(Type t) => t == typeof(Term) || t == typeof(Term?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new Term { Integer = integerValue };

                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Term { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type Term");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Term)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            throw new Exception("Cannot marshal type Term");
        }
    }
}