// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(ECUDataLogFile));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (ECUDataLogFile)serializer.Deserialize(reader);
// }

namespace PeugeotReaderLib.Xml;

using System.Xml.Serialization;

[XmlRoot(ElementName = "ChannelHeader")]
public class ChannelHeader
{

    [XmlElement(ElementName = "DiscreteLegend")]
    public DiscreteLegend DiscreteLegend { get; set; }

    [XmlAttribute(AttributeName = "Id")]
    public int Id { get; set; }

    [XmlAttribute(AttributeName = "Mnemo")]
    public string Mnemo { get; set; }

    [XmlAttribute(AttributeName = "Label")]
    public string Label { get; set; }

    [XmlAttribute(AttributeName = "_Type")]
    public string Type { get; set; }

    [XmlAttribute(AttributeName = "Unit")]
    public string Unit { get; set; }

    [XmlAttribute(AttributeName = "MinVal")]
    public double MinVal { get; set; }

    [XmlAttribute(AttributeName = "MaxVal")]
    public double MaxVal { get; set; }
}

