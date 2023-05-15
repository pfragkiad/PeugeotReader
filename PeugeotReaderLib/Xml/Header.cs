// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(ECUDataLogFile));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (ECUDataLogFile)serializer.Deserialize(reader);
// }

namespace PeugeotReaderLib.Xml;

using System.Xml.Serialization;

[XmlRoot(ElementName = "Header")]
public class Header
{

    [XmlAttribute(AttributeName = "LogName")]
    public string LogName { get; set; }

    [XmlAttribute(AttributeName = "Duration")]
    public int Duration { get; set; }

    [XmlAttribute(AttributeName = "_Type")]
    public string Type { get; set; }

    [XmlAttribute(AttributeName = "CaptureTime")]
    public int CaptureTime { get; set; }

    [XmlAttribute(AttributeName = "VehicleName")]
    public string VehicleName { get; set; }

    [XmlAttribute(AttributeName = "VehicleLabel")]
    public int VehicleLabel { get; set; }

    [XmlAttribute(AttributeName = "ECUName")]
    public string ECUName { get; set; }

    [XmlAttribute(AttributeName = "ECULabel")]
    public string ECULabel { get; set; }
}

