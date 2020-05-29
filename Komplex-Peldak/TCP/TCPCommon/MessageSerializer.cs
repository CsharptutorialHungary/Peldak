using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace TCPCommon
{
    public static class MessageSerializer
    {
        private static BinaryFormatter bf = new BinaryFormatter();

        public static void SerializeTo<T>(Stream target, T data)
        {
            bf.Serialize(target, data);
            target.Flush();
        }

        public static T SerializeFrom<T>(Stream source)
        {
            return (T)bf.Deserialize(source);
        }

    }
}
