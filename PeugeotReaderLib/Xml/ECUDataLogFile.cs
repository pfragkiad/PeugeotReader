// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(ECUDataLogFile));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (ECUDataLogFile)serializer.Deserialize(reader);
// }

namespace PeugeotReaderLib.Xml;

using System.Xml.Serialization;

[XmlRoot(ElementName = "ECUDataLogFile")]
public class ECUDataLogFile
{

    [XmlElement(ElementName = "Header")]
    public Header Header { get; set; }

    [XmlElement(ElementName = "Channel")]
    public List<Channel> Channel { get; set; }
}

