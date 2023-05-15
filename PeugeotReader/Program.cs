using PeugeotReaderLib.Xml;
using System.Diagnostics;
using System.Globalization;
using System.Xml.Serialization;



namespace PeugeotReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            //string path = @"D:\peugeot\642199d40b71b211211476\642199d40b71b211211476.MPM.20230327-153645.xml";
            string path = @"D:\repos\pfragkiad\peugeot\PeugeotReader\data_frena\645e6ea57270e580679881\645e6ea57270e580679881.MPM.20230512-185909.xml";
            string basePath = Path.GetDirectoryName(path); //@"D:\peugeot\642199d40b71b211211476";
          
            string xml = File.ReadAllText(path);

            XmlSerializer serializer = new XmlSerializer(typeof(ECUDataLogFile));
            using StringReader reader = new StringReader(xml);
            ECUDataLogFile? file = (ECUDataLogFile)serializer.Deserialize(reader);

            foreach (var channel in file.Channel)
            {
                string outputPath = Path.Combine(basePath, channel.ChannelHeader.Mnemo + ".txt");

                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    foreach (var p in channel.Points.Point)
                        writer.WriteLine($"{p.Timestamp}\t{p.Value}");
                }
            }





        }
    }
}