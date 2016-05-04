using System;
using System.Xml.Serialization;

namespace ConfigExmapleTwo.Config
{
    /// <summary>
    /// 项目配置信息--Model
    /// </summary>
    [Serializable]
    [XmlRoot("ArrayOfConfigInfo")]
    public class ArrayOfConfigInfo
    {
        [XmlElement(ElementName = "ConfigInfo_NewMyCat")]
        public ConfigInfo Info { get; set; }
    }
    /// <summary>
    /// 指定项目的配置信息
    /// </summary>
    public class ConfigInfo
    {
        private string catErrorLogName = "CatError.log";
        /// <summary>
        /// Cat本身错误日志打点信息的存储名称
        /// 相对路径(relativePath)
        /// </summary>
        public string CatErrorLogName
        {
            get { return catErrorLogName; }
            set { catErrorLogName = value; }
        }
        private string catErrorLogPath = PublicCon.BaseDirectory();
        /// <summary>
        /// Cat本身错误日志打点信息的存储路径
        /// 绝对路径(absolutePath)
        /// </summary>
        public string CatErrorLogPath
        {
            get { return catErrorLogPath; }
            set { catErrorLogPath = value; }
        }
        /// <summary>
        /// Cat本身错误日志打点信息的存储完整路径
        /// </summary>
        [XmlIgnore]
        public string CatErrorLogFullPath
        {
            get { return PublicCon.PathCombine(CatErrorLogPath, CatErrorLogName); }
        }
    }
}