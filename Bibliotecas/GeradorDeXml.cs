using System.Xml.Serialization;
using System.IO;

namespace DesignPatterns2.Bibliotecas
{
    public class GeradorDeXml
    {


        public string GeraXML(object obj)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, obj);
            return writer.ToString();

        }

    }
}
