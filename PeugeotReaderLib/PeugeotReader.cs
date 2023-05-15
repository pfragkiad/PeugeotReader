using PeugeotReaderLib.Xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PeugeotReaderLib;

public class PeugeotReader
{

    public ECUDataLogFile? Read(string inputFile)
    {
        string xmlContent = File.ReadAllText(inputFile,Encoding.UTF8);
        XmlSerializer serializer = new XmlSerializer(typeof(ECUDataLogFile));
        using StringReader reader = new StringReader(xmlContent);
        return (ECUDataLogFile?)serializer.Deserialize(reader);
    }

    public void Export(string inputFile, string targetPath)
    {
        var file = Read(inputFile);
    }
}
