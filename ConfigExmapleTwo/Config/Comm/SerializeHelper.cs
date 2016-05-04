using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ConfigExmapleTwo.Config
{
    /// <summary>
    /// 序列化--C#内置的序列化方法
    /// </summary>
    internal class SerializeHelper
    {
        #region XML

        /// <summary>
        /// XML序列化
        /// </summary>
        /// <param name="item">对象</param>
        public static string ToXml<T>(T item)
        {
            XmlSerializer serializer = new XmlSerializer(item.GetType());
            StringBuilder sb = new StringBuilder();
            using (XmlWriter writer = XmlWriter.Create(sb))
            {
                serializer.Serialize(writer, item);
                return sb.ToString();
            }
        }

        /// <summary>
        /// XML反序列化
        /// </summary>
        /// <param name="str">字符串序列</param>
        public static T FromXml<T>(string str)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (XmlReader reader = new XmlTextReader(new StringReader(str)))
            {
                return (T)serializer.Deserialize(reader);
            }
        }

        #endregion
        #region JSON
        /// <summary>
        /// JSON序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string ToJson<T>(T item)
        {
            var serializer = new DataContractJsonSerializer(item.GetType());
            using (var ms = new MemoryStream())
            {
                serializer.WriteObject(ms, item);
                var sb = new StringBuilder();
                sb.Append(Encoding.UTF8.GetString(ms.ToArray()));
                return sb.ToString();
            }
        }
        /// <summary>
        /// JSON反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <returns></returns>
        public static T FromJson<T>(string str)
        {
            var ser = new DataContractJsonSerializer(typeof(T));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(str));

            var obj = (T)ser.ReadObject(ms);

            return obj;
        }

        #endregion
    }
}