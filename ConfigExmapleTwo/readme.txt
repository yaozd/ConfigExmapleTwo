自定义配置解决方案Two--V0.01 说明：实现简单的配置加载
https://github.com/yaozd/ConfigExmapleTwo
作用：
一个项目下需要相同节点配置信息
e.g:
---
App.config:

<configuration>
  <appSettings>
    <add key="ConfigInfoPath" value="ConfigXml\ProjectConfigInfo.xml" />
  </appSettings>
</configuration>
---
ProjectConfigInfo.xml

<?xml version="1.0" encoding="utf-8" ?>
<ArrayOfConfigInfo xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <ConfigInfo_NewMyCat>
    <CatErrorLogName>CatError.log</CatErrorLogName>
    <CatErrorLogPath>E:\workspace\TEMP\03\ConfigExmapleTwo\ConfigExmapleTwo\bin\Debug\</CatErrorLogPath>
  </ConfigInfo_NewMyCat>
  <ConfigInfo>
    <Id>2</Id>
    <Name>XX名称</Name>
    <Description>配置说明</Description>
    <Json>json格式的配置信息</Json>
  </ConfigInfo>
</ArrayOfConfigInfo>
---

------------
参考：
自定义配置解决方案--V0.01 说明：实现简单的配置加载
https://github.com/yaozd/ConfigExample
作用：
一个项目下需要多种相同节点但内容不同的配置读取
e.g:
---
<?xml version="1.0"?>
<ArrayOfConfigInfo xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <ConfigInfo>
    <Id>1</Id>
    <Name>XX地址-业务对接</Name>
    <Description>XX使用的时sftp方法进行文件传输</Description>
    <Json>
      <![CDATA[
      {
      "FtpPassword": "1",
      "FtpRemotePath": "1",
      "FtpServerIp": "1",
      "FtpUserId": "1"
      }]]>
    </Json>
  </ConfigInfo>
  <ConfigInfo>
    <Id>2</Id>
    <Name>XX名称</Name>
    <Description>配置说明</Description>
    <Json>json格式的配置信息</Json>
  </ConfigInfo>
</ArrayOfConfigInfo>
---

------------