// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(ECUDataLogFile));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (ECUDataLogFile)serializer.Deserialize(reader);
// }

namespace PeugeotReaderLib.Xml;

using System.Xml.Serialization;

[XmlRoot(ElementName = "DiscreteLegend")]
public class DiscreteLegend
{

    [XmlElement(ElementName = "DiscreteValue")]
    public List<DiscreteValue> DiscreteValue { get; set; }
}

