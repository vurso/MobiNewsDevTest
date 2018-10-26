using System.Collections.Generic;
using System.Xml.Serialization;

public class PublishingXml
{
    public int PublishingId { get; set; }
    public IEnumerable<PublishingStory> Stories { get; set; }
}

[XmlRoot("story")]
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