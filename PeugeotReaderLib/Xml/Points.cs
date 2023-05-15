// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(ECUDataLogFile));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (ECUDataLogFile)serializer.Deserialize(reader);
// }

namespace PeugeotReaderLib.Xml;

using System.Xml.Serialization;

[XmlRoot(ElementName = "Points")]
public class Points
{

    [XmlElement(ElementName = "Point")]
    public List<Point> Point { get; set; }
}

