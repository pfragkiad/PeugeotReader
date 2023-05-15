// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(ECUDataLogFile));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (ECUDataLogFile)serializer.Deserialize(reader);
// }

namespace PeugeotReaderLib.Xml;

using System.Xml.Serialization;

[XmlRoot(ElementName = "DiscreteValue")]
public class DiscreteValue
{

    [XmlAttribute(AttributeName = "Label")]
    public string Label { get; set; }

    [XmlAttribute(AttributeName = "MinVal")]
    public double MinVal { get; set; }

    [XmlAttribute(AttributeName = "MaxVal")]
    public double MaxVal { get; set; }
}

