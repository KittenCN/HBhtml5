using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

/// <summary>
/// returnsms 的摘要说明
/// </summary>
public class returnsms
{
    public returnsms()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    private string returnstatus;
    public string ReturnStatus
    {
        get { return returnstatus; }
        set { returnstatus = value; }
    }

    private string message;
    public string Message
    {
        get { return message; }
        set { message = value; }
    }

    private string payinfo;
    public string PayInfo
    {
        get { return payinfo; }
        set { payinfo = value; }
    }

    private string overage;
    public string Overage
    {
        get { return overage; }
        set { overage = value; }
    }

    private string sendtotal;
    public string SendTotal
    {
        get { return sendtotal; }
        set { sendtotal = value; }
    }

    public void ReadXML(XmlNode xn)
    {
        ReturnStatus = xn.SelectSingleNode("returnstatus").InnerText;
        Message = xn.SelectSingleNode("message").InnerText;
        //PayInfo = xn.SelectSingleNode("remainpoint").InnerText;
        //Overage = xn.SelectSingleNode("taskID").InnerText;
        //SendTotal = xn.SelectSingleNode("successCounts").InnerText;
    }
}