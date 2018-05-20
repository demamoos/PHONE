
using System.IO;
using System.Xml.Serialization;

namespace Electronic




{
    public static class ElectronicHelper
    {
        private static readonly XmlSerializer Xml = new XmlSerializer(typeof(Choice));
        public static void WriteToFile(string fileName, Choice data)
        {
            using (var fileStream = File.Create(fileName))
            {
                Xml.Serialize(fileStream, data);
            }
        }

        public static Choice LoadFromFile(string fileName)
        {
            using (var fileStream = File.OpenRead(fileName))
            {
                return (Choice)Xml.Deserialize(fileStream);
            }
        }
    }
}