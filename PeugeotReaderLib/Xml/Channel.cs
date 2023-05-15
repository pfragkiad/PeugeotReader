// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(ECUDataLogFile));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (ECUDataLogFile)serializer.Deserialize(reader);
// }

namespace PeugeotReaderLib.Xml;

using System.Xml.Serialization;

[XmlRoot(ElementName = "Channel")]
public class Channel
{

    [XmlElement(ElementName = "ChannelHeader")]
    public ChannelHeader ChannelHeader { get; set; }

    [XmlElement(ElementName = "Points")]
    public Points Points { get; set; }
}

