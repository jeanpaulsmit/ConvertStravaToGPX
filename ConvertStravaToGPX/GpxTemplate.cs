using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Didago.ConvertStravaToGPX;


// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.topografix.com/GPX/1/1")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.topografix.com/GPX/1/1", IsNullable = false)]
public partial class gpx
{

    private gpxMetadata metadataField;

    private gpxTrk trkField;

    private decimal versionField;

    private string creatorField;

    /// <remarks/>
    public gpxMetadata metadata
    {
        get
        {
            return this.metadataField;
        }
        set
        {
            this.metadataField = value;
        }
    }

    /// <remarks/>
    public gpxTrk trk
    {
        get
        {
            return this.trkField;
        }
        set
        {
            this.trkField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string creator
    {
        get
        {
            return this.creatorField;
        }
        set
        {
            this.creatorField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.topografix.com/GPX/1/1")]
public partial class gpxMetadata
{

    private object timeField;

    private gpxMetadataLink linkField;

    /// <remarks/>
    public object time
    {
        get
        {
            return this.timeField;
        }
        set
        {
            this.timeField = value;
        }
    }

    /// <remarks/>
    public gpxMetadataLink link
    {
        get
        {
            return this.linkField;
        }
        set
        {
            this.linkField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.topografix.com/GPX/1/1")]
public partial class gpxMetadataLink
{

    private string textField;

    private string hrefField;

    /// <remarks/>
    public string text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string href
    {
        get
        {
            return this.hrefField;
        }
        set
        {
            this.hrefField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.topografix.com/GPX/1/1")]
public partial class gpxTrk
{

    private object nameField;

    private string typeField;

    private gpxTrkTrkpt[] trksegField;

    /// <remarks/>
    public object name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("trkpt", IsNullable = false)]
    public gpxTrkTrkpt[] trkseg
    {
        get
        {
            return this.trksegField;
        }
        set
        {
            this.trksegField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.topografix.com/GPX/1/1")]
public partial class gpxTrkTrkpt
{

    private decimal eleField;

    private System.DateTime timeField;

    private gpxTrkTrkptExtensions extensionsField;

    private decimal latField;

    private decimal lonField;

    /// <remarks/>
    public decimal ele
    {
        get
        {
            return this.eleField;
        }
        set
        {
            this.eleField = value;
        }
    }

    /// <remarks/>
    public System.DateTime time
    {
        get
        {
            return this.timeField;
        }
        set
        {
            this.timeField = value;
        }
    }

    /// <remarks/>
    public gpxTrkTrkptExtensions extensions
    {
        get
        {
            return this.extensionsField;
        }
        set
        {
            this.extensionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lat
    {
        get
        {
            return this.latField;
        }
        set
        {
            this.latField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal lon
    {
        get
        {
            return this.lonField;
        }
        set
        {
            this.lonField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.topografix.com/GPX/1/1")]
public partial class gpxTrkTrkptExtensions
{

    private TrackPointExtension trackPointExtensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.garmin.com/xmlschemas/TrackPointExtension/v1")]
    public TrackPointExtension TrackPointExtension
    {
        get
        {
            return this.trackPointExtensionField;
        }
        set
        {
            this.trackPointExtensionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.garmin.com/xmlschemas/TrackPointExtension/v1")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.garmin.com/xmlschemas/TrackPointExtension/v1", IsNullable = false)]
public partial class TrackPointExtension
{

    private byte hrField;

    private byte atempField;

    /// <remarks/>
    public byte hr
    {
        get
        {
            return this.hrField;
        }
        set
        {
            this.hrField = value;
        }
    }

    /// <remarks/>
    public byte atemp
    {
        get
        {
            return this.atempField;
        }
        set
        {
            this.atempField = value;
        }
    }
}

