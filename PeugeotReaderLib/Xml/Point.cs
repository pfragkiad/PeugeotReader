// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(ECUDataLogFile));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (ECUDataLogFile)serializer.Deserialize(reader);
// }

namespace PeugeotReaderLib.Xml;

using System.Xml.Serialization;

[XmlRoot(ElementName = "Point")]
public class Point
{

    [XmlAttribute(AttributeName = "Value")]
    public double Value { get; set; }

    [XmlAttribute(AttributeName = "Timestamp")]
    public int Timestamp { get; set; }
}

