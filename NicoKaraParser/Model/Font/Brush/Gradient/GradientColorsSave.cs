﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace NicoKaraParser.Model
{
    [XmlRoot(ElementName = "GradientColorsSave")]
    public class GradientColorsSave
    {
        [XmlElement(ElementName = "int")]
        public List<string> Int { get; set; }
    }
}