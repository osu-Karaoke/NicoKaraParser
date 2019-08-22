﻿using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "RubyInfo")]
    public class RubyInfo
    {
        [XmlElement(ElementName = "Kanji")]
        public string Kanji { get; set; }
        [XmlElement(ElementName = "Ruby")]
        public string Ruby { get; set; }
        [XmlElement(ElementName = "RubyParts")]
        public RubyParts RubyParts { get; set; }
        [XmlElement(ElementName = "BeginTime")]
        public string BeginTime { get; set; }
        [XmlElement(ElementName = "EndTime")]
        public string EndTime { get; set; }
    }
}