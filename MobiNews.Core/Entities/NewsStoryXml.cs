using System;
using System.Xml.Serialization;

[Serializable]
[XmlRoot(ElementName = "NewsStory", IsNullable = false)]
public class NewsStoryXml
{
    [XmlElement("id")]
    public string Id { get; set; }
    [XmlElement("topTitle")]
    public string TopTitle { get; set; }
    [XmlElement("body")]
    public string Body { get; set; }
    [XmlElement("imageloc")]
    public string Imageloc { get; set; }
}