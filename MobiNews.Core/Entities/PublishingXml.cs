using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[Serializable, XmlRoot("publishing")]
public class PublishingXml
{
    [XmlElement("publishingid")]
    public int PublishingId { get; set; }
    [XmlArray("stories")]
    [XmlArrayItem("story")]
    public PublishingStory [] Stories { get; set; }
}

[Serializable, XmlRoot("story")]
public class PublishingStory
{
    [XmlElement("id")]
    public int Id { get; set; }
    [XmlElement("title")]
    public string Title { get; set; }
    [XmlElement("newstoryText")]
    public string NewStoryText { get; set; }
    [XmlElement("image")]
    public string ImageUri { get; set; }
}