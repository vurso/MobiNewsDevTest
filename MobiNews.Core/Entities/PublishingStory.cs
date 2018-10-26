
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class PublishingXml
{

    private byte publishingidField;

    private PublishingStory[] storiesField;

    /// <remarks/>
    public byte Publishingid
    {
        get
        {
            return this.publishingidField;
        }
        set
        {
            this.publishingidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("story", IsNullable = false)]
    public PublishingStory[] Stories
    {
        get
        {
            return this.storiesField;
        }
        set
        {
            this.storiesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class PublishingStory
{

    private ushort idField;

    private string titleField;

    private string newstoryTextField;

    private string imageField;

    /// <remarks/>
    public ushort Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    public string Title
    {
        get
        {
            return this.titleField;
        }
        set
        {
            this.titleField = value;
        }
    }

    /// <remarks/>
    public string NewStoryText
    {
        get
        {
            return this.newstoryTextField;
        }
        set
        {
            this.newstoryTextField = value;
        }
    }

    /// <remarks/>
    public string Image
    {
        get
        {
            return this.imageField;
        }
        set
        {
            this.imageField = value;
        }
    }
}

