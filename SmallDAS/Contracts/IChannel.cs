using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SmallDAS
{
    [XmlRoot(ElementName = "Channel")]
    public interface IChannel
    {
        [XmlAttribute(AttributeName = "Id")]
        int Id { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        string Name { get; set; }

        [XmlAttribute(AttributeName = "Description")]
        string Description { get; set; }

        [XmlAttribute(AttributeName = "Type")]
        ChannelType Type { get; set; }

        [XmlAttribute(AttributeName = "RecordingMask")]
        int RecordingMask { get; set; }

        [XmlAttribute(AttributeName = "Text")]
        string Text { get; set; }

        [XmlAttribute(AttributeName = "Value")]
        double Value { get; set; }

        [XmlAttribute(AttributeName = "Parser")]
        int Parser { get; set; }
    }
}
