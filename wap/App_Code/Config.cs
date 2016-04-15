using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Xml;

/// <summary>
/// Config 的摘要说明
/// </summary>
public class Config
{
    public Config()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public string GetLinkString()
    {
        string LinkString = "Server=localhost;user id=root;password=;Database=chenkuserdb3;Port=3308;charset=utf8;";
        //读取配置文件config.xml
        if (File.Exists(HttpContext.Current.Server.MapPath("Config.xml")))
        {
            try
            {
                XmlDocument xmlCon = new XmlDocument();
                xmlCon.Load(HttpContext.Current.Server.MapPath("Config.xml"));
                XmlNode xnCon = xmlCon.SelectSingleNode("Config");
                LinkString = xnCon.SelectSingleNode("LinkString").InnerText;
            }
            catch
            {
                LinkString = "Server=localhost;user id=root;password=;Database=chenkuserdb37;Port=3308;charset=utf8;";
            }
        }
        else
        {
            LinkString = "Server=localhost;user id=root;password=;Database=chenkuserdb37;Port=3308;charset=utf8;";
        }

        return LinkString;
    }
}