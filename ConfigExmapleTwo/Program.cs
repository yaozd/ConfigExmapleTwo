using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigExmapleTwo.Config;

namespace ConfigExmapleTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //读取配置文件
            var configInfo = ConfigInfoHelper.Instance.Info;
            //将配置信息转化为XML文件
            var configInfoXml = SerializeHelper.ToXml(configInfo);
            //
            Console.WriteLine(configInfoXml);
            //
            Console.ReadKey();
        }
    }
}
